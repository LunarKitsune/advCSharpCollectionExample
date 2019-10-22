using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractExample
{
    public partial class frmMain : Form
    {
        ContractorCollection collectionOfContracts = new ContractorCollection();
        RecordKeeper dataKeeper = new RecordKeeper();

        bool saveContractFlag = false;
        enum AddButtonState {Add, Save }
        enum RemoveButtonState {Remove, Cancel}

        AddButtonState btnAddState = AddButtonState.Add;
        RemoveButtonState btnRemoveState = RemoveButtonState.Remove;

        public frmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //This is done
            dataKeeper.FileReader(collectionOfContracts);
        }


        #region Form Button Events
        private void BtnAddContract_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnRemoveContract_Click(object sender, EventArgs e)
        {
            if (btnRemoveState == RemoveButtonState.Remove)
            {
                collectionOfContracts.RemoveContract((int)txtIDCollection.SelectedItem);
            }
            else
            {
                btnAddState = AddButtonState.Add;
                btnRemoveState = RemoveButtonState.Remove;

                btnAddContract.Text = "Add";
                btnRemoveContract.Text = "Remove";
            }
        }

        private void BtnDisplayTotal_Click(object sender, EventArgs e)
        {

        }

        private void BtnDisplayContract_Click(object sender, EventArgs e)
        {
            frmContractdisplay contractDisplayWindow = new frmContractdisplay();
            
            if(contractDisplayWindow.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void BtnExitApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion Form Button Events

        #region General Form Events

        public void NumberKeyOnly_KeyEvent(object sender, KeyPressEventArgs e)
        {
            int AsciiKeyPressed = (int)e.KeyChar;
            bool AllowedNumKeyPressed = AsciiKeyPressed >= 48 && AsciiKeyPressed <= 57;
            bool AllowedUniqueKeyPressed = e.KeyChar == '.' && e.KeyChar == '\b';

            e.Handled = AllowedNumKeyPressed && AllowedUniqueKeyPressed ? false : true;
        }

        #endregion General Form Events

        #region General Form Methods

        public void SwitchFormState(ref bool formState)
        {
            if(formState == false)
            {
                btnAddContract.Text = "Save";
                btnRemoveContract.Text = "Cancel";

                btnDisplayContract.Enabled = false;
                btnDisplayTotal.Enabled = false;
                formState = true;
            }
            else
            {
                btnAddContract.Text = "Add";
                btnRemoveContract.Text = "Remove";

                btnDisplayContract.Enabled = true;
                btnDisplayTotal.Enabled = true;
                formState = false;
            }
        }

        #endregion General Form Methods

    }
}

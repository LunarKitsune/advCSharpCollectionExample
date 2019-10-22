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

        enum AddButtonState {Add, Save }
        enum RemoveButtonState {Remove, Cancel}

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
            if(AddButtonState == AddButtonState.Add)
            {

            }
        }

        private void BtnRemoveContract_Click(object sender, EventArgs e)
        {

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

    }
}

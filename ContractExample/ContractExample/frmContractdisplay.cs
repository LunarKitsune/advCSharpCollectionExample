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
    public partial class frmContractdisplay : Form
    {
        public frmContractdisplay()
        {
            InitializeComponent();
        }

        private void FrmContractdisplay_Load(object sender, EventArgs e)
        {
            //This helps the form have a dialog result when we instantiate this from a show dialog
            //Method
            btnOkConfirmation.DialogResult = DialogResult.OK;
        }

        private void BtnOkConfirmation_Click(object sender, EventArgs e)
        {
            //when this closes out from show dialog, the program can move on to the next
            //line of code to see if what was here has confirmed "OK" from the dialog result
            //fill in for our button
            this.Close();
        }
    }
}

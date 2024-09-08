using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEC___JASMINE_RECON.Secretary_Classes
{
    public partial class SECRETARY_LOGIN : Form
    {
        public SECRETARY_LOGIN()
        {
            InitializeComponent();
        }

        private void SecLogin_Form_Closed(object sender, FormClosedEventArgs e)
        {
            //Exit the Application
            Application.Exit();
        }

        private void LoginBttn_Click(object sender, EventArgs e)
        {
            //Open Secretary Workspace
            Secretary_Workspace secretary_Workspace = new Secretary_Workspace();
            secretary_Workspace.Show();

            this.Hide();
        }
    }
}

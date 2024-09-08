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
    public partial class Secretary_Workspace : Form
    {
        public Secretary_Workspace()
        {
            InitializeComponent();
        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            //Close the Application
            Application.Exit();
        }
    }
}

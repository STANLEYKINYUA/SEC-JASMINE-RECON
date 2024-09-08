using SEC___JASMINE_RECON.Secretary_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEC___JASMINE_RECON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Set the Default theme to Classic
           // Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;
        }

        private void Secretary_Button_CLICK(object sender, EventArgs e)
        {
            //Load Secretary Login Form

            SECRETARY_LOGIN SecLogin = new SECRETARY_LOGIN();
            SecLogin.Show();
            this.Hide();


        }
    }
}

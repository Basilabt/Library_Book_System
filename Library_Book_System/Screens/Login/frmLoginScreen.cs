using BusinessAccessLayer;
using Library_Book_System.Screens.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Book_System.Screens.Login
{
    public partial class frmLoginScreen : Form
    {
        public frmLoginScreen()
        {
            InitializeComponent();
        }

        private void ctrLoginCredentials1_onLoginAttemptComplete(object sender, Controls.ctrLoginCredentials.LoginAttemptEventArgs e)
        {

            string username = e.username;
            bool isLoginSuccessfull = e.isLoginSuccesfull;
            string message = e.message;


            if(!isLoginSuccessfull)
            {
                MessageBox.Show(message,"Login Failed",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            clsGlobal.loggedManager = clsLibraryManager.findLibraryManagerByUsername(username);

            frmMainScreen form = new frmMainScreen();
            form.ShowDialog();
            this.Hide();


        }





    }
}

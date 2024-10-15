using BusinessAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Book_System.Controls
{
    public partial class ctrLoginCredentials : UserControl
    {
        public ctrLoginCredentials()
        {
            InitializeComponent();
        }


        public class LoginAttemptEventArgs : EventArgs
        {
            public string username {  get; set; }
            public bool isLoginSuccesfull { get; }
            public string message { get; }

            public LoginAttemptEventArgs(string username,bool isLoginSuccesfull, string message)
            {
                this.username = username;
                this.isLoginSuccesfull = isLoginSuccesfull;
                this.message = message;
            }

        }

        public event EventHandler<LoginAttemptEventArgs> onLoginAttemptComplete;

        private void raiseOnLoginAttemptEvent(string username,bool isLoginSuccesfull , string message)
        {
            this.raiseOnLoginAttemptEvent(new LoginAttemptEventArgs(username,isLoginSuccesfull , message));
        }

        protected virtual void raiseOnLoginAttemptEvent(LoginAttemptEventArgs e)
        {
            this.onLoginAttemptComplete?.Invoke(this, e);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtboxUsername.Text;
            string password = txtboxPassword.Text;



            if (!clsLibraryManager.login(username, password))
            {
                this.raiseOnLoginAttemptEvent(username,false, "Incorrect username or password");
                return;
            }


            if (!clsLibraryManager.isManagerAccountActive(username))
            {
                this.raiseOnLoginAttemptEvent(username,false,"Account is not active");
                return;
            }





            this.raiseOnLoginAttemptEvent(username,true,"Login Successfull");

        }
    }
}

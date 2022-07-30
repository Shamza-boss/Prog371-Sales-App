using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRJ271_Milestone2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text.ToString();
            string Username = txtUsername.Text.ToString();
            try
            {
                if (password == "ShamzaBoss" && Username == "Admin")
                {
                    this.Hide();
                    OrderF orderForm = new OrderF();
                    orderForm.Show();
                }
                else
                {
                    MessageBox.Show("The values you have entered are incorrect");
                };
            }catch(Exception error)
            {
                MessageBox.Show("Request could not be processed: "+error.Message+" Please try again!");
            }
            

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register registerform = new Register();
            registerform.Show();
        }
    }
}

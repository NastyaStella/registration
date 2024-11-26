using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avtorisation
{
    public partial class AdminRegistration : Form
    {
       // private Dictionary<string, string> user;
        public AdminRegistration()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (password.Text != "" )
             {
             MessageBox.Show("Регистрация администратора прошла успешно", "Проверка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            string login = this.login.Text;
            string password = this.password.Text;
                this.Close();
                AdminForm form = new AdminForm();
                form.ShowDialog();
            }
             else
              MessageBox.Show("Неправильно введен пароль", "Проверка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form01 = new Form1();
            form01.ShowDialog();
        }
    }
}

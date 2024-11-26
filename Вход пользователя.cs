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
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
        }
        private Dictionary<string, string> user = new Dictionary<string, string>
        {
            {"qwerty", "12345"},
            {"poiuyt", "09876"}
        };

        private void button1_Click(object sender, EventArgs e)
        {
            if ((password.Text == repassword.Text) && (password.Text != ""))
            {
                MessageBox.Show("Регистрация пользователя прошла успешно", "Проверка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                string login = this.login.Text;
                string password = this.password.Text;
                if (!user.ContainsKey(login))
                {
                    user.Add(login, password);
                    MessageBox.Show($"Запись добавлена: {login} - {password}");
                }

                else
                {
                    MessageBox.Show($"Ключ '{login}' уже существует!");
                }
                this.login.Clear();
                this.password.Clear();
                repassword.Clear();
                UserForm form5 = new UserForm();
                form5.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Неправильно введен пароль", "Проверка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            AdminForm form4 = new AdminForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form0 = new Form1();
            form0.ShowDialog();
        }
    }
}

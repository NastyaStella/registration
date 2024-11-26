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
    public partial class Form1 : Form
    {
       // private Dictionary<string, string> user;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserRegistration form = new UserRegistration();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminRegistration form1 = new AdminRegistration();
            form1.Show();
        }
    }
}

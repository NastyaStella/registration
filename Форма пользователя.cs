using avtorisation.модель_бд;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avtorisation
{
    public partial class UserForm : Form
    {
            public UserForm()
            {
                InitializeComponent();
            }
        int k = 1;
        private void Output()
        {
            using (Model_db db = new Model_db())
            {
                foreach (var product in db.Product)
                {
                    price1.Text = db.Product.Find(k).MinCostForAgent.ToString() + "р";
                    nameproduct1.Text = $"{db.Product.Find(k).ProductType.Title} | {db.Product.Find(k).Title}";
                    articul1.Text = db.Product.Find(k).ArticleNumber.ToString();
                    material1.Text = "Материалы: " + String.Join(",", db.Product.Find(k).ProductMaterial.Select(pm => { return pm.Material.Title; }).ToList());
                }
            }
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            Output();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            k++;
            Output();
       }
        
    }


}

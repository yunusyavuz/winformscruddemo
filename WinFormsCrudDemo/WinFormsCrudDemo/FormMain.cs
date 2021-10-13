using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCrudDemo
{
    public partial class FormMain : Form
    {
        private List<Product> products = Product.GetDemoData();

        public FormMain()
        {
            InitializeComponent();
            bindingSourceProducts.DataSource = products;
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            bindingSourceProducts.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSourceProducts.EndEdit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindingSourceProducts.CancelEdit();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                $"{((Product)bindingSourceProducts.Current).ToString()} isimli ürün TAMAMEN silinecektir. Deevam etmek istiyormusunuz?"
                , "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Yes:
                    bindingSourceProducts.RemoveCurrent();
                    break;
            }
        }
    }
}

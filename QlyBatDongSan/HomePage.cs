using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlyBatDongSan
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            Form propertyForm = new Property();
            propertyForm.ShowDialog();
        }

        private void btnPropertyType_Click(object sender, EventArgs e)
        {
            Form propertyTypeForm = new PropertyType();
            propertyTypeForm.ShowDialog();
        }

        private void btnPropertyImage_Click(object sender, EventArgs e)
        {
            Form propertyImageForm = new PropertyImages();
            propertyImageForm.ShowDialog();
        }

        private void btnOwner_Click(object sender, EventArgs e)
        {
            Form ownerForm = new Owners();
            ownerForm.ShowDialog();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Form clientForm = new Clients();
            clientForm.ShowDialog();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            Form saleForm = new Sale();
            saleForm.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotcakes.CommerceDTO;
using Hotcakes.CommerceDTO.v1.Client;
using Hotcakes.CommerceDTO.v1.Membership;
using Hotcakes.CommerceDTO.v1;

namespace api2
{
    public partial class Form3 : Form
    {
        private ugyfel _u;
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public void LoadContact(ugyfel u)
        {
            _u = u;
            if (u != null)
            {
                ClearForm();

                textBoxLast.Text = u.vezeteknev;
                textBoxFirst.Text = u.keresztnev;
                textBoxCity.Text = u.telepules;
                textBoxEmail.Text = u.email;
                textBoxAddress.Text = u.cim;
            }
        }
        private void ClearForm() 
        {
            textBoxLast.Text = string.Empty;
            textBoxFirst.Text = string.Empty;
            textBoxCity.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxAddress.Text = string.Empty;
        }

    }
}

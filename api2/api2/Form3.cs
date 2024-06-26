﻿using System;
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
        public ugyfel _u;
        public Form3()
        {
            InitializeComponent();
        }

        public void buttonOK_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        public void buttonCancel_Click(object sender, EventArgs e)
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
        public void ClearForm() 
        {
            textBoxLast.Text = string.Empty;
            textBoxFirst.Text = string.Empty;
            textBoxCity.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxAddress.Text = string.Empty;
        }

        public void textBoxLast_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLast.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxLast, "A mező nem lehet üres!");
            }
        }

        public void textBoxLast_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxLast, string.Empty);
        }

        public void textBoxFirst_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFirst.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxFirst, "A mező nem lehet üres!");
            }
        }

        public void textBoxFirst_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxFirst, string.Empty);
        }

        public void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!textBoxEmail.Text.Contains("@") || !textBoxEmail.Text.Contains("."))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxEmail, "Adjon meg egy érvényes email címet!");
            }
        }

        public void textBoxEmail_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxEmail, string.Empty);
        }
    }
}

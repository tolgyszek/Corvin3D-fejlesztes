using Hotcakes.CommerceDTO.v1;
using Hotcakes.CommerceDTO.v1.Client;
using Hotcakes.CommerceDTO.v1.Contacts;
using Hotcakes.CommerceDTO.v1.Membership;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace api2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            api();

        }
        void api()
        {
            string url = "http://20.234.113.211:8109";
            string key = "1-a284d681-f356-4b49-a347-eb274e0217e8";

            Api proxy = new Api(url, key);

            // call the API to find all customer accounts in the store
            ApiResponse<List<CustomerAccountDTO>> response = proxy.CustomerAccountsFindAll();
            //MessageBox.Show(response.Content[0].FirstName.ToString());
            //dataGridView1.DataSource = response.Content;
            addressDTOBindingSource.DataSource = response.Content;
            ////for (int i = 0; i < response.Content.Count; i++)
            //{
            //    MessageBox.Show(response.Content[i].ShippingAddress.City);
            //}

            //adatok betöltése linq-val
            var adat = from x in response.Content
                       select new ugyfel
                       {
                           azonosito = int.Parse(x.Bvin),
                           email = x.Email.ToString(),
                           vezeteknev = x.LastName.ToString(),
                           keresztnev = x.FirstName.ToString(),
                           telepules = x.BillingAddress.City.ToString(),
                           cim = x.BillingAddress.Line1.ToString(),

                       };
            ugyfelBindingSource.DataSource = adat.ToList();

        }

        private void buttonorders_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void buttonaddcontact_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            if (form3.ShowDialog() == DialogResult.OK)
            {
                string url = "http://20.234.113.211:8109";
                string key = "1-a284d681-f356-4b49-a347-eb274e0217e8";

                Api proxy = new Api(url, key);

                // create a new instance of customer account
                var customerAccount = new CustomerAccountDTO();

                // populate the customer account with minimum details
                customerAccount.FirstName = form3.textBoxFirst.Text;
                customerAccount.LastName = form3.textBoxLast.Text;
                customerAccount.Email = form3.textBoxEmail.Text;
                customerAccount.BillingAddress.City = form3.textBoxCity.Text;
                customerAccount.BillingAddress.Line1 = form3.textBoxAddress.Text;

                // call the API to create the account
                try
                {
                    ApiResponse<CustomerAccountDTO> response = proxy.CustomerAccountsCreate(customerAccount);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                api();
            }

        }
    }
}

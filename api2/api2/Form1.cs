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
            apiadatlekeres();

        }
        void apiadatlekeres()
        {
            Api proxy = apihivas();

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

        private static Api apihivas()
        {
            string url = "http://20.234.113.211:8109";
            string key = "1-a284d681-f356-4b49-a347-eb274e0217e8";

            Api proxy = new Api(url, key);
            return proxy;
        }

        private void buttonorders_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void buttonaddcontact_Click(object sender, EventArgs e)
        {
            Form3 addform = new Form3();
            if (addform.ShowDialog() == DialogResult.OK)
            {
                string url = "http://20.234.113.211:8109";
                string key = "1-a284d681-f356-4b49-a347-eb274e0217e8";

                Api proxy = new Api(url, key);

                // create a new instance of customer account
                var customerAccount = new CustomerAccountDTO();

                // populate the customer account with minimum details
                customerAccount.FirstName = addform.textBoxFirst.Text;
                customerAccount.LastName = addform.textBoxLast.Text;
                customerAccount.Email = addform.textBoxEmail.Text;
                customerAccount.BillingAddress.City = addform.textBoxCity.Text;
                customerAccount.BillingAddress.Line1 = addform.textBoxAddress.Text;

                // call the API to create the account
                try
                {
                    ApiResponse<CustomerAccountDTO> response = proxy.CustomerAccountsCreate(customerAccount);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                apiadatlekeres();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Value.ToString() == "Szerkesztés")
            {
                Form3 editform = new Form3();
                editform.LoadContact(new ugyfel
                {

                    azonosito = int.Parse((dataGridView1.Rows[e.RowIndex].Cells[0]).Value.ToString()),
                    vezeteknev = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    keresztnev = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    email = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    telepules = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    cim = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString(),

                });
                if (editform.ShowDialog() == DialogResult.OK)
                {

                    
                    string customerID = dataGridView1.Rows[e.RowIndex].Cells[0].ToString();

                    ApiResponse<CustomerAccountDTO> customerResponse = apihivas().CustomerAccountsFind(customerID);
                   
                    customerResponse.Content.LastName = editform.textBoxLast.Text;
                    customerResponse.Content.FirstName = editform.textBoxFirst.Text;
                    customerResponse.Content.Email = editform.textBoxEmail.Text;
                    customerResponse.Content.BillingAddress.Line1 = editform.textBoxAddress.Text;
                    customerResponse.Content.BillingAddress.City = editform.textBoxCity.Text;

                    ApiResponse<CustomerAccountDTO> response = apihivas().CustomerAccountsUpdate(customerResponse.Content);

                    apiadatlekeres();
                }
            }
        }
    }
}

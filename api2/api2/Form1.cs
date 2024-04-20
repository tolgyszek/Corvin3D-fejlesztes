using Hotcakes.CommerceDTO.v1;
using Hotcakes.CommerceDTO.v1.Client;
using Hotcakes.CommerceDTO.v1.Contacts;
using Hotcakes.CommerceDTO.v1.Membership;
using Hotcakes.CommerceDTO.v1.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
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
        void apiadatlekeres(string searchText = null)
        {
            Api proxy = apihivas();

            // call the API to find all customer accounts in the store
            ApiResponse<List<CustomerAccountDTO>> response = proxy.CustomerAccountsFindAll();
            
            addressDTOBindingSource.DataSource = response.Content;
            

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
                var customerAccount = new CustomerAccountDTO();
                var password = string.Concat(addform.textBoxFirst.Text, addform.textBoxLast.Text);

                // populate the customer account with minimum details
                customerAccount.FirstName = addform.textBoxFirst.Text;
                customerAccount.LastName = addform.textBoxLast.Text;
                customerAccount.Email = addform.textBoxEmail.Text;
                customerAccount.BillingAddress.City = addform.textBoxCity.Text;
                customerAccount.BillingAddress.Line1 = addform.textBoxAddress.Text;
                customerAccount.Password = password;

                DialogResult dialogResult = MessageBox.Show("Biztos rögzíti ezt a felhasználót?", "Megerősítés", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // call the API to create the account
                    try
                    {
                        ApiResponse<CustomerAccountDTO> response = apihivas().CustomerAccountsCreateWithPassword(customerAccount, password);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    apiadatlekeres();
                }
                else
                {
                    return; 
                }         
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Value.ToString() == "Szerkesztés")
            {
                EditContact(e);
                apiadatlekeres();
            }
            else if (cell.Value.ToString() == "Törlés")
            {
                DialogResult dialogResult = MessageBox.Show("Biztos törli ezt a felhasználót?", "Megerősítés", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    DeleteContact(e);
                    apiadatlekeres();
                }
                else
                {
                    return; 
                }
            }
        }

        private void EditContact(DataGridViewCellEventArgs e)
        {
            Form3 editform = new Form3();
            editform.LoadContact(new ugyfel
            {
                //a form kitölti a mezőket a meglévő adatokkal
                azonosito = int.Parse((dataGridView1.Rows[e.RowIndex].Cells[0]).Value.ToString()),
                vezeteknev = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                keresztnev = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(),
                email = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(),
                telepules = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(),
                cim = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString(),

            });
            if (editform.ShowDialog() == DialogResult.OK)
            {

                //szerkesztett ügyfél azonosítójának mentése
                string customerID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                //ügyfélszerkesztő API endpoint hívása
                ApiResponse<CustomerAccountDTO> customerResponse = apihivas().CustomerAccountsFind(customerID);

                //Ügyfél adatainak szerkesztése a szerkesztő form-on megadott adatokkal
                customerResponse.Content.LastName = editform.textBoxLast.Text;
                customerResponse.Content.FirstName = editform.textBoxFirst.Text;
                customerResponse.Content.Email = editform.textBoxEmail.Text;
                customerResponse.Content.BillingAddress.Line1 = editform.textBoxAddress.Text;
                customerResponse.Content.BillingAddress.City = editform.textBoxCity.Text;

                DialogResult dialogResult = MessageBox.Show("Biztos módosítja ezeket az adatokat?", "Megerősítés", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //mentés
                    try
                    {
                        ApiResponse<CustomerAccountDTO> response = apihivas().CustomerAccountsUpdate(customerResponse.Content);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    return;  
                }               
                apiadatlekeres();
            }
        }

        private void DeleteContact(DataGridViewCellEventArgs e)
        {
            string customerID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            ApiResponse<List<OrderSnapshotDTO>> orders = apihivas().OrdersFindAll();

            for (int i = 0; i < orders.Content.Count; i++)
            {
                if (orders.Content[i].UserID != customerID)
                {
                    ApiResponse<bool> response = apihivas().CustomerAccountsDelete(customerID);
                }
                else
                {
                    MessageBox.Show("A felhasználó nem törölhető, mert van rendelése");
                    return;
                }
            }
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Api proxy = apihivas();

            ApiResponse<List<CustomerAccountDTO>> response = proxy.CustomerAccountsFindAll();

            addressDTOBindingSource.DataSource = response.Content;
            var adat = from x in response.Content
                       where x.LastName.Contains(textBoxSearch.Text)
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
    }
}

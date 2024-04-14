using Hotcakes.CommerceDTO.v1;
using Hotcakes.CommerceDTO.v1.Client;
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
        private void api()
        {
            string url = "http://20.234.113.211:8109";
            string key = "1-a284d681-f356-4b49-a347-eb274e0217e8";

            Api proxy = new Api(url, key);

            // call the API to find all customer accounts in the store
            ApiResponse<List<CustomerAccountDTO>> response = proxy.CustomerAccountsFindAll();
            //MessageBox.Show(response.Content[0].FirstName.ToString());
            //listBox1.DataSource = response.Content;
            dataGridView1.DataSource = response.Content;
            

        }
    }
}

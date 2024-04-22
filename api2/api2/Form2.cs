using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotcakes.CommerceDTO.v1;
using Hotcakes.CommerceDTO.v1.Client;
using Hotcakes.CommerceDTO.v1.Orders;

namespace api2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            orderapi();           
        }

        public void orderapi()
        {
            string url = "http://20.234.113.211:8109";
            string key = "1-a284d681-f356-4b49-a347-eb274e0217e8";

            Api proxy = new Api(url, key);

            // call the API to find all orders in the store
            ApiResponse<List<OrderSnapshotDTO>> response2 = proxy.OrdersFindAll();
            //dataGridView2.DataSource = response2.Content;
            orderDTOBindingSource.DataSource = response2.Content;
        }
    }
}

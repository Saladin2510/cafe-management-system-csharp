using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CafeShopManagementSystem
{
    public partial class CashierCustomersForm : UserControl
    {
        public CashierCustomersForm()
        {
            InitializeComponent();

            if (!DesignMode)
            {
                refreshData();
            }
        }


        public void refreshData()
        {
            displayCustomersData();
        }

        public void displayCustomersData()
        {
            CustomersData cd = new CustomersData();
            List<CustomersData> list = cd.allCustomersData();

            datagridview1.AutoGenerateColumns = true;
            datagridview1.DataSource = null;
            datagridview1.DataSource = list;

            datagridview1.Refresh();
        }
    }
}

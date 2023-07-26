using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreshInkManager
{
    public partial class FreshInkManager : Form
    {
        public FreshInkManager()
        {
            InitializeComponent();
        }

        private void FreshInkManager_Load(object sender, EventArgs e)
        {
            ListView_Printers.Items.Add("Printer1");
            ListView_Printers.Items.Add("Printer2");
            ListView_Printers.Items.Add("Printer3");
        }
    }
}

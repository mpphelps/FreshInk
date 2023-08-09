using FreshInkUtilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace FreshInkManager
{
    public partial class FreshInkManager : Form
    {
        private TaskSchedulerManager _scheduler;
        private IPrintTestConfigParser _parser;
        private PrintTestConfig _config;

        public FreshInkManager()
        {
            InitializeComponent();
            _scheduler = new TaskSchedulerManager();
            _parser = new JsonPrintTestConfigParser();
            _config = _parser.GetConfigs();
        }

        private void FreshInkManager_Load(object sender, EventArgs e)
        {
            DatePicker_TargetDate.Value = _scheduler.GetNextRunTime();
            NumericUpDown_Interval.Value = _scheduler.GetInterval();
            TextBox_TestDocument.Text = _config.TestDocument;

            var set = new HashSet<string>();
            foreach (var printer in _config.PrinterNames)
            {
                var item = new ListViewItem();
                item.Text = printer;
                item.Checked = true;
                ListView_Printers.Items.Add(item);
                set.Add(printer);
            }

            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                if (!set.Contains(printer))
                {
                    var item = new ListViewItem();
                    item.Text = printer;
                    item.Checked = false;
                    ListView_Printers.Items.Add(item);
                    set.Add(printer);
                }
            }
        }

        private void Button_SelectTestDocument_Click(object sender, EventArgs e)
        {
            string message = "Do you want to select a custom test?";
            string caption = "Test prompt";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons); ;
            if (result == DialogResult.Yes)
            {
                FileDialog.ShowDialog();
                string path = FileDialog.FileName;
                TextBox_TestDocument.Text = Path.GetFileName(path);
            }
            else
            {
                TextBox_TestDocument.Text = "Default";
            }                     
        }

        private void Button_SaveConfig_Click(object sender, EventArgs e)
        {
            try
            {
                _scheduler.UpdateTask(DatePicker_TargetDate.Value,
                (short)NumericUpDown_Interval.Value);

                _config.TestDocument = TextBox_TestDocument.Text;
                _config.PrinterNames.Clear();
                foreach (ListViewItem item in ListView_Printers.CheckedItems)
                {
                    _config.PrinterNames.Add(item.Text);
                }
                _parser.SaveConfigs(_config);

                MessageBox.Show("Config successfully saved");
            }
            catch (UnauthorizedAccessException)
            {
                string message = "Failed to save changes. \nRerun application as administrator.";
                string caption = "Unathorized Access Error";
                MessageBox.Show(message, caption);
            }
        }

        private void Button_RunTest_Click(object sender, EventArgs e)
        {
            Process.Start(_scheduler.GetExecutablePath());
        }
    }
}

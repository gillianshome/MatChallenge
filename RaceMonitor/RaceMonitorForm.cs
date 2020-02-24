using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RaceMonitor
{
    public partial class RaceMonitorForm : Form
    {
        /// <summary>
        /// constructor
        /// </summary>
        public RaceMonitorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// UI request to connect
        /// </summary>
        /// <param name="sender">the event source</param>
        /// <param name="e">the event data</param>
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            // only allow the client to connect once
            ConnectButton.Enabled = false;

            RaceMonitor.Instance.Connect();
        }

        /// <summary>
        /// UI request to show the current status in the status display 
        /// </summary>
        /// <param name="sender">the event source</param>
        /// <param name="e">the event data</param>
        private void UpdateDisplayButton_Click(object sender, EventArgs e)
        {
            RaceMonitor.Instance.ToString();
        }
    }
}

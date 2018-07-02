using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fight_Club
{
    public partial class LogForm : Form, ILogView
    {
        public LogForm()
        {
            InitializeComponent();
        }

        public void AddLog(string log)
        {
            LogBox.Items.Add(log);
        }
    }
}

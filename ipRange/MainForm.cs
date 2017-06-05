using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipRange
{
    public partial class MainForm : Form
    {
        List<IPstructure> ipList = new List<IPstructure>();
        IPoutput ipo = new IPoutput();
        public MainForm()
        {
            InitializeComponent();
            ipo.AddIp("192.168.0.1", ipList);
            ipo.AddIp("192.168.0.155", ipList);
            ipo.AddIp("255.255.0.1", ipList);
            ipo.AddIp("10.168.0.1", ipList);
            ipo.AddIp("10.10.10.0", ipList);

            UpdateListBox(ipList);
        }

        private void numPart1_ValueChanged(object sender, EventArgs e)
        {
            List<IPstructure> result = new List<IPstructure>();

            result = ipo.FindIp(numPart1.Value.ToString() + "." + numPart2.Value.ToString() + "." + numPart3.Value.ToString() + "." + numPart4.Value.ToString(), ipList);

            UpdateListBox(result);
        }

        private void numPart2_ValueChanged(object sender, EventArgs e)
        {
            List<IPstructure> result = new List<IPstructure>();
                        
            result = ipo.FindIp(numPart1.Value.ToString() + "." + numPart2.Value.ToString() + "." + numPart3.Value.ToString() + "." + numPart4.Value.ToString(), ipList);

            UpdateListBox(result);
        }

        private void numPart3_ValueChanged(object sender, EventArgs e)
        {
            List<IPstructure> result = new List<IPstructure>();

            result = ipo.FindIp(numPart1.Value.ToString() + "." + numPart2.Value.ToString() + "." + numPart3.Value.ToString() + "." + numPart4.Value.ToString(), ipList);

            UpdateListBox(result);
        }

        private void numPart4_ValueChanged(object sender, EventArgs e)
        {
            List<IPstructure> result = new List<IPstructure>();

            result = ipo.FindIp(numPart1.Value.ToString() + "." + numPart2.Value.ToString() + "." + numPart3.Value.ToString() + "." + numPart4.Value.ToString(), ipList);
            UpdateListBox(result);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ip = numPart1.Value + "." + numPart2.Value + "." + numPart3.Value + "." + numPart4.Value;
            if(ip != "0.0.0.0") ipo.AddIp(ip, ipList);

            UpdateListBox(ipList);
        }

        private void UpdateListBox(List<IPstructure> result)
        {
            lbIp.Items.Clear();
            for (int i = 0; i < result.Count; i++)
            {
                lbIp.Items.Add(result[i].FirstPart.ToString() + "." + result[i].SecondPart + "." + result[i].ThirdPart + "." + result[i].FourthPart + "\n");
            }
            lbIp.EndUpdate();
        }
    }
}

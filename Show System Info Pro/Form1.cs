using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Show_System_Info_Pro
{
    public partial class Form1 : Form
    {
        private string connectionString = $"Data Source={Environment.MachineName};Initial Catalog=WelkinATP;Integrated Security=SSPI;";
        private int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void panelCL1_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter >= 5)
            {
                MessageBox.Show("For any suggestion or complain feel free to contact\n\nbablushaikh0000@gmail.com\nBablu Shaikh", "Suggestion and Complaint", MessageBoxButtons.OK, MessageBoxIcon.Information);
                counter = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDB.SelectedIndex = 0;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                txtIP.Text = GetLocalIPv4Address();
                txtMac.Text = GetMacAddress();
                txtProcess.Text = GetProcessorId();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //condition 1
            if(cmbDB.Text == "BWelkinATP")
            {
                connectionString = $"Data Source={Environment.MachineName};Initial Catalog=BWelkinATP;Integrated Security=SSPI;";
            }
            else if(cmbDB.Text == "WelkinATP")
            {
                connectionString = $"Data Source={Environment.MachineName};Initial Catalog=WelkinATP;Integrated Security=SSPI;";
            }
            else
            {
                MessageBox.Show("Select a database you want to update", "No Database Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //condition 2
            if(!cbIP.Checked && !cbMac.Checked && !cbPrinter.Checked && !cbProcess.Checked)
            {
                MessageBox.Show("Select checkbox you want to update", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (cbIP.Checked && txtIP.Text == "")
                {
                    MessageBox.Show("Enter IP Address or Deselect IP Address", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                if (cbMac.Checked && txtMac.Text == "")
                {
                    MessageBox.Show("Enter Mac ID or Deselect Mac ID", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                if (cbProcess.Checked && txtProcess.Text == "")
                {

                    MessageBox.Show("Enter Processor ID or Deselect Processor ID", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                if (cbPrinter.Checked && txtPrinter.Text == "")
                {

                    MessageBox.Show("Enter Printer Port or Deselect Printer Port", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            //updating database
            try
            {
               using(SqlConnection conn = new SqlConnection(connectionString))
               {
                    List<string> exicuteStatus = new List<string>();
                    string exicuteMsg = "";
                    conn.Open();
                    if(cbIP.Checked)
                    {
                        string query = $"update fSettings set WBSEDCLOracle='{txtIP.Text}'";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            int n = cmd.ExecuteNonQuery();
                            if (n > 0)
                                exicuteStatus.Add("IP Address");
                        }
                    }
                    if (cbMac.Checked)
                    {
                        string query = $"update fSettings set SPMLOracle='{txtMac.Text}'";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            int n = cmd.ExecuteNonQuery();
                            if (n > 0)
                                exicuteStatus.Add("Mac ID");
                        }
                    }
                    if (cbProcess.Checked)
                    {
                        string query = $"update fSettings set ExportServerPath='{txtProcess.Text}'";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            int n = cmd.ExecuteNonQuery();
                            if (n > 0)
                                exicuteStatus.Add("Processor ID");
                        }
                    }
                    if (cbPrinter.Checked)
                    {
                        string query = $"update fSettings set ReceiptPrinterPort='{txtPrinter.Text}'";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            int n = cmd.ExecuteNonQuery();
                            if (n > 0)
                                exicuteStatus.Add("Printer Port");
                        }
                    }
                    conn.Close();

                    if(exicuteStatus.Count > 0)
                    {
                        foreach(string item in exicuteStatus)
                        {
                            exicuteMsg += $"{item} - Changed Successfully\n";
                        }
                        MessageBox.Show(exicuteMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Update Database Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
               }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //clipboard
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "select wbsedcloracle, spmloracle, kioskid from fSettings";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string remoteQuery = $"update KioskMapping set IPAddress='{reader.GetString(0)}', MacID='{reader.GetString(1)}', Isactive=1 where KioskID='{reader.GetString(2)}';";
                                Clipboard.SetText(remoteQuery);
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch
            {

            }
        }


        //methods
        static string GetLocalIPv4Address()
        {
            foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet || networkInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                {
                    foreach (UnicastIPAddressInformation ipInfo in networkInterface.GetIPProperties().UnicastAddresses)
                    {
                        if (ipInfo.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            return ipInfo.Address.ToString();
                        }
                    }
                }
            }
            return "IPv4 Address not found.";
        }


        static string GetMacAddress()
        {
            foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet || networkInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                {
                    return networkInterface.GetPhysicalAddress().ToString();
                }
            }
            return "MAC Address not found.";
        }

        static string GetProcessorId()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT ProcessorId FROM Win32_Processor");
                foreach (ManagementObject obj in searcher.Get())
                {
                    return obj["ProcessorId"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Processor ID Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return "Processor ID not found.";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Forms;

namespace SystemInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // PC Name
            string pc = Environment.MachineName;
            textBoxPC.Text = "pc";
                        
                                  
            // User Name              
            string user = Environment.UserName;
            textBoxUser.Text = user;


            // IP Address
            string hostName = Dns.GetHostName(); 
            string ip = Dns.GetHostByName(hostName).AddressList[0].ToString();
            textBoxIP.Text = ip;


            // OS
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion");
            string pathName = (string)registryKey.GetValue("productName");
            textBoxOS.Text = pathName;
                       
        }

        //        
        //Button "OK". Closes application.
        //
        private void buttonOk_Click(object sender, EventArgs e)
            {
                this.Close();
            }
                   
                
     }
}

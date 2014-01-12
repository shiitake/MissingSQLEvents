using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace MissingSQLEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addregKey_Click(object sender, EventArgs e)
        {
            switch (sqlVersion.Text)
            {
                case "2005":
                    Microsoft.Win32.RegistryKey key;
                    key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SYSTEM\\ControlSet001\\Services\\EventLog\\Application\\MSSQL$" + sqlInstance.Text);
                    key.SetValue("CategoryCount", "00000008", RegistryValueKind.DWord);
                    key.Close();
                    key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SYSTEM\\ControlSet001\\Services\\EventLog\\Application\\MSSQL$" + sqlInstance.Text);
                    key.SetValue("CategoryMessageFile", "C:\\Program Files\\Microsoft SQL Server\\MSSQL10_50.SQL2008R2\\MSSQL\\Binn\\Resources\\1033\\sqlevn70.rll");
                    key.Close();
                    key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SYSTEM\\ControlSet001\\Services\\EventLog\\Application\\MSSQL$" + sqlInstance.Text);
                    key.SetValue("EventMessageFile", "C:\\Program Files\\Microsoft SQL Server\\MSSQL10_50.SQL2008R2\\MSSQL\\Binn\\Resources\\1033\\sqlevn70.rll");
                    key.Close();
                    key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SYSTEM\\ControlSet001\\Services\\EventLog\\Application\\MSSQL$" + sqlInstance.Text);
                    key.SetValue("TypesSupported", 255, RegistryValueKind.DWord);
                    key.Close();
                    break;
                case "2008": break;
                case "2008R2": break;
                case "2012": break;
                default: break;
            }


        }

        private void removeregKey_Click(object sender, EventArgs e)
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SYSTEM\\ControlSet001\\Services\\EventLog\\Application\\MSSQL$" + sqlInstance.Text);

            string[] valueNames = key.GetValueNames();
            if (valueNames == null)
            {
                //add pop-up that No registry entry found

            }
            else
            {
                //add confirmation that registry was not found
                Registry.LocalMachine.DeleteSubKey("SYSTEM\\ControlSet001\\Services\\EventLog\\Application\\MSSQL$" + sqlInstance.Text);
            }

        }

        private void verifySql()
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("\\SOFTWARE\\Microsoft\\Microsoft SQL Server\\Instance Names\\SQL\\");

            string[] valueNames = key.GetValueNames();
            if (valueNames == null)
            {
                textBox1.Text = "No SQL Instance Found";
            }
            else
            {
                textBox1.Text = valueNames[0];
            }

        }

        private void testforSQL_Click(object sender, EventArgs e)
        {
            
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
                using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
                {
                    RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                    if (instanceKey != null)
                    {
                        foreach (var instanceName in instanceKey.GetValueNames())
                        {
                            Console.WriteLine(Environment.MachineName + @"\" + instanceName);
                        }
                    }
                }
            
            
            
            
            
            //var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            Microsoft.Win32.RegistryKey key;
            //key = hklm.OpenSubKey("\\SOFTWARE\\Microsoft\\Microsoft SQL Server\\Instance Names\\SQL");
            string[] names = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("\\SOFTWARE\\Microsoft\\Microsoft SQL Server\\Instance Names\\SQL\\").GetSubKeyNames();
            //string[] names = key.GetSubKeyNames();                
            if (names[0] == null)
            {
                textBox1.Text = "No SQL 1";
            }

            else
            /*{
                string[] valueNames = key.GetValueNames();
                if (valueNames == null)
                {
                    textBox1.Text = "No SQL Instances Found";
                    key.Close();
                }
             else
             */
                {
                    textBox1.Text = Names[0];
                    key.Close();
                }
            }
        }
    }
}

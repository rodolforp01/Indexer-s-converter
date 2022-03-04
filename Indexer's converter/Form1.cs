using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Indexer_s_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ConverterOutp.Clear();
            string value1 = Encrypt2(NormalString.Text.ToString());
            string value2 = toHex(value1);
            string value3 = Organize(value2);
            ConverterOutp.Text = value3.ToString();
        }

        private static Random random = new Random();
        public static string Encrypt2(string a)
        {
            List<string> list = new List<string>();
            string text = "";
            foreach (char value in a)
            {
                list.Add(Convert.ToInt32(value).ToString());
            }
            foreach (string value2 in list)
            {
                int num = Convert.ToInt32(value2);
                for (int j = 0; j < 2; j++)
                {
                    int num2 = random.Next(0, num);
                    num -= num2;
                    if (num2.ToString().Length == 1)
                    {
                        text += (35u + Convert.ToUInt32("0" + num2.ToString())).ToString("X");
                    }
                    else
                    {
                        text += (num2 + 35).ToString("X");
                    }
                    if (j == 1)
                    {
                        if (num.ToString().Length == 1)
                        {
                            text += (35u + Convert.ToUInt32("0" + num.ToString())).ToString("X");
                        }
                        else
                        {
                            text += (num + 35).ToString("X");
                        }
                    }
                }
            }
            return text;
        }

        //converts it to hex
        public string toHex(string inp)
        {
            string outp = string.Empty;
            char[] value = inp.ToCharArray();
            foreach(char L in value)
            {
                int V = Convert.ToInt32(L);
                outp += String.Format("{0:x}", V);
            }

            return outp;
        }

        static string Organize(string value)
        {
            string value2 = Regex.Replace(value, @"[0-9A-F]{2}", "0x$0, ");
            return value2;
        }


    }
}

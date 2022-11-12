using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class RSA : Form
    {
        public RSA()
        {
            InitializeComponent();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            //Calculator.ins.tbx.Text = "Hi from form 2";
             
            
            //char[] text = TxtBox.Text.ToCharArray();

            double p = 31, q = 13;
            double n = p * q;
            double phi = (p - 1) * (q - 1);

            double ee = 17;

            while (ee < phi)
            {
                if (gcd((int)ee, (int)phi) == 1)
                {
                    break;
                }
                else
                {
                    ee++;
                }
            }
            //Console.WriteLine("e is " + e);

            double d = 2, mult;
            while (d < phi)
            {
                if (d == ee)
                {
                    d++;
                }
                else
                {
                    mult = d * ee - 1;
                    if (mult % phi == 0)
                    {
                        break;
                    }
                    else
                    {
                        d++;
                    }
                }
            }

            string s = richTextBox4.Text;
            string en = encrypt(ee, s, n);
            richTextBox6.Text = en;
           // string dn = decrypt(d, en, n);
          //  richTextBox2.Text = dn;


        }

        static int[] temp = new int[100];

       public static string encrypt(double e, string s, double n)
        {
            double pt, ct, key = e, k, len;
            int i = 0, j;
            string msg = s.ToLower();
            len = msg.Length;
            // string m = msg;
            string en = "";
            while (i != len)
            {
                pt = msg[i];
                pt = pt - 96;
                k = 1;
                for (j = 0; j < key; j++)
                {
                    k = k * pt;
                    k = k % n;
                }

                temp[i] = (int)k;
                ct = k + 96;
                int ctt = (int)ct;
                //  Console.Write(k + " " + ct + " ");
                char c = Convert.ToChar(ctt);

                en += c;
                //en+=c;
                i++;
            }

            return en;
        }

       public static string decrypt(double d, string en, double n)
        {
            double pt, ct, key = d, k, len;
            int i = 0;
            len = en.Length;
            string dn = "";
            for (i = 0; i < len; i++)
            {
                ct = temp[i];
                k = 1;
                for (int j = 0; j < key; j++)
                {
                    k = k * ct;
                    k = k % n;
                }
                pt = k + 96;
                int ctt = (int)pt;
                //  Console.Write(k + " " + ct + " ");
                char c = Convert.ToChar(ctt);
                dn += c;
            }
            return dn;

        }

        public static int gcd(int a, int b)
        {
            int temp;
            while (true)
            {
                temp = a % b;
                if (temp == 0)
                {
                    break;
                }
                a = b;
                b = temp;
            }
            return b;
        }
         
        private void button6_Click(object sender, EventArgs e)
        {
            double p = 31, q = 13;
            double n = p * q;
            double phi = (p - 1) * (q - 1);

            double ee = 17;

            while (ee < phi)
            {
                if (gcd((int)ee, (int)phi) == 1)
                {
                    break;
                }
                else
                {
                    ee++;
                }
            }
            //Console.WriteLine("e is " + e);

            double d = 2, mult;
            while (d < phi)
            {
                if (d == ee)
                {
                    d++;
                }
                else
                {
                    mult = d * ee - 1;
                    if (mult % phi == 0)
                    {
                        break;
                    }
                    else
                    {
                        d++;
                    }
                }
            }

            //string s = richBox1.Text;
            string en = richTextBox5.Text;
            string dn = decrypt(d, en, n);
            richTextBox7.Text = dn;
        }

        
    }
}

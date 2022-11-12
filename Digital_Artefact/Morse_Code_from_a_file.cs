using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Morse_Code_from_a_file : Form
    {
        public Morse_Code_from_a_file()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filepath = string.Empty;
            string fileExt = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog.FileName;
                fileExt = Path.GetExtension((filepath));
                if(fileExt.CompareTo(".txt") == 0)
                {
                    try
                    {
                        StreamReader reader = new StreamReader(filepath);
                        StringBuilder builder = new StringBuilder();
                        string line = "";

                        while((line = reader.ReadLine())!= null)
                        {
                            builder.AppendLine(line);
                        }
                        reader.Close();
                        richTextBox4.Text = builder.ToString(); 
                    }catch(Exception ex)
                    {

                    }
                }
            }
        }

        private void m_encode_Click(object sender, EventArgs e)
        {
            string s = richTextBox4.Text;
            string ans = morse_Code(s);
            richTextBox6.Text = ans;
        }

        public static string m_Encode(char c)
        {
            switch (c)
            {
                case 'a':
                    return ".-";
                case 'A':
                    return ".-";
                case 'b':
                    return "-...";
                case 'B':
                    return "-...";
                case 'c':
                    return "-.-.";
                case 'C':
                    return "-.-.";
                case 'd':
                    return "-..";
                case 'D':
                    return "-..";
                case 'e':
                    return ".";
                case 'E':
                    return ".";
                case 'f':
                    return "..-.";
                case 'F':
                    return "..-.";
                case 'g':
                    return "--.";
                case 'G':
                    return "--.";
                case 'h':
                    return "....";
                case 'H':
                    return "....";
                case 'i':
                    return "..";
                case 'I':
                    return "..";
                case 'j':
                    return ".---";
                case 'J':
                    return ".---";
                case 'k':
                    return "-.-";
                case 'K':
                    return "-.-";
                case 'l':
                    return ".-..";
                case 'L':
                    return ".-..";
                case 'm':
                    return "--";
                case 'M':
                    return "--";
                case 'n':
                    return "-.";
                case 'N':
                    return "-.";
                case 'o':
                    return "---";
                case 'O':
                    return "---";
                case 'p':
                    return ".--.";
                case 'P':
                    return ".--.";
                case 'q':
                    return "--.-";
                case 'Q':
                    return "--.-";
                case 'r':
                    return ".-.";
                case 'R':
                    return ".-.";
                case 's':
                    return "...";
                case 'S':
                    return "...";
                case 't':
                    return "-";
                case 'T':
                    return "-";
                case 'u':
                    return "..-";
                case 'U':
                    return "..-";
                case 'v':
                    return "...-";
                case 'V':
                    return "...-";
                case 'w':
                    return ".--";
                case 'W':
                    return ".--";
                case 'x':
                    return "-..-";
                case 'X':
                    return "-..-";
                case 'y':
                    return "-.--";
                case 'Y':
                    return "-.--";
                case 'z':
                    return "--..";
                case 'Z':
                    return "--..";

                case '1':
                    return ".----";
                case '2':
                    return "..---";
                case '3':
                    return "...--";
                case '4':
                    return "....-";
                case '5':
                    return ".....";
                case '6':
                    return "-....";
                case '7':
                    return "--...";
                case '8':
                    return "---..";
                case '9':
                    return "----.";
                case '0':
                    return "-----";
                case ' ':
                    return " ";
            }
            return "";
        }

        public static string morse_Code(string s)
        {
            string ans = "";
            for (int i = 0; i < s.Length; i++)
            {

                ans += m_Encode(s[i]);
                ans += " ";
                //Console.Write(m_Encode(s[i]));
            }
            //Console.WriteLine();
            return ans;

        }

      

        public static string morse_decode(string c)
        {
            switch (c)
            {
                case ".-":
                    return "a";
                case "-...":
                    return "b";
                case "-.-.":
                    return "c";
                case "-..":
                    return "d";
                case ".":
                    return "e";
                case "..-.":
                    return "f";
                case "--.":
                    return "g";
                case "....":
                    return "h";
                case "..":
                    return "i";
                case ".---":
                    return "j";
                case "-.-":
                    return "k";
                case ".-..":
                    return "l";
                case "--":
                    return "m";
                case "-.":
                    return "n";
                case "---":
                    return "o";
                case ".--.":
                    return "p";
                case "--.-":
                    return "q";
                case ".-.":
                    return "r";
                case "...":
                    return "s";
                case "-":
                    return "t";
                case "..-":
                    return "u";
                case "...-":
                    return "v";
                case ".--":
                    return "w";
                case "-..-":
                    return "x";
                case "-.--":
                    return "y";
                // for space
                case "--..":
                    return "z";

                case ".----":
                    return "1";
                case "..---":
                    return "2";
                case "...--":
                    return "3";
                case "....-":
                    return "4";
                case ".....":
                    return "5";
                case "-....":
                    return "6";
                case "--...":
                    return "7";
                case "---..":
                    return "8";
                case "----.":
                    return "9";
                case "-----":
                    return "0";
                case "/":
                    return " ";
            }
            return " ";
        }

        public static string morse_Decode(string[] s, int j)
        {
            string ans = "";
            //Console.WriteLine("Output: ");

            for (int i = 0; i <= j; i++)
            {
                // Console.Write(m_decode(s[i]));
                ans += morse_decode(s[i]);
            }
            // Console.WriteLine();
            return ans;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filepath = string.Empty;
            string fileExt = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog.FileName;
                fileExt = Path.GetExtension((filepath));
                if (fileExt.CompareTo(".txt") == 0)
                {
                    try
                    {
                        StreamReader reader = new StreamReader(filepath);
                        StringBuilder builder = new StringBuilder();
                        string line = "";

                        while ((line = reader.ReadLine()) != null)
                        {
                            builder.AppendLine(line);
                        }
                        reader.Close();
                        richTextBox5.Text = builder.ToString();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }

        private void m_decode_Click_1(object sender, EventArgs e)
        {
            string inp = richTextBox5.Text;
            string[] sss = new string[100];
            int j = 0;
            for (int i = 0; i < inp.Length; i++)
            {
                if (inp[i] == '.')
                    sss[j] += ".";
                else if (inp[i] == '-')
                    sss[j] += "-";
                else if (inp[i] == ' ')
                    j++;
                else if (inp[i] == '/')
                    sss[j] += "/";
            }
            // for(int k=0; k<=j; k++)
            //     Console.WriteLine(s[k]);

            string ans = morse_Decode(sss, j);
            richTextBox7.Text = ans;
        }
    }
}

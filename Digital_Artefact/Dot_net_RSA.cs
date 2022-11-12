using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Xml.Serialization;

namespace Calculator
{
    public partial class Dot_net_RSA : Form
    {
        public Dot_net_RSA()
        {
            InitializeComponent();
        }

        RSAEncryption rsa = new RSAEncryption();

        private void button5_Click(object sender, EventArgs e)
        {
            //RSAEncryption rsa = new RSAEncryption();
            string cypher = string.Empty;
            var text = richTextBox4.Text;
            if (!string.IsNullOrEmpty(text))
            {
                cypher = rsa.Encrypt(text);
                richTextBox6.Text = cypher;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //RSAEncryption rsa = new RSAEncryption();
            string text = string.Empty;
            var cypher = richTextBox5.Text;
            if (!string.IsNullOrEmpty(cypher))
            {
                text = rsa.Decrypt(cypher);
                richTextBox7.Text = text;
            }
        }
    }

    public class RSAEncryption
    {
        RSACryptoServiceProvider csp = new RSACryptoServiceProvider(2048);
        private RSAParameters _privatekey;
        private RSAParameters _publickey;

        public RSAEncryption()
        {
            _privatekey = csp.ExportParameters(true);
            _publickey = csp.ExportParameters(false);

        }

        public string GetPublickey()
        {
            var sw = new StringWriter();
            var xs = new XmlSerializer(typeof(RSAParameters));
            xs.Serialize(sw, _publickey);
            return sw.ToString();
        }

        public string Encrypt(string plainText)
        {
            csp = new RSACryptoServiceProvider();
            csp.ImportParameters(_publickey);
            var data = Encoding.Unicode.GetBytes(plainText);
            var cypher = csp.Encrypt(data, false);
            return Convert.ToBase64String(cypher);
        }

        public string Decrypt(string cypherText)
        {
            var dataBytes = Convert.FromBase64String(cypherText);
            csp.ImportParameters(_privatekey);
            var plainText = csp.Decrypt(dataBytes, false);
            return Encoding.Unicode.GetString(plainText);
        }
    }
}

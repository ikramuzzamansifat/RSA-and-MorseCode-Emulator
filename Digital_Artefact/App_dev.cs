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
    public partial class App_dev : Form
    {
        public static App_dev ins;
        private BackgroundWorker backgroundWorker1;
        private Button Rsabtn;
        private Button Mencbtn;
        private Button button1;
        private Button button2;
        public TextBox tbx;
        public App_dev()
        {
            InitializeComponent();
            ins = this;
        }



        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Rsabtn = new System.Windows.Forms.Button();
            this.Mencbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Rsabtn
            // 
            this.Rsabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rsabtn.Location = new System.Drawing.Point(176, 78);
            this.Rsabtn.Name = "Rsabtn";
            this.Rsabtn.Size = new System.Drawing.Size(165, 85);
            this.Rsabtn.TabIndex = 0;
            this.Rsabtn.Text = "RSA";
            this.Rsabtn.UseVisualStyleBackColor = true;
            this.Rsabtn.Click += new System.EventHandler(this.Rsabtn_Click);
            // 
            // Mencbtn
            // 
            this.Mencbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mencbtn.Location = new System.Drawing.Point(566, 78);
            this.Mencbtn.Name = "Mencbtn";
            this.Mencbtn.Size = new System.Drawing.Size(165, 85);
            this.Mencbtn.TabIndex = 1;
            this.Mencbtn.Text = "Morse Code";
            this.Mencbtn.UseVisualStyleBackColor = true;
            this.Mencbtn.Click += new System.EventHandler(this.Mencbtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(538, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 85);
            this.button1.TabIndex = 2;
            this.button1.Text = "Morse Code from a file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(152, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 85);
            this.button2.TabIndex = 3;
            this.button2.Text = ".NET RSA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // App_dev
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(841, 511);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Mencbtn);
            this.Controls.Add(this.Rsabtn);
            this.Name = "App_dev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        private void Rsabtn_Click(object sender, EventArgs e)
        {
            // MorseCode_Encrypt fm = new MorseCode_Encrypt();
            RSA fm = new RSA();
            fm.Show();
        }

        private void Mencbtn_Click(object sender, EventArgs e)
        {
            Morse_Code fm = new Morse_Code();
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Morse_Code_from_a_file fm = new Morse_Code_from_a_file();
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dot_net_RSA fm = new Dot_net_RSA();
            fm.Show();
        }
    }

}





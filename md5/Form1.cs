using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace md5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(textBox1.Text));
            byte[] result = md5.Hash;
            StringBuilder encryptedPassword = new StringBuilder();

            for (int i = 0; i < result.Length; i++)
            {
                encryptedPassword.Append(result[i].ToString("x2"));
            }

            textBox2.Text = encryptedPassword.ToString();
        }
    }
}

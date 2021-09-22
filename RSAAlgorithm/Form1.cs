using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSAAlgorithm
{
    public partial class Form1 : Form
    {
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        //byte[] plaintext;
        byte[] encryptedtext;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RSAEncryption.GenerateKey();
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            //plaintext = ByteConverter.GetBytes(txtplain.Text);
            //encryptedtext = RSAEncryption.Encryption(plaintext, RSA.ExportParameters(false), false);
            //txtencrypt.Text = ByteConverter.GetString(encryptedtext);

            // Generated the private and public key. 
            // Public key will be distributed to client to encrypt.
            encryptedtext = RSAEncryption.Encrypt(RSAEncryption.encoder.GetBytes(txtplain.Text));
            txtencrypt.Text = RSAEncryption.encoder.GetString(encryptedtext);


        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            //byte[] decryptedtex = RSAEncryption.Decryption(encryptedtext,
            //RSA.ExportParameters(true), false);
            //txtdecrypt.Text = ByteConverter.GetString(decryptedtex);
            string decryptedText = string.Empty;
            txtdecrypt.Text = decryptedText;

            RSAEncryption.RSADecrypt(encryptedtext, ref decryptedText);            // Generated the private and public key. 

            txtdecrypt.Text = decryptedText;


        }
    }
}

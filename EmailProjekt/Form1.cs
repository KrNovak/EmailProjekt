using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace EmailProjekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            string to, from,pass, messagebody;
            MailMessage message = new MailMessage();
            to = txt_primatelj.Text;
            from = txt_pošiljatelj.Text;
            pass = pass_pošiljatelj.Text; //unijeti password primatelja
            messagebody = txt_poruka.Text;
            message.From = new MailAddress(from);
            message.To.Add(to);
            message.Body = messagebody;
            message.Subject = txt_naslov.Text;
            message.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                DialogResult code = MessageBox.Show("Email je uspješno poslan!", "Email sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(code == DialogResult.OK)
                {
                    txt_poruka.Clear();
                    txt_naslov.Clear();
                    txt_pošiljatelj.Clear();
                    txt_primatelj.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_poruka_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_primatelj_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_pošiljatelj_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace FindEnglishWords
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection connection = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0;Data Source = C:\Users\burak\Desktop\dbSozluk");
        Random random = new Random();
        int time = 90;
        int word = 0;

        void getir()
        {
            int sayi;
            sayi = random.Next(1, 2490);
            lblAnswer.Text = sayi.ToString();
            connection.Open();
            OleDbCommand command = new OleDbCommand("select ingilizce from sozluk where id = @p1", connection);
            command.Parameters.AddWithValue("@p1", sayi);
            OleDbDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                textEnglish.Text = dataReader[1].ToString();
                lblAnswer.Text = dataReader[2].ToString();
                lblAnswer.Text = lblAnswer.Text.ToLower();
            }
            connection.Close();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            getir();
            textTurkish.Focus();
            timer2.Start();
        }

        private void textTurkish_TextChanged(object sender, EventArgs e)
        {
            if (textTurkish.Text == lblAnswer.Text)
            {
                word++;
                lblWord.Text = word.ToString();
                getir();
                textTurkish.Clear();

            }
        }

        private void timer1_Click(object sender, EventArgs e)
        {
            time--;
            lblTime.Text = time.ToString();
            if (time == 0)
            {
                textTurkish.Enabled = false;
                textEnglish.Enabled = false;
                timer2.Stop();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using Devart.Data.MySql;


namespace MySqlAdapterPlaform
{
    public partial class Form1 : Form
    {
        Konekcija _konekcija = new Konekcija();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(_konekcija.connectionString);
            connection.Open();

            if(connection.State == ConnectionState.Open)
            {
                MessageBox.Show("otvorena veza");
            }

            else
            {
                MessageBox.Show("problem");
            }




           


        }
    }
}

//https://www.codeproject.com/Articles/43438/Connect-C-to-MySQL
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Book newBook;
            //newBook = new Book();

            Book newBook = new Book();

            newBook.BookName = "C#";
            newBook.Author = "Shota";
            newBook.PublishingDate = "01.07.2017";

            Book newBook1 = new Book();

            newBook1.BookName = "Java";
            newBook1.Author = "Shota";
            newBook1.PublishingDate = "01.08.2017";

            Book.BooksSold = 2;

            textBox1.Text = newBook1.BookName;
            textBox2.Text = newBook1.Author;
            textBox3.Text = Book.Rental_Days.ToString();

            

            //MessageBox.Show(newBook.PublishingDate + '\n' + newBook1.PublishingDate + '\n' + Book.Rental_Days);




        }
    }
}

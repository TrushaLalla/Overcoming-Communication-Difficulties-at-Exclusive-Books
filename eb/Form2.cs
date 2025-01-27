using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eb
{

    public partial class Form2 : Form

    {
        public object Checked { get; private set; }
        private List<BookDetails> allbookinfos = new List<BookDetails>();
        private List<BookDetails> allbookinfo = new List<BookDetails>();
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(BookDetails bookDetails)
        {
            InitializeComponent();
            if (bookDetails != null)
            {
                txttitle.Text = bookDetails.Title;
                txtauthname.Text = bookDetails.Name;
                txtauthsur.Text = bookDetails.Surname;
                txted.Text = bookDetails.Edition;
                txtdes.Text = bookDetails.Description;
                txtenterno.Text = bookDetails.FanaticsNumber;
                txtphonenumber.Text = bookDetails.PhoneNumber;

                // Set checkboxes
                chkyes1.Checked = bookDetails.IsInStock;
                chkno1.Checked = !bookDetails.IsInStock; // Opposite of IsInStock

                chkyes2.Checked = bookDetails.OrderIfNotAvailable;
                chkno2.Checked = !bookDetails.OrderIfNotAvailable;

                chkyes3.Checked = bookDetails.CheckOnline;
                chkno3.Checked = !bookDetails.CheckOnline;

                chksignup.Checked = bookDetails.IsMember;
                chkstock.Checked = bookDetails.IsInStock;

                // Handle preferred format checkboxes
                chkhardcover.Checked = bookDetails.PreferredFormat == "Hardcover";
                chkpaperback.Checked = bookDetails.PreferredFormat == "Paperback";
                chkebook.Checked = bookDetails.PreferredFormat == "eBook";
            }

        }
        //public List<BookDetails> allbookinfo = new List<BookDetails>();
        private void Form2_Load(object sender, EventArgs e)
        {
            txttitle.Focus();
            this.ActiveControl = txttitle;
            allbookinfos = new List<BookDetails>();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //BookDetails newBook = new BookDetails()



            string title = txttitle.Text;
            string name = txtauthname.Text;
            string surname = txtauthsur.Text;
            string edition = txted.Text;
            string description = txtdes.Text;
            string phoneNumber = txtphonenumber.Text;
            bool isInStock = chkstock.Checked;
            bool orderIfNotAvailable = chkyes2.Checked;
            bool checkOnline = chkyes3.Checked;
            bool isMember = chksignup.Checked || chkyes3.Checked;
            string preferredFormat = chkhardcover.Checked ? "Hardcover" : chkpaperback.Checked ? "Paperback" : chkebook.Checked ? "eBook" : "None";
            string number =txtenterno.Text;
            string fanaticsNumber=txtenterno.Text;  
            BookDetails newBook = new BookDetails(title, name, surname, edition, description, phoneNumber,
                                           isInStock, orderIfNotAvailable, checkOnline, isMember, preferredFormat,fanaticsNumber);
            allbookinfos.Add(newBook);

            txttitle.Text = string.Empty;
            txtauthname.Text = string.Empty;
            txtauthsur.Text = string.Empty;
            txted.Text = string.Empty;
            txtdes.Text = string.Empty;
            txtphonenumber.Text = string.Empty;
            txtenterno.Text = string.Empty; 

            // Uncheck all checkboxes
            chkstock.Checked = false;
            chkno1.Checked = false;
            chkyes2.Checked = false;
            chkno2.Checked = false;
            chksignup.Checked = false;
            chkyes3.Checked = false;
            chkno3.Checked = false;
            chkhardcover.Checked = false;
            chkpaperback.Checked = false;
            chkebook.Checked = false;
            chkstock.Checked = false;

            MessageBox.Show("Saved!", "Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Navigate to SearchCustTab
            //List<BookDetails> allbookinfos = new List<BookDetails>();
            Form3 form3 = new Form3(allbookinfos);
            this.Hide();
            form3.Show();
            //foreach (var book in allbookinfos)
            //{
            //    Console.WriteLine($"Title: {book.Title}, Author: {book.Name}, Format: {book.PreferredFormat}");
            //}
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(allbookinfos);
            this.Hide();
            form3.Show();
        }

        private void chkstock_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}

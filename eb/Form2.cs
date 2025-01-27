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
            bool isInStock = chkyes1.Checked;
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
            chkyes1.Checked = false;
            chkno1.Checked = false;
            chkyes2.Checked = false;
            chkno2.Checked = false;
            chksignup.Checked = false;
            chkyes3.Checked = false;
            chkno3.Checked = false;
            chkhardcover.Checked = false;
            chkpaperback.Checked = false;
            chkebook.Checked = false;

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
    }

}

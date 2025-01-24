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
        public List<BookDetails> allbookinfos = new List<BookDetails>();
        public Form2()
        {
            InitializeComponent();

        }
        //public List<BookDetails> allbookinfo = new List<BookDetails>();
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = txttitle.Text;
            string name = txtauthname.Text;
            string surname = txtauthsur.Text;
            string edition = txted.Text;
            string description = txtdes.Text;
            string phoneNumber = txtphonenumber.ToString();
            bool isInStock = chkyes1.Checked;
            bool orderIfNotAvailable = chkyes2.Checked;
            bool checkOnline = chkyes3.Checked;
            bool isMember = chksignup.Checked || chkyes3.Checked;
            string preferredFormat = chkhardcover.Checked ? "Hardcover" : chkpaperback.Checked ? "Paperback" : chkebook.Checked ? "eBook" : "None";

            BookDetails newBook = new BookDetails(title, name, surname, edition, description, phoneNumber,
                                           isInStock, orderIfNotAvailable, checkOnline, isMember, preferredFormat);
            allbookinfos.Add(newBook);

            txttitle.Text = string.Empty;
            txtauthname.Text = string.Empty;
            txtauthsur.Text = string.Empty;
            txted.Text = string.Empty;
            txtdes.Text = string.Empty;
            txtphonenumber.Text = string.Empty;

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
            List<BookDetails> booklist = new List<BookDetails>();
            Form3 form3 = new Form3(booklist);
            form3.Show();
        }
    }
}

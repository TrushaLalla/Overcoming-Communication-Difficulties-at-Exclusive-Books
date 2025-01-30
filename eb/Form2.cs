using System;
using System.Collections.Generic;
using System.Windows.Forms;
using eb;

namespace eb
{
    public partial class Form2 : Form
    {
        private List<BookDetails> allbookinfos = new List<BookDetails>();

        public Form2(List<BookDetails> allbookinfos, BookDetails bookDetails = null)
        {
            InitializeComponent();
            this.allbookinfos = allbookinfos ?? JsonHelper.LoadBooksFromJson(); // Load if null

            if (bookDetails != null)
            {
                PopulateFields(bookDetails);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txttitle.Focus();
        }

        public void PopulateFields(BookDetails book)
        {
            txttitle.Text = book.Title;
            txtauthname.Text = book.Name;
            txtauthsur.Text = book.Surname;
            txted.Text = book.Edition;
            txtdes.Text = book.Description;
            txtphonenumber.Text = book.PhoneNumber;
            txtenterno.Text = book.FanaticsNumber;

            // Checkboxes
            chkyes1.Checked = book.IsInStock;
            chkno1.Checked = !book.IsInStock;

            chkyes2.Checked = book.OrderIfNotAvailable;
            chkno2.Checked = !book.OrderIfNotAvailable;

            chkyes3.Checked = book.CheckOnline;
            chkno3.Checked = !book.CheckOnline;

            chksignup.Checked = book.IsMember;
            chkstock.Checked = book.IsInStock;

            // Preferred Format
            chkhardcover.Checked = book.PreferredFormat == "Hardcover";
            chkpaperback.Checked = book.PreferredFormat == "Paperback";
            chkebook.Checked = book.PreferredFormat == "eBook";
        }

        private void button1_Click(object sender, EventArgs e)//save button
        {
            // Capture Book Details
            BookDetails newBook = new BookDetails(
                txttitle.Text, txtauthname.Text, txtauthsur.Text,
                txted.Text, txtdes.Text, txtphonenumber.Text,
                chkstock.Checked, chkyes2.Checked, chkyes3.Checked,
                chksignup.Checked,
                chkhardcover.Checked ? "Hardcover" : chkpaperback.Checked ? "Paperback" : chkebook.Checked ? "eBook" : "None",
                txtenterno.Text);

            allbookinfos.Add(newBook);
            JsonHelper.SaveBooksToJson(allbookinfos);

            MessageBox.Show("Saved!", "Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear Fields
            ClearFormFields();

            // Navigate to Form3
            Form3 form3 = new Form3(allbookinfos);
            this.Hide();
            form3.Show();
        }

        private void ClearFormFields()
        {
            txttitle.Clear();
            txtauthname.Clear();
            txtauthsur.Clear();
            txted.Clear();
            txtdes.Clear();
            txtphonenumber.Clear();
            txtenterno.Clear();

            // Uncheck all checkboxes
            foreach (Control control in Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
            }
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
    }
}

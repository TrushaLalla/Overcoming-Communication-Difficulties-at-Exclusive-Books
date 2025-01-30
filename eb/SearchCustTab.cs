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

    public partial class Form3 : Form
    {
        // Define the private field for book information
        private List<BookDetails> allbookinfos;

        // Constructor that accepts a list of book details and assigns it to the field
        public Form3(List<BookDetails> booklist)
        {
            InitializeComponent();
            this.allbookinfos = booklist;
            //PopulateTextBoxes();
        }



        private void btnhome_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string searchfanaticsNumber = txtsearchnumber.Text;
            string searchTitle = txtsearchtitle.Text;
            string searchSurname = txtsearchsurname.Text;

            // LINQ search query
            BookDetails foundBook = allbookinfos.FirstOrDefault(book =>
                (!string.IsNullOrEmpty(searchfanaticsNumber) && book.FanaticsNumber == searchfanaticsNumber) ||
                (!string.IsNullOrEmpty(searchTitle) && book.Title != null && book.Title.Equals(searchTitle, StringComparison.OrdinalIgnoreCase)) ||
                (!string.IsNullOrEmpty(searchSurname) && book.Surname != null && book.Surname.Equals(searchSurname, StringComparison.OrdinalIgnoreCase)));

            if (foundBook != null)
            {
                // ✅ Correctly pass the found book to Form2
                Form2 form2 = new Form2(allbookinfos, foundBook);
                this.Hide();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Book not found.", "Book Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnnewbook_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(allbookinfos);
            this.Hide();
            form2.Show();
        }
    
    }
}


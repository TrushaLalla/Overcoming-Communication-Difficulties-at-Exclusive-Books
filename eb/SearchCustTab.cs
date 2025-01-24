﻿using System;
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
        private List<BookDetails> allbookinfo;

        // Constructor that accepts a list of book details and assigns it to the field
        public Form3(List<BookDetails> bookInfo)
        {
            InitializeComponent(); // Initializes the form components
            this.allbookinfo = bookInfo; // Assigns the passed-in list to the private field
        }


        private void btnhome_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string searchNumber = txtsearchnumber.Text;
            string searchTitle = txtsearchtitle.Text;
            string searchSurname = txtsearchsurname.Text;

            // Search using LINQ
            // Filter results using LINQ
            var results = allbookinfo.Where(book =>
                (string.IsNullOrEmpty(searchNumber) || book.searchNumber == searchNumber) &&
                (string.IsNullOrEmpty(searchTitle) || (book.searchTitle != null && book.searchTitle.Contains(searchTitle, StringComparison.OrdinalIgnoreCase))) &&
                (string.IsNullOrEmpty(searchSurname) || (book.searchSurname != null && book.searchSurname.Contains(searchSurname, StringComparison.OrdinalIgnoreCase)))
            ).ToList();

            // Display results or show a message if no results are found
            if (results.Any())
            {
                MessageBox.Show($"{results.Count} result(s) found!", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Optional: Display results in a control like DataGridView
            }
            else
            {
                MessageBox.Show("No results found.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnnewbook_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }
    
    }
}


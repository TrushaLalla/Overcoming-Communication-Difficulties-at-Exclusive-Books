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
    public partial class Form1 : Form

    {
        private List<BookDetails> allbookinfos = new List<BookDetails>();

        public Form1()
        {
            InitializeComponent();
            allbookinfos = JsonHelper.LoadBooksFromJson();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
            
        }
    }
}

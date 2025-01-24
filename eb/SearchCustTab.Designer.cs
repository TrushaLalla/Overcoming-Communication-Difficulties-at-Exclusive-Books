using System.Collections.Generic;

namespace eb
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCustTab1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsearchnumber = new System.Windows.Forms.TextBox();
            this.txtsearchtitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnnewbook = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsearchsurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 114);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(152, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "GREENSTONE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 33);
            this.label2.TabIndex = 16;
            this.label2.Text = "Search Customer Information";
            // 
            // txtsearchnumber
            // 
            this.txtsearchnumber.Location = new System.Drawing.Point(406, 176);
            this.txtsearchnumber.Multiline = true;
            this.txtsearchnumber.Name = "txtsearchnumber";
            this.txtsearchnumber.Size = new System.Drawing.Size(271, 40);
            this.txtsearchnumber.TabIndex = 17;
            // 
            // txtsearchtitle
            // 
            this.txtsearchtitle.Location = new System.Drawing.Point(406, 276);
            this.txtsearchtitle.Multiline = true;
            this.txtsearchtitle.Name = "txtsearchtitle";
            this.txtsearchtitle.Size = new System.Drawing.Size(271, 38);
            this.txtsearchtitle.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Search book using either or:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(404, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Fanatics Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(404, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Provided Title of Book:";
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnhome.Location = new System.Drawing.Point(72, 418);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(169, 41);
            this.btnhome.TabIndex = 23;
            this.btnhome.Text = "HOME";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnnewbook
            // 
            this.btnnewbook.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnnewbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnewbook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnnewbook.Location = new System.Drawing.Point(801, 418);
            this.btnnewbook.Name = "btnnewbook";
            this.btnnewbook.Size = new System.Drawing.Size(169, 41);
            this.btnnewbook.TabIndex = 24;
            this.btnnewbook.Text = "NEW BOOK";
            this.btnnewbook.UseVisualStyleBackColor = false;
            this.btnnewbook.Click += new System.EventHandler(this.btnnewbook_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsearch.Location = new System.Drawing.Point(456, 418);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(169, 41);
            this.btnsearch.TabIndex = 25;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtsearchsurname
            // 
            this.txtsearchsurname.Location = new System.Drawing.Point(406, 374);
            this.txtsearchsurname.Multiline = true;
            this.txtsearchsurname.Name = "txtsearchsurname";
            this.txtsearchsurname.Size = new System.Drawing.Size(271, 38);
            this.txtsearchsurname.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(404, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "Provided Author Surname:";
            // 
            // SearchCustTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 471);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsearchsurname);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnnewbook);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsearchtitle);
            this.Controls.Add(this.txtsearchnumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SearchCustTab";
            this.Text = "SearchCustTab";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsearchnumber;
        private System.Windows.Forms.TextBox txtsearchtitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btnnewbook;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtsearchsurname;
        private System.Windows.Forms.Label label5;
        private List<BookDetails> allbookinfo;

        public Form3(List<BookDetails> allbookinfo)
        {
            this.allbookinfo = allbookinfo;
        }
    }
}
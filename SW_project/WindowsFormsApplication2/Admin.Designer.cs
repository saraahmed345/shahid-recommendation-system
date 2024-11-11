namespace WindowsFormsApplication2
{
    partial class Admin
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
            this.add_new_content = new System.Windows.Forms.Button();
            this.contetn_description = new System.Windows.Forms.RichTextBox();
            this.content_title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.content_type = new System.Windows.Forms.ComboBox();
            this.content_genre = new System.Windows.Forms.ComboBox();
            this.content_tags = new System.Windows.Forms.CheckedListBox();
            this.release_date = new System.Windows.Forms.DateTimePicker();
            this.release_year_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_new_content
            // 
            this.add_new_content.AutoSize = true;
            this.add_new_content.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_new_content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_new_content.Location = new System.Drawing.Point(289, 474);
            this.add_new_content.Name = "add_new_content";
            this.add_new_content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.add_new_content.Size = new System.Drawing.Size(223, 51);
            this.add_new_content.TabIndex = 0;
            this.add_new_content.Text = "Add new content";
            this.add_new_content.UseVisualStyleBackColor = true;
            this.add_new_content.Click += new System.EventHandler(this.add_new_content_Click);
            // 
            // contetn_description
            // 
            this.contetn_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contetn_description.Location = new System.Drawing.Point(221, 113);
            this.contetn_description.Name = "contetn_description";
            this.contetn_description.Size = new System.Drawing.Size(476, 113);
            this.contetn_description.TabIndex = 1;
            this.contetn_description.Text = "";
            // 
            // content_title
            // 
            this.content_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content_title.Location = new System.Drawing.Point(221, 41);
            this.content_title.Name = "content_title";
            this.content_title.Size = new System.Drawing.Size(196, 26);
            this.content_title.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(152, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tags";
            // 
            // content_type
            // 
            this.content_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content_type.FormattingEnabled = true;
            this.content_type.Items.AddRange(new object[] {
            "TV show",
            "Movie"});
            this.content_type.Location = new System.Drawing.Point(221, 76);
            this.content_type.Name = "content_type";
            this.content_type.Size = new System.Drawing.Size(121, 28);
            this.content_type.TabIndex = 8;
            // 
            // content_genre
            // 
            this.content_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content_genre.FormattingEnabled = true;
            this.content_genre.Items.AddRange(new object[] {
            "Action",
            "Comedy",
            "Crime",
            "Drama",
            "Horror",
            "Romance",
            "Sci-Fi",
            "Thriller"});
            this.content_genre.Location = new System.Drawing.Point(221, 235);
            this.content_genre.Name = "content_genre";
            this.content_genre.Size = new System.Drawing.Size(121, 28);
            this.content_genre.Sorted = true;
            this.content_genre.TabIndex = 9;
            // 
            // content_tags
            // 
            this.content_tags.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content_tags.FormattingEnabled = true;
            this.content_tags.Items.AddRange(new object[] {
            "Action",
            "Adventure",
            "Animation",
            "Biography",
            "Comedy",
            "Crime",
            "Documentary",
            "Drama",
            "Fantasy",
            "Horror",
            "Mystery",
            "Romance",
            "Sci-Fi",
            "Thriller",
            "War"});
            this.content_tags.Location = new System.Drawing.Point(221, 275);
            this.content_tags.MultiColumn = true;
            this.content_tags.Name = "content_tags";
            this.content_tags.Size = new System.Drawing.Size(476, 109);
            this.content_tags.TabIndex = 10;
            // 
            // release_date
            // 
            this.release_date.Location = new System.Drawing.Point(221, 403);
            this.release_date.Name = "release_date";
            this.release_date.Size = new System.Drawing.Size(200, 20);
            this.release_date.TabIndex = 11;
            // 
            // release_year_label
            // 
            this.release_year_label.AutoSize = true;
            this.release_year_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.release_year_label.Location = new System.Drawing.Point(84, 401);
            this.release_year_label.Name = "release_year_label";
            this.release_year_label.Size = new System.Drawing.Size(120, 24);
            this.release_year_label.TabIndex = 12;
            this.release_year_label.Text = "Release year";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.release_year_label);
            this.Controls.Add(this.release_date);
            this.Controls.Add(this.content_tags);
            this.Controls.Add(this.content_genre);
            this.Controls.Add(this.content_type);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.content_title);
            this.Controls.Add(this.contetn_description);
            this.Controls.Add(this.add_new_content);
            this.Name = "Admin";
            this.Text = "Admin dashboard - Shahid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_new_content;
        private System.Windows.Forms.RichTextBox contetn_description;
        private System.Windows.Forms.TextBox content_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox content_type;
        private System.Windows.Forms.ComboBox content_genre;
        private System.Windows.Forms.CheckedListBox content_tags;
        private System.Windows.Forms.DateTimePicker release_date;
        private System.Windows.Forms.Label release_year_label;
    }
}
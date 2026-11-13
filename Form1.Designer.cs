namespace Library_Book_Manager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblSearch;

        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtAvailable;
        private System.Windows.Forms.TextBox txtSearch;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;

        private System.Windows.Forms.DataGridView dataGridView1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();

            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtAvailable = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();

            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // BookID
            this.lblBookID.AutoSize = true;
            this.lblBookID.Location = new System.Drawing.Point(30, 30);
            this.lblBookID.Text = "Book ID";

            this.txtBookID.Location = new System.Drawing.Point(120, 27);
            this.txtBookID.Size = new System.Drawing.Size(180, 23);

            // Title
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(30, 70);
            this.lblTitle.Text = "Title";

            this.txtTitle.Location = new System.Drawing.Point(120, 67);
            this.txtTitle.Size = new System.Drawing.Size(180, 23);

            // Author
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(30, 110);
            this.lblAuthor.Text = "Author";

            this.txtAuthor.Location = new System.Drawing.Point(120, 107);
            this.txtAuthor.Size = new System.Drawing.Size(180, 23);

            // Category
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(30, 150);
            this.lblCategory.Text = "Category";

            this.txtCategory.Location = new System.Drawing.Point(120, 147);
            this.txtCategory.Size = new System.Drawing.Size(180, 23);

            // Available
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(30, 190);
            this.lblAvailable.Text = "Available";

            this.txtAvailable.Location = new System.Drawing.Point(120, 187);
            this.txtAvailable.Size = new System.Drawing.Size(180, 23);

            // Add Button
            this.btnAdd.Location = new System.Drawing.Point(30, 230);
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // Update Button
            this.btnUpdate.Location = new System.Drawing.Point(120, 230);
            this.btnUpdate.Size = new System.Drawing.Size(80, 30);
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // Delete Button
            this.btnDelete.Location = new System.Drawing.Point(210, 230);
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // Search
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(350, 30);
            this.lblSearch.Text = "Search";

            this.txtSearch.Location = new System.Drawing.Point(410, 27);
            this.txtSearch.Size = new System.Drawing.Size(180, 23);

            this.btnSearch.Location = new System.Drawing.Point(600, 25);
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // DataGridView
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dataGridView1.Location = new System.Drawing.Point(350, 70);
            this.dataGridView1.Size = new System.Drawing.Size(550, 300);

            // Form
            this.ClientSize = new System.Drawing.Size(930, 420);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.lblSearch);

            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtAvailable);
            this.Controls.Add(this.txtSearch);

            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);

            this.Controls.Add(this.dataGridView1);

            this.Name = "Form1";
            this.Text = "Library Book Manager";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
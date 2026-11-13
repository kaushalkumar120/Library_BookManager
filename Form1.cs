using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Library_Book_Manager
{
    public partial class Form1 : Form
    {
        SQLiteConnection con;

        public Form1()
        {
            InitializeComponent();

            con = new SQLiteConnection("Data Source=Library.db;Version=3;");

            CreateTable();
            LoadBooks();
        }

        void CreateTable()
        {
            con.Open();

            string query = @"CREATE TABLE IF NOT EXISTS Books
                            (
                                BookID INTEGER PRIMARY KEY AUTOINCREMENT,
                                Title TEXT,
                                Author TEXT,
                                Category TEXT,
                                Available TEXT
                            )";

            SQLiteCommand cmd = new SQLiteCommand(query, con);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        void LoadBooks()
        {
            con.Open();

            SQLiteDataAdapter da =
                new SQLiteDataAdapter("SELECT * FROM Books", con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();

            string query = @"INSERT INTO Books
                            (Title, Author, Category, Available)
                            VALUES (@title, @author, @category, @available)";

            SQLiteCommand cmd = new SQLiteCommand(query, con);

            cmd.Parameters.AddWithValue("@title", txtTitle.Text);
            cmd.Parameters.AddWithValue("@author", txtAuthor.Text);
            cmd.Parameters.AddWithValue("@category", txtCategory.Text);
            cmd.Parameters.AddWithValue("@available", txtAvailable.Text);

            cmd.ExecuteNonQuery();

            con.Close();

            LoadBooks();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();

            string query = @"UPDATE Books SET
                            Title=@title,
                            Author=@author,
                            Category=@category,
                            Available=@available
                            WHERE BookID=@id";

            SQLiteCommand cmd = new SQLiteCommand(query, con);

            cmd.Parameters.AddWithValue("@id", txtBookID.Text);
            cmd.Parameters.AddWithValue("@title", txtTitle.Text);
            cmd.Parameters.AddWithValue("@author", txtAuthor.Text);
            cmd.Parameters.AddWithValue("@category", txtCategory.Text);
            cmd.Parameters.AddWithValue("@available", txtAvailable.Text);

            cmd.ExecuteNonQuery();

            con.Close();

            LoadBooks();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();

            string query = "DELETE FROM Books WHERE BookID=@id";

            SQLiteCommand cmd = new SQLiteCommand(query, con);
            cmd.Parameters.AddWithValue("@id", txtBookID.Text);

            cmd.ExecuteNonQuery();

            con.Close();

            LoadBooks();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();

            string query = @"SELECT * FROM Books
                            WHERE Title LIKE @search
                            OR Author LIKE @search
                            OR Category LIKE @search";

            SQLiteDataAdapter da =
                new SQLiteDataAdapter(query, con);

            da.SelectCommand.Parameters.AddWithValue(
                "@search", "%" + txtSearch.Text + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            con.Close();
        }
    }
}
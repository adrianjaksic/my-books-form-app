using Controllers.Books;
using Interfaces.Views;
using Interfaces.Views.Books;
using Models.Books;
using NLog;
using Repository.Books;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WinForm.Helper;

namespace WinForm
{
    public partial class FrmBooks : Form, IBookView, IMainView
    {
        #region Private fields and Constructor

        private readonly Logger _logger = LogManager.GetCurrentClassLogger();
        private readonly BookController _controller;

        public FrmBooks()
        {
            _controller = new BookController(this, new BookRepository(), new BindingRepository());
            InitializeComponent();
        }

        #endregion

        #region IBookView

        public void SetBindings(IEnumerable<Models.Books.Binding> bindings)
        {
            bindingBindingSource.DataSource = bindings;
        }

        public void SetBooks(IEnumerable<Book> books)
        {
            bookBindingSource.DataSource = books;
        }

        #endregion

        #region IMainView
        public void ShowExceptionMessage(Exception exc)
        {
            _logger.Error(exc);
            MessageBox.Show(this, exc.Message, "Error happened", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        #region Events

        private void Books_Load(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            _controller.Initialization();
        }

        private void buttonLoadBooks_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _controller.LoadBooks(openFileDialog.FileName);
            }
        }

        private void buttonDeleteNotOnStock_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure you want to delete all books not on stock?", "Delete books", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _controller.DeleteBooksNotInStock();
            }            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == descriptionDataGridViewTextBoxColumn.Index)
            {
                var selectedBook = bookBindingSource.Current as Book;
                if (selectedBook != null)
                {
                    MessageBox.Show(this, selectedBook.Description, "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridViewBooks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            HighlightRowsNotOnStock(e);
            if (e.ColumnIndex == priceDataGridViewTextBoxColumn.Index && e.Value != null)
            {
                var price = e.Value as decimal?;
                if (price.HasValue)
                {
                    e.CellStyle.ForeColor = PriceColorHelper.GetPriceColor(price.Value);
                }
            }
        }

        private void HighlightRowsNotOnStock(DataGridViewCellFormattingEventArgs e)
        {
            if (bookBindingSource.Count > 0 && e.RowIndex != dataGridViewBooks.NewRowIndex)
            {
                var book = bookBindingSource[e.RowIndex] as Book;
                if (book != null && !book.InStock)
                {
                    e.CellStyle.BackColor = Color.LightGray;
                }
            }
        }

        #endregion
    }
}

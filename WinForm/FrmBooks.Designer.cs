namespace WinForm
{
    partial class FrmBooks
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBooks));
            this.flowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonLoadBooks = new System.Windows.Forms.Button();
            this.buttonDeleteNotOnStock = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.bindingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.inStockDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.flowLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.Controls.Add(this.buttonLoadBooks);
            this.flowLayoutPanelMain.Controls.Add(this.buttonDeleteNotOnStock);
            this.flowLayoutPanelMain.Controls.Add(this.buttonExit);
            this.flowLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelMain.MaximumSize = new System.Drawing.Size(0, 28);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(778, 28);
            this.flowLayoutPanelMain.TabIndex = 0;
            // 
            // buttonLoadBooks
            // 
            this.buttonLoadBooks.Location = new System.Drawing.Point(3, 3);
            this.buttonLoadBooks.Name = "buttonLoadBooks";
            this.buttonLoadBooks.Size = new System.Drawing.Size(150, 23);
            this.buttonLoadBooks.TabIndex = 1;
            this.buttonLoadBooks.Text = "Load books";
            this.buttonLoadBooks.UseVisualStyleBackColor = true;
            this.buttonLoadBooks.Click += new System.EventHandler(this.buttonLoadBooks_Click);
            // 
            // buttonDeleteNotOnStock
            // 
            this.buttonDeleteNotOnStock.Location = new System.Drawing.Point(159, 3);
            this.buttonDeleteNotOnStock.Name = "buttonDeleteNotOnStock";
            this.buttonDeleteNotOnStock.Size = new System.Drawing.Size(150, 23);
            this.buttonDeleteNotOnStock.TabIndex = 2;
            this.buttonDeleteNotOnStock.Text = "Delete books not on stock";
            this.buttonDeleteNotOnStock.UseVisualStyleBackColor = true;
            this.buttonDeleteNotOnStock.Click += new System.EventHandler(this.buttonDeleteNotOnStock_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(315, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(150, 23);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AutoGenerateColumns = false;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.bindingDataGridViewTextBoxColumn,
            this.inStockDataGridViewCheckBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridViewBooks.DataSource = this.bookBindingSource;
            this.dataGridViewBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBooks.Location = new System.Drawing.Point(3, 37);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.Size = new System.Drawing.Size(778, 521);
            this.dataGridViewBooks.TabIndex = 0;
            this.dataGridViewBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellClick);
            this.dataGridViewBooks.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewBooks_CellFormatting);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "xlsx";
            this.openFileDialog.FileName = "Books.csv";
            this.openFileDialog.Filter = "CSV|*.csv";
            this.openFileDialog.InitialDirectory = "\\";
            this.openFileDialog.Title = "Open book excel file";
            // 
            // bindingBindingSource
            // 
            this.bindingBindingSource.DataSource = typeof(Models.Books.Binding);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(Models.Books.Book);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewBooks, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanelMain, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.FillWeight = 180F;
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 180;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.FillWeight = 140F;
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.Width = 140;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.FillWeight = 80F;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 80;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.FillWeight = 80F;
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.Width = 80;
            // 
            // bindingDataGridViewTextBoxColumn
            // 
            this.bindingDataGridViewTextBoxColumn.DataPropertyName = "Binding";
            this.bindingDataGridViewTextBoxColumn.DataSource = this.bindingBindingSource;
            this.bindingDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.bindingDataGridViewTextBoxColumn.HeaderText = "Binding";
            this.bindingDataGridViewTextBoxColumn.Name = "bindingDataGridViewTextBoxColumn";
            this.bindingDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bindingDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bindingDataGridViewTextBoxColumn.ValueMember = "Name";
            // 
            // inStockDataGridViewCheckBoxColumn
            // 
            this.inStockDataGridViewCheckBoxColumn.DataPropertyName = "InStock";
            this.inStockDataGridViewCheckBoxColumn.FillWeight = 55F;
            this.inStockDataGridViewCheckBoxColumn.HeaderText = "In Stock";
            this.inStockDataGridViewCheckBoxColumn.Name = "inStockDataGridViewCheckBoxColumn";
            this.inStockDataGridViewCheckBoxColumn.Width = 55;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.descriptionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.descriptionDataGridViewTextBoxColumn.Text = "Show";
            this.descriptionDataGridViewTextBoxColumn.UseColumnTextForButtonValue = true;
            // 
            // FrmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Load);
            this.flowLayoutPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMain;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.Button buttonLoadBooks;
        private System.Windows.Forms.BindingSource bindingBindingSource;
        private System.Windows.Forms.Button buttonDeleteNotOnStock;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn bindingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inStockDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn descriptionDataGridViewTextBoxColumn;
    }
}


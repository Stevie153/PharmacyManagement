namespace PharmacyManagement
{
    partial class BillingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Qty = new Bunifu.UI.WinForms.BunifuTextBox();
            this.Stocklbl = new System.Windows.Forms.Label();
            this.Addbtn = new Guna.UI2.WinForms.Guna2Button();
            this.BillGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totalprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.printbtn = new Guna.UI2.WinForms.Guna2Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Brown;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(27, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(176, 43);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Billing Form";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Brown;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 31);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Select Medicine";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // Qty
            // 
            this.Qty.AcceptsReturn = false;
            this.Qty.AcceptsTab = false;
            this.Qty.AnimationSpeed = 200;
            this.Qty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Qty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Qty.BackColor = System.Drawing.Color.White;
            this.Qty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Qty.BackgroundImage")));
            this.Qty.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.Qty.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Qty.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Qty.BorderColorIdle = System.Drawing.Color.Silver;
            this.Qty.BorderRadius = 1;
            this.Qty.BorderThickness = 1;
            this.Qty.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Qty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Qty.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.Qty.DefaultText = "Quantity";
            this.Qty.FillColor = System.Drawing.Color.White;
            this.Qty.ForeColor = System.Drawing.Color.Brown;
            this.Qty.HideSelection = true;
            this.Qty.IconLeft = null;
            this.Qty.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.Qty.IconPadding = 10;
            this.Qty.IconRight = null;
            this.Qty.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.Qty.Lines = new string[] {
        "Quantity"};
            this.Qty.Location = new System.Drawing.Point(12, 228);
            this.Qty.MaxLength = 32767;
            this.Qty.MinimumSize = new System.Drawing.Size(1, 1);
            this.Qty.Modified = false;
            this.Qty.Multiline = false;
            this.Qty.Name = "Qty";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Qty.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Qty.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.Brown;
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Brown;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Qty.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Brown;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Qty.OnIdleState = stateProperties12;
            this.Qty.Padding = new System.Windows.Forms.Padding(3);
            this.Qty.PasswordChar = '\0';
            this.Qty.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.Qty.PlaceholderText = "Enter text";
            this.Qty.ReadOnly = false;
            this.Qty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Qty.SelectedText = "";
            this.Qty.SelectionLength = 0;
            this.Qty.SelectionStart = 0;
            this.Qty.ShortcutsEnabled = true;
            this.Qty.Size = new System.Drawing.Size(210, 41);
            this.Qty.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.Qty.TabIndex = 3;
            this.Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Qty.TextMarginBottom = 0;
            this.Qty.TextMarginLeft = 3;
            this.Qty.TextMarginTop = 0;
            this.Qty.TextPlaceholder = "Enter text";
            this.Qty.UseSystemPasswordChar = false;
            this.Qty.WordWrap = true;
            // 
            // Stocklbl
            // 
            this.Stocklbl.AutoSize = true;
            this.Stocklbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stocklbl.ForeColor = System.Drawing.Color.Brown;
            this.Stocklbl.Location = new System.Drawing.Point(43, 175);
            this.Stocklbl.Name = "Stocklbl";
            this.Stocklbl.Size = new System.Drawing.Size(134, 23);
            this.Stocklbl.TabIndex = 4;
            this.Stocklbl.Text = "Available Stock";
            this.Stocklbl.Visible = false;
            // 
            // Addbtn
            // 
            this.Addbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Addbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Addbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Addbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Addbtn.FillColor = System.Drawing.Color.Brown;
            this.Addbtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.Color.White;
            this.Addbtn.Location = new System.Drawing.Point(21, 309);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(182, 47);
            this.Addbtn.TabIndex = 10;
            this.Addbtn.Text = "Add To Bill";
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // BillGridView
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.BillGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.BillGridView.ColumnHeadersHeight = 30;
            this.BillGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BillGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Medname,
            this.MedQty,
            this.Unitprice,
            this.Totalprice});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.BillGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillGridView.Location = new System.Drawing.Point(354, 12);
            this.BillGridView.Name = "BillGridView";
            this.BillGridView.RowHeadersVisible = false;
            this.BillGridView.RowHeadersWidth = 51;
            this.BillGridView.RowTemplate.Height = 24;
            this.BillGridView.Size = new System.Drawing.Size(770, 542);
            this.BillGridView.TabIndex = 11;
            this.BillGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BillGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BillGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BillGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BillGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BillGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BillGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Brown;
            this.BillGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BillGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BillGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BillGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.BillGridView.ThemeStyle.ReadOnly = false;
            this.BillGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BillGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BillGridView.ThemeStyle.RowsStyle.Height = 24;
            this.BillGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Id
            // 
            this.Id.HeaderText = "MedId";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            // 
            // Medname
            // 
            this.Medname.HeaderText = "Medname";
            this.Medname.MinimumWidth = 6;
            this.Medname.Name = "Medname";
            // 
            // MedQty
            // 
            this.MedQty.HeaderText = "Quantity";
            this.MedQty.MinimumWidth = 6;
            this.MedQty.Name = "MedQty";
            // 
            // Unitprice
            // 
            this.Unitprice.HeaderText = "UnitPrice";
            this.Unitprice.MinimumWidth = 6;
            this.Unitprice.Name = "Unitprice";
            // 
            // Totalprice
            // 
            this.Totalprice.HeaderText = "TotalPrice";
            this.Totalprice.MinimumWidth = 6;
            this.Totalprice.Name = "Totalprice";
            // 
            // totalamount
            // 
            this.totalamount.BackColor = System.Drawing.Color.Transparent;
            this.totalamount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalamount.ForeColor = System.Drawing.Color.Brown;
            this.totalamount.Location = new System.Drawing.Point(635, 592);
            this.totalamount.Name = "totalamount";
            this.totalamount.Size = new System.Drawing.Size(114, 25);
            this.totalamount.TabIndex = 12;
            this.totalamount.Text = "Total Amount";
            // 
            // printbtn
            // 
            this.printbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.printbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.printbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.printbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.printbtn.FillColor = System.Drawing.Color.Brown;
            this.printbtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbtn.ForeColor = System.Drawing.Color.White;
            this.printbtn.Location = new System.Drawing.Point(786, 673);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(148, 47);
            this.printbtn.TabIndex = 13;
            this.printbtn.Text = "Print";
            this.printbtn.Click += new System.EventHandler(this.printbtn_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Brown;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(439, 673);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(148, 47);
            this.guna2Button1.TabIndex = 14;
            this.guna2Button1.Text = "Home";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 770);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.printbtn);
            this.Controls.Add(this.totalamount);
            this.Controls.Add(this.BillGridView);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.Stocklbl);
            this.Controls.Add(this.Qty);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillingForm";
            this.Load += new System.EventHandler(this.BillingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.UI.WinForms.BunifuTextBox Qty;
        private System.Windows.Forms.Label Stocklbl;
        private Guna.UI2.WinForms.Guna2Button Addbtn;
        private Guna.UI2.WinForms.Guna2DataGridView BillGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medname;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totalprice;
        private Guna.UI2.WinForms.Guna2HtmlLabel totalamount;
        private Guna.UI2.WinForms.Guna2Button printbtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
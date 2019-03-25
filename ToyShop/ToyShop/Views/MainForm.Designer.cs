namespace ToyShop
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.infoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.infoLabel7 = new System.Windows.Forms.Label();
            this.infoLabel6 = new System.Windows.Forms.Label();
            this.infoLabel5 = new System.Windows.Forms.Label();
            this.infoLabel4 = new System.Windows.Forms.Label();
            this.infoLabel3 = new System.Windows.Forms.Label();
            this.infoLabel2 = new System.Windows.Forms.Label();
            this.toysListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.infoLabel1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.infoTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::ToyShop.Properties.Resources.Spectrum_logo_3;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeMenuItem,
            this.toyMenuItem,
            this.storageMenuItem,
            this.deliveryMenuItem,
            this.userMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // employeeMenuItem
            // 
            this.employeeMenuItem.Name = "employeeMenuItem";
            this.employeeMenuItem.Size = new System.Drawing.Size(85, 20);
            this.employeeMenuItem.Text = "Сотрудники";
            this.employeeMenuItem.Click += new System.EventHandler(this.employeeMenuItem_Click);
            // 
            // toyMenuItem
            // 
            this.toyMenuItem.Name = "toyMenuItem";
            this.toyMenuItem.Size = new System.Drawing.Size(70, 20);
            this.toyMenuItem.Text = "Игрушки";
            this.toyMenuItem.Click += new System.EventHandler(this.toyMenuItem_Click);
            // 
            // storageMenuItem
            // 
            this.storageMenuItem.Name = "storageMenuItem";
            this.storageMenuItem.Size = new System.Drawing.Size(61, 20);
            this.storageMenuItem.Text = "Склады";
            this.storageMenuItem.Click += new System.EventHandler(this.storageMenuItem_Click);
            // 
            // deliveryMenuItem
            // 
            this.deliveryMenuItem.Name = "deliveryMenuItem";
            this.deliveryMenuItem.Size = new System.Drawing.Size(70, 20);
            this.deliveryMenuItem.Text = "Доставки";
            this.deliveryMenuItem.Click += new System.EventHandler(this.deliveryMenuItem_Click);
            // 
            // userMenuItem
            // 
            this.userMenuItem.Name = "userMenuItem";
            this.userMenuItem.Size = new System.Drawing.Size(97, 20);
            this.userMenuItem.Text = "Пользователи";
            this.userMenuItem.Click += new System.EventHandler(this.userMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.removeButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.editButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.addButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.listView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.55951F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.32951F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11099F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 411);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(526, 370);
            this.removeButton.Margin = new System.Windows.Forms.Padding(10, 5, 90, 5);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(160, 36);
            this.removeButton.TabIndex = 8;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(308, 370);
            this.editButton.Margin = new System.Windows.Forms.Padding(50, 5, 50, 5);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(158, 36);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(90, 370);
            this.addButton.Margin = new System.Windows.Forms.Padding(90, 5, 10, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(158, 36);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // listView
            // 
            this.listView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.BackColor = System.Drawing.Color.PaleGreen;
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader});
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView.Location = new System.Drawing.Point(10, 10);
            this.listView.Margin = new System.Windows.Forms.Padding(10);
            this.listView.Name = "listView";
            this.tableLayoutPanel1.SetRowSpan(this.listView, 2);
            this.listView.Size = new System.Drawing.Size(238, 345);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // columnHeader
            // 
            this.columnHeader.Text = "Название";
            this.columnHeader.Width = 200;
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox, 2);
            this.groupBox.Controls.Add(this.infoTableLayoutPanel);
            this.groupBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox.Location = new System.Drawing.Point(268, 10);
            this.groupBox.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox.Name = "groupBox";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox, 2);
            this.groupBox.Size = new System.Drawing.Size(498, 345);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Информация";
            // 
            // infoTableLayoutPanel
            // 
            this.infoTableLayoutPanel.ColumnCount = 2;
            this.infoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.infoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.infoTableLayoutPanel.Controls.Add(this.infoLabel7, 0, 6);
            this.infoTableLayoutPanel.Controls.Add(this.infoLabel6, 0, 5);
            this.infoTableLayoutPanel.Controls.Add(this.infoLabel5, 0, 4);
            this.infoTableLayoutPanel.Controls.Add(this.infoLabel4, 0, 3);
            this.infoTableLayoutPanel.Controls.Add(this.infoLabel3, 0, 2);
            this.infoTableLayoutPanel.Controls.Add(this.infoLabel2, 0, 1);
            this.infoTableLayoutPanel.Controls.Add(this.toysListView, 0, 7);
            this.infoTableLayoutPanel.Controls.Add(this.infoLabel1, 0, 0);
            this.infoTableLayoutPanel.Location = new System.Drawing.Point(6, 25);
            this.infoTableLayoutPanel.Name = "infoTableLayoutPanel";
            this.infoTableLayoutPanel.RowCount = 10;
            this.infoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.262565F));
            this.infoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.262565F));
            this.infoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.262565F));
            this.infoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.894494F));
            this.infoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.894498F));
            this.infoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.894498F));
            this.infoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.894498F));
            this.infoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.894498F));
            this.infoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.98529F));
            this.infoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.75453F));
            this.infoTableLayoutPanel.Size = new System.Drawing.Size(486, 314);
            this.infoTableLayoutPanel.TabIndex = 0;
            // 
            // infoLabel7
            // 
            this.infoLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLabel7.AutoSize = true;
            this.infoTableLayoutPanel.SetColumnSpan(this.infoLabel7, 2);
            this.infoLabel7.Location = new System.Drawing.Point(3, 156);
            this.infoLabel7.Name = "infoLabel7";
            this.infoLabel7.Size = new System.Drawing.Size(480, 27);
            this.infoLabel7.TabIndex = 8;
            this.infoLabel7.Text = " ";
            // 
            // infoLabel6
            // 
            this.infoLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLabel6.AutoSize = true;
            this.infoTableLayoutPanel.SetColumnSpan(this.infoLabel6, 2);
            this.infoLabel6.Location = new System.Drawing.Point(3, 129);
            this.infoLabel6.Name = "infoLabel6";
            this.infoLabel6.Size = new System.Drawing.Size(480, 27);
            this.infoLabel6.TabIndex = 7;
            this.infoLabel6.Text = " ";
            // 
            // infoLabel5
            // 
            this.infoLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLabel5.AutoSize = true;
            this.infoTableLayoutPanel.SetColumnSpan(this.infoLabel5, 2);
            this.infoLabel5.Location = new System.Drawing.Point(3, 102);
            this.infoLabel5.Name = "infoLabel5";
            this.infoLabel5.Size = new System.Drawing.Size(480, 27);
            this.infoLabel5.TabIndex = 6;
            this.infoLabel5.Text = " ";
            // 
            // infoLabel4
            // 
            this.infoLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLabel4.AutoSize = true;
            this.infoTableLayoutPanel.SetColumnSpan(this.infoLabel4, 2);
            this.infoLabel4.Location = new System.Drawing.Point(3, 75);
            this.infoLabel4.Name = "infoLabel4";
            this.infoLabel4.Size = new System.Drawing.Size(480, 27);
            this.infoLabel4.TabIndex = 5;
            this.infoLabel4.Text = " ";
            // 
            // infoLabel3
            // 
            this.infoLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLabel3.AutoSize = true;
            this.infoTableLayoutPanel.SetColumnSpan(this.infoLabel3, 2);
            this.infoLabel3.Location = new System.Drawing.Point(3, 50);
            this.infoLabel3.Name = "infoLabel3";
            this.infoLabel3.Size = new System.Drawing.Size(480, 25);
            this.infoLabel3.TabIndex = 4;
            this.infoLabel3.Text = " ";
            // 
            // infoLabel2
            // 
            this.infoLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLabel2.AutoSize = true;
            this.infoTableLayoutPanel.SetColumnSpan(this.infoLabel2, 2);
            this.infoLabel2.Location = new System.Drawing.Point(3, 25);
            this.infoLabel2.Name = "infoLabel2";
            this.infoLabel2.Size = new System.Drawing.Size(480, 25);
            this.infoLabel2.TabIndex = 3;
            this.infoLabel2.Text = " ";
            // 
            // toysListView
            // 
            this.toysListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.toysListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toysListView.BackColor = System.Drawing.Color.PaleGreen;
            this.toysListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toysListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.toysListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toysListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.toysListView.Location = new System.Drawing.Point(10, 193);
            this.toysListView.Margin = new System.Windows.Forms.Padding(10);
            this.toysListView.Name = "toysListView";
            this.infoTableLayoutPanel.SetRowSpan(this.toysListView, 3);
            this.toysListView.Size = new System.Drawing.Size(263, 111);
            this.toysListView.TabIndex = 1;
            this.toysListView.UseCompatibleStateImageBehavior = false;
            this.toysListView.View = System.Windows.Forms.View.Details;
            this.toysListView.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название";
            this.columnHeader1.Width = 200;
            // 
            // infoLabel1
            // 
            this.infoLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLabel1.AutoSize = true;
            this.infoTableLayoutPanel.SetColumnSpan(this.infoLabel1, 2);
            this.infoLabel1.Location = new System.Drawing.Point(3, 0);
            this.infoLabel1.Name = "infoLabel1";
            this.infoLabel1.Size = new System.Drawing.Size(480, 25);
            this.infoLabel1.TabIndex = 2;
            this.infoLabel1.Text = " ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spectrum";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.infoTableLayoutPanel.ResumeLayout(false);
            this.infoTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ColumnHeader columnHeader;
        private System.Windows.Forms.TableLayoutPanel infoTableLayoutPanel;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ListView toysListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label infoLabel7;
        private System.Windows.Forms.Label infoLabel6;
        private System.Windows.Forms.Label infoLabel5;
        private System.Windows.Forms.Label infoLabel4;
        private System.Windows.Forms.Label infoLabel3;
        private System.Windows.Forms.Label infoLabel2;
        private System.Windows.Forms.Label infoLabel1;
    }
}
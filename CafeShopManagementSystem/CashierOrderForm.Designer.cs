
namespace CafeShopManagementSystem
{
    partial class CashierOrderForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierOrderForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cashierOrderForm_menuTable = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cashierOrderForm_clearBtn = new System.Windows.Forms.Button();
            this.cashierOrderForm_removeBtn = new System.Windows.Forms.Button();
            this.cashierOrderForm_addBtn = new System.Windows.Forms.Button();
            this.cashierOrderForm_price = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cashierOrderForm_quantity = new System.Windows.Forms.NumericUpDown();
            this.cashierOrderForm_prodName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cashierOrderForm_productID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cashierOrderForm_type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cashierOrderForm_receiptBtn = new System.Windows.Forms.Button();
            this.cashierOrderForm_payBtn = new System.Windows.Forms.Button();
            this.cashierOrderForm_change = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cashierOrderForm_amount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cashierOrderForm_orderPrice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cashierOrderForm_orderTable = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_menuTable)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_quantity)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_orderTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cashierOrderForm_menuTable);
            this.panel1.Location = new System.Drawing.Point(27, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 531);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu";
            // 
            // cashierOrderForm_menuTable
            // 
            this.cashierOrderForm_menuTable.AllowUserToAddRows = false;
            this.cashierOrderForm_menuTable.AllowUserToDeleteRows = false;
            this.cashierOrderForm_menuTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cashierOrderForm_menuTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cashierOrderForm_menuTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cashierOrderForm_menuTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cashierOrderForm_menuTable.EnableHeadersVisualStyles = false;
            this.cashierOrderForm_menuTable.Location = new System.Drawing.Point(24, 91);
            this.cashierOrderForm_menuTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cashierOrderForm_menuTable.Name = "cashierOrderForm_menuTable";
            this.cashierOrderForm_menuTable.ReadOnly = true;
            this.cashierOrderForm_menuTable.RowHeadersVisible = false;
            this.cashierOrderForm_menuTable.RowHeadersWidth = 62;
            this.cashierOrderForm_menuTable.Size = new System.Drawing.Size(1166, 408);
            this.cashierOrderForm_menuTable.TabIndex = 2;
            this.cashierOrderForm_menuTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cashierOrderForm_menuTable_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cashierOrderForm_clearBtn);
            this.panel2.Controls.Add(this.cashierOrderForm_removeBtn);
            this.panel2.Controls.Add(this.cashierOrderForm_addBtn);
            this.panel2.Controls.Add(this.cashierOrderForm_price);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cashierOrderForm_quantity);
            this.panel2.Controls.Add(this.cashierOrderForm_prodName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cashierOrderForm_productID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cashierOrderForm_type);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(27, 597);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1218, 512);
            this.panel2.TabIndex = 1;
            // 
            // cashierOrderForm_clearBtn
            // 
            this.cashierOrderForm_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(56)))), ((int)(((byte)(27)))));
            this.cashierOrderForm_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrderForm_clearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_clearBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrderForm_clearBtn.Location = new System.Drawing.Point(882, 391);
            this.cashierOrderForm_clearBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cashierOrderForm_clearBtn.Name = "cashierOrderForm_clearBtn";
            this.cashierOrderForm_clearBtn.Size = new System.Drawing.Size(291, 75);
            this.cashierOrderForm_clearBtn.TabIndex = 24;
            this.cashierOrderForm_clearBtn.Text = "RESET";
            this.cashierOrderForm_clearBtn.UseVisualStyleBackColor = false;
            this.cashierOrderForm_clearBtn.Click += new System.EventHandler(this.cashierOrderForm_clearBtn_Click_1);
            // 
            // cashierOrderForm_removeBtn
            // 
            this.cashierOrderForm_removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(56)))), ((int)(((byte)(27)))));
            this.cashierOrderForm_removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrderForm_removeBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_removeBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrderForm_removeBtn.Location = new System.Drawing.Point(428, 391);
            this.cashierOrderForm_removeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cashierOrderForm_removeBtn.Name = "cashierOrderForm_removeBtn";
            this.cashierOrderForm_removeBtn.Size = new System.Drawing.Size(291, 75);
            this.cashierOrderForm_removeBtn.TabIndex = 23;
            this.cashierOrderForm_removeBtn.Text = "HAPUS";
            this.cashierOrderForm_removeBtn.UseVisualStyleBackColor = false;
            this.cashierOrderForm_removeBtn.Click += new System.EventHandler(this.cashierOrderForm_removeBtn_Click);
            // 
            // cashierOrderForm_addBtn
            // 
            this.cashierOrderForm_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(56)))), ((int)(((byte)(27)))));
            this.cashierOrderForm_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrderForm_addBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_addBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrderForm_addBtn.Location = new System.Drawing.Point(40, 391);
            this.cashierOrderForm_addBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cashierOrderForm_addBtn.Name = "cashierOrderForm_addBtn";
            this.cashierOrderForm_addBtn.Size = new System.Drawing.Size(291, 75);
            this.cashierOrderForm_addBtn.TabIndex = 22;
            this.cashierOrderForm_addBtn.Text = "TAMBAH";
            this.cashierOrderForm_addBtn.UseVisualStyleBackColor = false;
            this.cashierOrderForm_addBtn.Click += new System.EventHandler(this.cashierOrderForm_addBtn_Click);
            // 
            // cashierOrderForm_price
            // 
            this.cashierOrderForm_price.AutoSize = true;
            this.cashierOrderForm_price.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_price.Location = new System.Drawing.Point(210, 262);
            this.cashierOrderForm_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cashierOrderForm_price.Name = "cashierOrderForm_price";
            this.cashierOrderForm_price.Size = new System.Drawing.Size(0, 27);
            this.cashierOrderForm_price.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(88, 262);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 27);
            this.label8.TabIndex = 20;
            this.label8.Text = "Price (Rp):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(664, 174);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 27);
            this.label6.TabIndex = 19;
            this.label6.Text = "Jumlah:";
            // 
            // cashierOrderForm_quantity
            // 
            this.cashierOrderForm_quantity.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_quantity.Location = new System.Drawing.Point(784, 163);
            this.cashierOrderForm_quantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cashierOrderForm_quantity.Name = "cashierOrderForm_quantity";
            this.cashierOrderForm_quantity.Size = new System.Drawing.Size(318, 40);
            this.cashierOrderForm_quantity.TabIndex = 18;
            // 
            // cashierOrderForm_prodName
            // 
            this.cashierOrderForm_prodName.AutoSize = true;
            this.cashierOrderForm_prodName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_prodName.Location = new System.Drawing.Point(210, 174);
            this.cashierOrderForm_prodName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cashierOrderForm_prodName.Name = "cashierOrderForm_prodName";
            this.cashierOrderForm_prodName.Size = new System.Drawing.Size(0, 27);
            this.cashierOrderForm_prodName.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 27);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nama Produk:";
            // 
            // cashierOrderForm_productID
            // 
            this.cashierOrderForm_productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_productID.FormattingEnabled = true;
            this.cashierOrderForm_productID.Location = new System.Drawing.Point(784, 58);
            this.cashierOrderForm_productID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cashierOrderForm_productID.Name = "cashierOrderForm_productID";
            this.cashierOrderForm_productID.Size = new System.Drawing.Size(316, 41);
            this.cashierOrderForm_productID.TabIndex = 15;
            this.cashierOrderForm_productID.SelectedIndexChanged += new System.EventHandler(this.cashierOrderForm_productID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(639, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "Produk ID:";
            // 
            // cashierOrderForm_type
            // 
            this.cashierOrderForm_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_type.FormattingEnabled = true;
            this.cashierOrderForm_type.Items.AddRange(new object[] {
            "Meal",
            "Drinks"});
            this.cashierOrderForm_type.Location = new System.Drawing.Point(214, 58);
            this.cashierOrderForm_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cashierOrderForm_type.Name = "cashierOrderForm_type";
            this.cashierOrderForm_type.Size = new System.Drawing.Size(316, 41);
            this.cashierOrderForm_type.TabIndex = 13;
            this.cashierOrderForm_type.SelectedIndexChanged += new System.EventHandler(this.cashierOrderForm_type_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tipe:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.cashierOrderForm_receiptBtn);
            this.panel3.Controls.Add(this.cashierOrderForm_payBtn);
            this.panel3.Controls.Add(this.cashierOrderForm_change);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.cashierOrderForm_amount);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cashierOrderForm_orderPrice);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.cashierOrderForm_orderTable);
            this.panel3.Location = new System.Drawing.Point(1272, 40);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(570, 1069);
            this.panel3.TabIndex = 2;
            // 
            // cashierOrderForm_receiptBtn
            // 
            this.cashierOrderForm_receiptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(56)))), ((int)(((byte)(27)))));
            this.cashierOrderForm_receiptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrderForm_receiptBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_receiptBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrderForm_receiptBtn.Location = new System.Drawing.Point(51, 962);
            this.cashierOrderForm_receiptBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cashierOrderForm_receiptBtn.Name = "cashierOrderForm_receiptBtn";
            this.cashierOrderForm_receiptBtn.Size = new System.Drawing.Size(465, 75);
            this.cashierOrderForm_receiptBtn.TabIndex = 30;
            this.cashierOrderForm_receiptBtn.Text = "STRUK";
            this.cashierOrderForm_receiptBtn.UseVisualStyleBackColor = false;
            this.cashierOrderForm_receiptBtn.Click += new System.EventHandler(this.cashierOrderForm_receiptBtn_Click);
            // 
            // cashierOrderForm_payBtn
            // 
            this.cashierOrderForm_payBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(56)))), ((int)(((byte)(27)))));
            this.cashierOrderForm_payBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrderForm_payBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_payBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrderForm_payBtn.Location = new System.Drawing.Point(51, 862);
            this.cashierOrderForm_payBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cashierOrderForm_payBtn.Name = "cashierOrderForm_payBtn";
            this.cashierOrderForm_payBtn.Size = new System.Drawing.Size(465, 75);
            this.cashierOrderForm_payBtn.TabIndex = 29;
            this.cashierOrderForm_payBtn.Text = "BAYAR";
            this.cashierOrderForm_payBtn.UseVisualStyleBackColor = false;
            this.cashierOrderForm_payBtn.Click += new System.EventHandler(this.cashierOrderForm_payBtn_Click);
            // 
            // cashierOrderForm_change
            // 
            this.cashierOrderForm_change.AutoSize = true;
            this.cashierOrderForm_change.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_change.Location = new System.Drawing.Point(320, 757);
            this.cashierOrderForm_change.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cashierOrderForm_change.Name = "cashierOrderForm_change";
            this.cashierOrderForm_change.Size = new System.Drawing.Size(26, 27);
            this.cashierOrderForm_change.TabIndex = 26;
            this.cashierOrderForm_change.Text = "0";
            this.cashierOrderForm_change.Click += new System.EventHandler(this.cashierOrderForm_change_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(121, 757);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 27);
            this.label13.TabIndex = 25;
            this.label13.Text = "Kembalian (Rp):";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // cashierOrderForm_amount
            // 
            this.cashierOrderForm_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_amount.Location = new System.Drawing.Point(324, 683);
            this.cashierOrderForm_amount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cashierOrderForm_amount.Name = "cashierOrderForm_amount";
            this.cashierOrderForm_amount.Size = new System.Drawing.Size(190, 35);
            this.cashierOrderForm_amount.TabIndex = 28;
            this.cashierOrderForm_amount.TextChanged += new System.EventHandler(this.cashierOrderForm_amount_TextChanged);
            this.cashierOrderForm_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cashierOrderForm_amount_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(172, 691);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 27);
            this.label11.TabIndex = 27;
            this.label11.Text = "Bayar (Rp):";
            // 
            // cashierOrderForm_orderPrice
            // 
            this.cashierOrderForm_orderPrice.AutoSize = true;
            this.cashierOrderForm_orderPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_orderPrice.Location = new System.Drawing.Point(320, 628);
            this.cashierOrderForm_orderPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cashierOrderForm_orderPrice.Name = "cashierOrderForm_orderPrice";
            this.cashierOrderForm_orderPrice.Size = new System.Drawing.Size(26, 27);
            this.cashierOrderForm_orderPrice.TabIndex = 26;
            this.cashierOrderForm_orderPrice.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(171, 628);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 27);
            this.label10.TabIndex = 25;
            this.label10.Text = "Harga (Rp):";
            // 
            // cashierOrderForm_orderTable
            // 
            this.cashierOrderForm_orderTable.AllowUserToAddRows = false;
            this.cashierOrderForm_orderTable.AllowUserToDeleteRows = false;
            this.cashierOrderForm_orderTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cashierOrderForm_orderTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cashierOrderForm_orderTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.cashierOrderForm_orderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cashierOrderForm_orderTable.EnableHeadersVisualStyles = false;
            this.cashierOrderForm_orderTable.Location = new System.Drawing.Point(28, 51);
            this.cashierOrderForm_orderTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cashierOrderForm_orderTable.Name = "cashierOrderForm_orderTable";
            this.cashierOrderForm_orderTable.ReadOnly = true;
            this.cashierOrderForm_orderTable.RowHeadersVisible = false;
            this.cashierOrderForm_orderTable.RowHeadersWidth = 62;
            this.cashierOrderForm_orderTable.Size = new System.Drawing.Size(519, 514);
            this.cashierOrderForm_orderTable.TabIndex = 4;
            this.cashierOrderForm_orderTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cashierOrderForm_orderTable_CellClick);
            this.cashierOrderForm_orderTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cashierOrderForm_orderTable_CellContentClick);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // CashierOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CashierOrderForm";
            this.Size = new System.Drawing.Size(1876, 1146);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_menuTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_quantity)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_orderTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView cashierOrderForm_menuTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cashierOrderForm_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cashierOrderForm_productID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cashierOrderForm_prodName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown cashierOrderForm_quantity;
        private System.Windows.Forms.Label cashierOrderForm_price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cashierOrderForm_addBtn;
        private System.Windows.Forms.Button cashierOrderForm_removeBtn;
        private System.Windows.Forms.Button cashierOrderForm_clearBtn;
        private System.Windows.Forms.Label cashierOrderForm_orderPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView cashierOrderForm_orderTable;
        private System.Windows.Forms.TextBox cashierOrderForm_amount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label cashierOrderForm_change;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button cashierOrderForm_payBtn;
        private System.Windows.Forms.Button cashierOrderForm_receiptBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

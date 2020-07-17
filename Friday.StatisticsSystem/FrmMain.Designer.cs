namespace Friday.StatisticsSystem
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.rtxtLog = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNetworkHostOne = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNetworkPortOne = new System.Windows.Forms.TextBox();
            this.btnConnectOne = new System.Windows.Forms.Button();
            this.btnDisconnectOne = new System.Windows.Forms.Button();
            this.btnSaveConfigOne = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNetworkHostTwo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNetworkPortTwo = new System.Windows.Forms.TextBox();
            this.btnDisconnectTwo = new System.Windows.Forms.Button();
            this.btnConnectTwo = new System.Windows.Forms.Button();
            this.btnSaveConfigTwo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtReadOK = new System.Windows.Forms.TextBox();
            this.txtReadNG = new System.Windows.Forms.TextBox();
            this.txtReadAll = new System.Windows.Forms.TextBox();
            this.txtReadRatio = new System.Windows.Forms.TextBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.colIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 3;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMain.Controls.Add(this.rtxtLog, 0, 2);
            this.tableMain.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableMain.Controls.Add(this.dgvData, 2, 2);
            this.tableMain.Controls.Add(this.label5, 0, 1);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(5, 5);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 3;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Size = new System.Drawing.Size(1119, 693);
            this.tableMain.TabIndex = 0;
            // 
            // rtxtLog
            // 
            this.rtxtLog.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtxtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtLog.Location = new System.Drawing.Point(3, 109);
            this.rtxtLog.Name = "rtxtLog";
            this.rtxtLog.ReadOnly = true;
            this.rtxtLog.Size = new System.Drawing.Size(552, 581);
            this.rtxtLog.TabIndex = 13;
            this.rtxtLog.Text = "";
            this.rtxtLog.WordWrap = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 22;
            this.tableMain.SetColumnSpan(this.tableLayoutPanel1, 3);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.Controls.Add(this.txtNetworkHostOne, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNetworkPortOne, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnConnectOne, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDisconnectOne, 11, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSaveConfigOne, 13, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNetworkHostTwo, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNetworkPortTwo, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDisconnectTwo, 11, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnConnectTwo, 9, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSaveConfigTwo, 13, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 15, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 19, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 15, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 19, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtReadOK, 17, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtReadNG, 21, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtReadAll, 17, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtReadRatio, 21, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1113, 60);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // txtNetworkHostOne
            // 
            this.txtNetworkHostOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNetworkHostOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNetworkHostOne.Location = new System.Drawing.Point(218, 3);
            this.txtNetworkHostOne.Name = "txtNetworkHostOne";
            this.txtNetworkHostOne.Size = new System.Drawing.Size(94, 21);
            this.txtNetworkHostOne.TabIndex = 3;
            this.txtNetworkHostOne.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("SimSun", 9F);
            this.label2.Location = new System.Drawing.Point(323, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "网络端口";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNetworkPortOne
            // 
            this.txtNetworkPortOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNetworkPortOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNetworkPortOne.Location = new System.Drawing.Point(388, 3);
            this.txtNetworkPortOne.Name = "txtNetworkPortOne";
            this.txtNetworkPortOne.Size = new System.Drawing.Size(54, 21);
            this.txtNetworkPortOne.TabIndex = 3;
            // 
            // btnConnectOne
            // 
            this.btnConnectOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnectOne.Location = new System.Drawing.Point(453, 3);
            this.btnConnectOne.Name = "btnConnectOne";
            this.btnConnectOne.Size = new System.Drawing.Size(108, 21);
            this.btnConnectOne.TabIndex = 4;
            this.btnConnectOne.Text = "连接";
            this.btnConnectOne.UseVisualStyleBackColor = true;
            this.btnConnectOne.Click += new System.EventHandler(this.btnConnectOne_Click);
            // 
            // btnDisconnectOne
            // 
            this.btnDisconnectOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDisconnectOne.Location = new System.Drawing.Point(572, 3);
            this.btnDisconnectOne.Name = "btnDisconnectOne";
            this.btnDisconnectOne.Size = new System.Drawing.Size(108, 21);
            this.btnDisconnectOne.TabIndex = 4;
            this.btnDisconnectOne.Text = "断开";
            this.btnDisconnectOne.UseVisualStyleBackColor = true;
            this.btnDisconnectOne.Click += new System.EventHandler(this.btnDisconnectOne_Click);
            // 
            // btnSaveConfigOne
            // 
            this.btnSaveConfigOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveConfigOne.Location = new System.Drawing.Point(691, 3);
            this.btnSaveConfigOne.Name = "btnSaveConfigOne";
            this.btnSaveConfigOne.Size = new System.Drawing.Size(108, 21);
            this.btnSaveConfigOne.TabIndex = 4;
            this.btnSaveConfigOne.Text = "保存配置";
            this.btnSaveConfigOne.UseVisualStyleBackColor = true;
            this.btnSaveConfigOne.Click += new System.EventHandler(this.btnSaveConfigOne_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("SimSun", 9F);
            this.label3.Location = new System.Drawing.Point(153, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "网络地址";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNetworkHostTwo
            // 
            this.txtNetworkHostTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNetworkHostTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNetworkHostTwo.Location = new System.Drawing.Point(218, 35);
            this.txtNetworkHostTwo.Name = "txtNetworkHostTwo";
            this.txtNetworkHostTwo.Size = new System.Drawing.Size(94, 21);
            this.txtNetworkHostTwo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("SimSun", 9F);
            this.label4.Location = new System.Drawing.Point(323, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "网络端口";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNetworkPortTwo
            // 
            this.txtNetworkPortTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNetworkPortTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNetworkPortTwo.Location = new System.Drawing.Point(388, 35);
            this.txtNetworkPortTwo.Name = "txtNetworkPortTwo";
            this.txtNetworkPortTwo.Size = new System.Drawing.Size(54, 21);
            this.txtNetworkPortTwo.TabIndex = 3;
            // 
            // btnDisconnectTwo
            // 
            this.btnDisconnectTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDisconnectTwo.Location = new System.Drawing.Point(572, 35);
            this.btnDisconnectTwo.Name = "btnDisconnectTwo";
            this.btnDisconnectTwo.Size = new System.Drawing.Size(108, 22);
            this.btnDisconnectTwo.TabIndex = 4;
            this.btnDisconnectTwo.Text = "断开";
            this.btnDisconnectTwo.UseVisualStyleBackColor = true;
            this.btnDisconnectTwo.Click += new System.EventHandler(this.btnDisconnectTwo_Click);
            // 
            // btnConnectTwo
            // 
            this.btnConnectTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnectTwo.Location = new System.Drawing.Point(453, 35);
            this.btnConnectTwo.Name = "btnConnectTwo";
            this.btnConnectTwo.Size = new System.Drawing.Size(108, 22);
            this.btnConnectTwo.TabIndex = 4;
            this.btnConnectTwo.Text = "连接";
            this.btnConnectTwo.UseVisualStyleBackColor = true;
            this.btnConnectTwo.Click += new System.EventHandler(this.btnConnectTwo_Click);
            // 
            // btnSaveConfigTwo
            // 
            this.btnSaveConfigTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveConfigTwo.Location = new System.Drawing.Point(691, 35);
            this.btnSaveConfigTwo.Name = "btnSaveConfigTwo";
            this.btnSaveConfigTwo.Size = new System.Drawing.Size(108, 22);
            this.btnSaveConfigTwo.TabIndex = 4;
            this.btnSaveConfigTwo.Text = "保存配置";
            this.btnSaveConfigTwo.UseVisualStyleBackColor = true;
            this.btnSaveConfigTwo.Click += new System.EventHandler(this.btnSaveConfigTwo_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("SimSun", 9F);
            this.label1.Location = new System.Drawing.Point(153, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "网络地址";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("SimSun", 9F);
            this.label6.Location = new System.Drawing.Point(810, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 27);
            this.label6.TabIndex = 2;
            this.label6.Text = "读取成功";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("SimSun", 9F);
            this.label7.Location = new System.Drawing.Point(960, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 27);
            this.label7.TabIndex = 2;
            this.label7.Text = "读取失败";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("SimSun", 9F);
            this.label8.Location = new System.Drawing.Point(810, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 28);
            this.label8.TabIndex = 2;
            this.label8.Text = "读取总量";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("SimSun", 9F);
            this.label9.Location = new System.Drawing.Point(960, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 28);
            this.label9.TabIndex = 2;
            this.label9.Text = "读取比例";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtReadOK
            // 
            this.txtReadOK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReadOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReadOK.Location = new System.Drawing.Point(875, 3);
            this.txtReadOK.Name = "txtReadOK";
            this.txtReadOK.Size = new System.Drawing.Size(74, 21);
            this.txtReadOK.TabIndex = 3;
            // 
            // txtReadNG
            // 
            this.txtReadNG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReadNG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReadNG.Location = new System.Drawing.Point(1025, 3);
            this.txtReadNG.Name = "txtReadNG";
            this.txtReadNG.Size = new System.Drawing.Size(85, 21);
            this.txtReadNG.TabIndex = 3;
            // 
            // txtReadAll
            // 
            this.txtReadAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReadAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReadAll.Location = new System.Drawing.Point(875, 35);
            this.txtReadAll.Name = "txtReadAll";
            this.txtReadAll.Size = new System.Drawing.Size(74, 21);
            this.txtReadAll.TabIndex = 3;
            // 
            // txtReadRatio
            // 
            this.txtReadRatio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReadRatio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReadRatio.Location = new System.Drawing.Point(1025, 35);
            this.txtReadRatio.Name = "txtReadRatio";
            this.txtReadRatio.Size = new System.Drawing.Size(85, 21);
            this.txtReadRatio.TabIndex = 3;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvData.ColumnHeadersHeight = 40;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIndex,
            this.colBarcode,
            this.colTime});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(564, 109);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvData.RowHeadersVisible = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(196)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(196)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvData.RowTemplate.Height = 30;
            this.dgvData.Size = new System.Drawing.Size(552, 581);
            this.dgvData.TabIndex = 12;
            // 
            // colIndex
            // 
            this.colIndex.DataPropertyName = "BoxIndex";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.colIndex.DefaultCellStyle = dataGridViewCellStyle11;
            this.colIndex.Frozen = true;
            this.colIndex.HeaderText = "INDEX";
            this.colIndex.MinimumWidth = 60;
            this.colIndex.Name = "colIndex";
            this.colIndex.ReadOnly = true;
            this.colIndex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colIndex.Width = 80;
            // 
            // colBarcode
            // 
            this.colBarcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBarcode.DataPropertyName = "Barcode";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.colBarcode.DefaultCellStyle = dataGridViewCellStyle12;
            this.colBarcode.HeaderText = "BARCODE";
            this.colBarcode.Name = "colBarcode";
            this.colBarcode.ReadOnly = true;
            this.colBarcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTime
            // 
            this.colTime.DataPropertyName = "Time";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.Format = "G";
            dataGridViewCellStyle13.NullValue = null;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.colTime.DefaultCellStyle = dataGridViewCellStyle13;
            this.colTime.HeaderText = "TIME";
            this.colTime.MinimumWidth = 150;
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            this.colTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTime.Width = 150;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SlateGray;
            this.tableMain.SetColumnSpan(this.label5, 4);
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(3, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1113, 40);
            this.label5.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Friday.StatisticsSystem.Properties.Resources.Friday;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 3);
            this.pictureBox1.Size = new System.Drawing.Size(144, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1129, 703);
            this.Controls.Add(this.tableMain);
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "读码统计系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tableMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.RichTextBox rtxtLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtNetworkHostOne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNetworkPortOne;
        private System.Windows.Forms.Button btnConnectOne;
        private System.Windows.Forms.Button btnDisconnectOne;
        private System.Windows.Forms.Button btnSaveConfigOne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNetworkHostTwo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNetworkPortTwo;
        private System.Windows.Forms.Button btnDisconnectTwo;
        private System.Windows.Forms.Button btnConnectTwo;
        private System.Windows.Forms.Button btnSaveConfigTwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtReadOK;
        private System.Windows.Forms.TextBox txtReadNG;
        private System.Windows.Forms.TextBox txtReadAll;
        private System.Windows.Forms.TextBox txtReadRatio;
    }
}


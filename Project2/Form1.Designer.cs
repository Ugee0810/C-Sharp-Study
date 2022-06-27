namespace Project2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.gb = new System.Windows.Forms.GroupBox();
            this.nAge = new System.Windows.Forms.NumericUpDown();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbHp = new System.Windows.Forms.Label();
            this.txtHp = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbUid = new System.Windows.Forms.Label();
            this.txtUid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAge)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(400, 256);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelect.Location = new System.Drawing.Point(418, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(202, 30);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "조 회";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // gb
            // 
            this.gb.Controls.Add(this.nAge);
            this.gb.Controls.Add(this.btnReset);
            this.gb.Controls.Add(this.btnDelete);
            this.gb.Controls.Add(this.btnUpdate);
            this.gb.Controls.Add(this.btnInsert);
            this.gb.Controls.Add(this.lbAge);
            this.gb.Controls.Add(this.lbHp);
            this.gb.Controls.Add(this.txtHp);
            this.gb.Controls.Add(this.lbName);
            this.gb.Controls.Add(this.txtName);
            this.gb.Controls.Add(this.lbUid);
            this.gb.Controls.Add(this.txtUid);
            this.gb.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb.Location = new System.Drawing.Point(420, 48);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(200, 220);
            this.gb.TabIndex = 2;
            this.gb.TabStop = false;
            this.gb.Text = "데이터 추가/수정/삭제";
            // 
            // nAge
            // 
            this.nAge.Location = new System.Drawing.Point(63, 117);
            this.nAge.Name = "nAge";
            this.nAge.Size = new System.Drawing.Size(120, 25);
            this.nAge.TabIndex = 11;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(103, 183);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 30);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "리셋";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(6, 183);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(103, 147);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 30);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInsert.Location = new System.Drawing.Point(6, 147);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(80, 30);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "추가";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAge.Location = new System.Drawing.Point(6, 119);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(37, 19);
            this.lbAge.TabIndex = 6;
            this.lbAge.Text = "나이";
            // 
            // lbHp
            // 
            this.lbHp.AutoSize = true;
            this.lbHp.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHp.Location = new System.Drawing.Point(6, 88);
            this.lbHp.Name = "lbHp";
            this.lbHp.Size = new System.Drawing.Size(51, 19);
            this.lbHp.TabIndex = 4;
            this.lbHp.Text = "휴대폰";
            // 
            // txtHp
            // 
            this.txtHp.Location = new System.Drawing.Point(63, 85);
            this.txtHp.Name = "txtHp";
            this.txtHp.Size = new System.Drawing.Size(120, 25);
            this.txtHp.TabIndex = 5;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(6, 57);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(37, 19);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "이름";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(63, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 25);
            this.txtName.TabIndex = 3;
            // 
            // lbUid
            // 
            this.lbUid.AutoSize = true;
            this.lbUid.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUid.Location = new System.Drawing.Point(6, 26);
            this.lbUid.Name = "lbUid";
            this.lbUid.Size = new System.Drawing.Size(51, 19);
            this.lbUid.TabIndex = 0;
            this.lbUid.Text = "아이디";
            // 
            // txtUid
            // 
            this.txtUid.Location = new System.Drawing.Point(63, 23);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(120, 25);
            this.txtUid.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 281);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnSelect;

        private GroupBox gb;
        private Label lbUid;
        private Label lbName;
        private Label lbHp;
        private Label lbAge;

        private TextBox txtUid;
        private TextBox txtName;
        private TextBox txtHp;
        private NumericUpDown nAge;

        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnReset;
    }
}
//namespace Ch11
//{
//    partial class Form2
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.label1 = new System.Windows.Forms.Label();
//            this.lbTitle5 = new System.Windows.Forms.Label();
//            this.cbPosition = new System.Windows.Forms.ComboBox();
//            this.lbPosition = new System.Windows.Forms.Label();
//            this.btnPosition = new System.Windows.Forms.Button();
//            this.lbResultPosition = new System.Windows.Forms.Label();
//            this.lbResultHobby = new System.Windows.Forms.Label();
//            this.btnHobby = new System.Windows.Forms.Button();
//            this.lbHobby = new System.Windows.Forms.Label();
//            this.cbHobby = new System.Windows.Forms.ComboBox();
//            this.lbTitle6 = new System.Windows.Forms.Label();
//            this.lstCountry = new System.Windows.Forms.ListBox();
//            this.lbResultCountry = new System.Windows.Forms.Label();
//            this.label2 = new System.Windows.Forms.Label();
//            this.dgvMember = new System.Windows.Forms.DataGridView();
//            this.btnForm3 = new System.Windows.Forms.Button();
//            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
//            this.label1.Location = new System.Drawing.Point(12, 9);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(305, 28);
//            this.label1.TabIndex = 0;
//            this.label1.Text = "#데이터를 공급해야 하는 컨트롤";
//            // 
//            // lbTitle5
//            // 
//            this.lbTitle5.AutoSize = true;
//            this.lbTitle5.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
//            this.lbTitle5.Location = new System.Drawing.Point(12, 37);
//            this.lbTitle5.Name = "lbTitle5";
//            this.lbTitle5.Size = new System.Drawing.Size(175, 28);
//            this.lbTitle5.TabIndex = 1;
//            this.lbTitle5.Text = "#ComboBox 연습";
//            // 
//            // cbPosition
//            // 
//            this.cbPosition.FormattingEnabled = true;
//            this.cbPosition.Location = new System.Drawing.Point(57, 68);
//            this.cbPosition.Name = "cbPosition";
//            this.cbPosition.Size = new System.Drawing.Size(121, 23);
//            this.cbPosition.TabIndex = 2;
//            // 
//            // lbPosition
//            // 
//            this.lbPosition.AutoSize = true;
//            this.lbPosition.Location = new System.Drawing.Point(12, 71);
//            this.lbPosition.Name = "lbPosition";
//            this.lbPosition.Size = new System.Drawing.Size(31, 15);
//            this.lbPosition.TabIndex = 3;
//            this.lbPosition.Text = "직급";
//            // 
//            // btnPosition
//            // 
//            this.btnPosition.Location = new System.Drawing.Point(184, 68);
//            this.btnPosition.Name = "btnPosition";
//            this.btnPosition.Size = new System.Drawing.Size(75, 23);
//            this.btnPosition.TabIndex = 4;
//            this.btnPosition.Text = "확인";
//            this.btnPosition.UseVisualStyleBackColor = true;
//            this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
//            // 
//            // lbResultPosition
//            // 
//            this.lbResultPosition.AutoSize = true;
//            this.lbResultPosition.Location = new System.Drawing.Point(265, 72);
//            this.lbResultPosition.Name = "lbResultPosition";
//            this.lbResultPosition.Size = new System.Drawing.Size(42, 15);
//            this.lbResultPosition.TabIndex = 5;
//            this.lbResultPosition.Text = "결과 : ";
//            // 
//            // lbResultHobby
//            // 
//            this.lbResultHobby.AutoSize = true;
//            this.lbResultHobby.Location = new System.Drawing.Point(265, 101);
//            this.lbResultHobby.Name = "lbResultHobby";
//            this.lbResultHobby.Size = new System.Drawing.Size(42, 15);
//            this.lbResultHobby.TabIndex = 9;
//            this.lbResultHobby.Text = "결과 : ";
//            // 
//            // btnHobby
//            // 
//            this.btnHobby.Location = new System.Drawing.Point(184, 97);
//            this.btnHobby.Name = "btnHobby";
//            this.btnHobby.Size = new System.Drawing.Size(75, 23);
//            this.btnHobby.TabIndex = 8;
//            this.btnHobby.Text = "확인";
//            this.btnHobby.UseVisualStyleBackColor = true;
//            this.btnHobby.Click += new System.EventHandler(this.btnHobby_Click);
//            // 
//            // lbHobby
//            // 
//            this.lbHobby.AutoSize = true;
//            this.lbHobby.Location = new System.Drawing.Point(12, 100);
//            this.lbHobby.Name = "lbHobby";
//            this.lbHobby.Size = new System.Drawing.Size(31, 15);
//            this.lbHobby.TabIndex = 7;
//            this.lbHobby.Text = "취미";
//            // 
//            // cbHobby
//            // 
//            this.cbHobby.FormattingEnabled = true;
//            this.cbHobby.Location = new System.Drawing.Point(57, 97);
//            this.cbHobby.Name = "cbHobby";
//            this.cbHobby.Size = new System.Drawing.Size(121, 23);
//            this.cbHobby.TabIndex = 6;
//            // 
//            // lbTitle6
//            // 
//            this.lbTitle6.AutoSize = true;
//            this.lbTitle6.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
//            this.lbTitle6.Location = new System.Drawing.Point(12, 123);
//            this.lbTitle6.Name = "lbTitle6";
//            this.lbTitle6.Size = new System.Drawing.Size(175, 28);
//            this.lbTitle6.TabIndex = 10;
//            this.lbTitle6.Text = "#ComboBox 연습";
//            // 
//            // lstCountry
//            // 
//            this.lstCountry.FormattingEnabled = true;
//            this.lstCountry.ItemHeight = 15;
//            this.lstCountry.Location = new System.Drawing.Point(12, 154);
//            this.lstCountry.Name = "lstCountry";
//            this.lstCountry.Size = new System.Drawing.Size(120, 94);
//            this.lstCountry.TabIndex = 11;
//            this.lstCountry.SelectedIndexChanged += new System.EventHandler(this.lstCountry_SelectedIndexChanged);
//            // 
//            // lbResultCountry
//            // 
//            this.lbResultCountry.AutoSize = true;
//            this.lbResultCountry.Location = new System.Drawing.Point(138, 233);
//            this.lbResultCountry.Name = "lbResultCountry";
//            this.lbResultCountry.Size = new System.Drawing.Size(42, 15);
//            this.lbResultCountry.TabIndex = 12;
//            this.lbResultCountry.Text = "결과 : ";
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
//            this.label2.Location = new System.Drawing.Point(12, 251);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(201, 28);
//            this.label2.TabIndex = 13;
//            this.label2.Text = "#DataGridView 연습";
//            // 
//            // dgvMember
//            // 
//            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dgvMember.Location = new System.Drawing.Point(12, 282);
//            this.dgvMember.Name = "dgvMember";
//            this.dgvMember.RowTemplate.Height = 25;
//            this.dgvMember.Size = new System.Drawing.Size(522, 150);
//            this.dgvMember.TabIndex = 14;
//            // 
//            // btnForm3
//            // 
//            this.btnForm3.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
//            this.btnForm3.Location = new System.Drawing.Point(12, 449);
//            this.btnForm3.Name = "btnForm3";
//            this.btnForm3.Size = new System.Drawing.Size(522, 50);
//            this.btnForm3.TabIndex = 15;
//            this.btnForm3.Text = "Form3 열기";
//            this.btnForm3.UseVisualStyleBackColor = true;
//            this.btnForm3.Click += new System.EventHandler(this.btnForm3_Click);
//            // 
//            // Form2
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(546, 541);
//            this.Controls.Add(this.btnForm3);
//            this.Controls.Add(this.dgvMember);
//            this.Controls.Add(this.label2);
//            this.Controls.Add(this.lbResultCountry);
//            this.Controls.Add(this.lstCountry);
//            this.Controls.Add(this.lbTitle6);
//            this.Controls.Add(this.lbResultHobby);
//            this.Controls.Add(this.btnHobby);
//            this.Controls.Add(this.lbHobby);
//            this.Controls.Add(this.cbHobby);
//            this.Controls.Add(this.lbResultPosition);
//            this.Controls.Add(this.btnPosition);
//            this.Controls.Add(this.lbPosition);
//            this.Controls.Add(this.cbPosition);
//            this.Controls.Add(this.lbTitle5);
//            this.Controls.Add(this.label1);
//            this.Name = "Form2";
//            this.Text = "Form2";
//            this.Load += new System.EventHandler(this.Form2_Load);
//            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private Label label1;
//        //ComboBox 연습
//        private Label lbTitle5;
//        //직급
//        private Label    lbPosition;
//        private ComboBox cbPosition;
//        private Button   btnPosition;
//        private Label    lbResultPosition;
//        //취미
//        private Label    lbHobby;
//        private ComboBox cbHobby;
//        private Button   btnHobby;
//        private Label    lbResultHobby;

//        //ListBox 연습
//        private Label   lbTitle6;
//        private ListBox lstCountry;
//        private Label   lbResultCountry;
//        private Label label2;
//        private DataGridView dgvMember;

//        //Form3
//        private Button btnForm3;
//    }
//}
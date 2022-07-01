namespace Ch11
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
            this.lbTitle1 = new System.Windows.Forms.Label();
            this.lbTitle2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.lbUid = new System.Windows.Forms.Label();
            this.btnUid = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.btnHp = new System.Windows.Forms.Button();
            this.lbHp = new System.Windows.Forms.Label();
            this.txtHp = new System.Windows.Forms.TextBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.lbTitle3 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.chbFruit1 = new System.Windows.Forms.CheckBox();
            this.chbFruit2 = new System.Windows.Forms.CheckBox();
            this.chbFruit3 = new System.Windows.Forms.CheckBox();
            this.chbFruit4 = new System.Windows.Forms.CheckBox();
            this.chbFruit5 = new System.Windows.Forms.CheckBox();
            this.btnFruit = new System.Windows.Forms.Button();
            this.lbResultFruit = new System.Windows.Forms.Label();
            this.lbTitle4 = new System.Windows.Forms.Label();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdYear2 = new System.Windows.Forms.RadioButton();
            this.rdYear1 = new System.Windows.Forms.RadioButton();
            this.rdYear4 = new System.Windows.Forms.RadioButton();
            this.rdYear3 = new System.Windows.Forms.RadioButton();
            this.btnGender = new System.Windows.Forms.Button();
            this.btnYear = new System.Windows.Forms.Button();
            this.lbResultGender = new System.Windows.Forms.Label();
            this.lbResultYear = new System.Windows.Forms.Label();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.gbYear = new System.Windows.Forms.GroupBox();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.btnForm5 = new System.Windows.Forms.Button();
            this.gbGender.SuspendLayout();
            this.gbYear.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle1
            // 
            this.lbTitle1.AutoSize = true;
            this.lbTitle1.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle1.Location = new System.Drawing.Point(12, 9);
            this.lbTitle1.Name = "lbTitle1";
            this.lbTitle1.Size = new System.Drawing.Size(156, 28);
            this.lbTitle1.TabIndex = 0;
            this.lbTitle1.Text = "#Button 컨트롤";
            // 
            // lbTitle2
            // 
            this.lbTitle2.AutoSize = true;
            this.lbTitle2.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle2.Location = new System.Drawing.Point(12, 66);
            this.lbTitle2.Name = "lbTitle2";
            this.lbTitle2.Size = new System.Drawing.Size(169, 28);
            this.lbTitle2.TabIndex = 1;
            this.lbTitle2.Text = "#TextBox 컨트롤";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb1.Location = new System.Drawing.Point(12, 94);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(51, 19);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "아이디";
            // 
            // txtUid
            // 
            this.txtUid.Location = new System.Drawing.Point(69, 94);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(100, 23);
            this.txtUid.TabIndex = 3;
            // 
            // lbUid
            // 
            this.lbUid.AutoSize = true;
            this.lbUid.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUid.Location = new System.Drawing.Point(256, 96);
            this.lbUid.Name = "lbUid";
            this.lbUid.Size = new System.Drawing.Size(51, 19);
            this.lbUid.TabIndex = 4;
            this.lbUid.Text = "결과 : ";
            // 
            // btnUid
            // 
            this.btnUid.Location = new System.Drawing.Point(175, 94);
            this.btnUid.Name = "btnUid";
            this.btnUid.Size = new System.Drawing.Size(75, 23);
            this.btnUid.TabIndex = 5;
            this.btnUid.Text = "확인";
            this.btnUid.UseVisualStyleBackColor = true;
            this.btnUid.Click += new System.EventHandler(this.btnUid_Click);
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(175, 123);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(75, 23);
            this.btnName.TabIndex = 9;
            this.btnName.Text = "확인";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(256, 125);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(51, 19);
            this.lbName.TabIndex = 8;
            this.lbName.Text = "결과 : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(69, 123);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 7;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb2.Location = new System.Drawing.Point(12, 123);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(37, 19);
            this.lb2.TabIndex = 6;
            this.lb2.Text = "이름";
            // 
            // btnHp
            // 
            this.btnHp.Location = new System.Drawing.Point(175, 152);
            this.btnHp.Name = "btnHp";
            this.btnHp.Size = new System.Drawing.Size(75, 23);
            this.btnHp.TabIndex = 13;
            this.btnHp.Text = "확인";
            this.btnHp.UseVisualStyleBackColor = true;
            this.btnHp.Click += new System.EventHandler(this.btnHp_Click);
            // 
            // lbHp
            // 
            this.lbHp.AutoSize = true;
            this.lbHp.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbHp.Location = new System.Drawing.Point(256, 154);
            this.lbHp.Name = "lbHp";
            this.lbHp.Size = new System.Drawing.Size(51, 19);
            this.lbHp.TabIndex = 12;
            this.lbHp.Text = "결과 : ";
            // 
            // txtHp
            // 
            this.txtHp.Location = new System.Drawing.Point(69, 152);
            this.txtHp.Name = "txtHp";
            this.txtHp.Size = new System.Drawing.Size(100, 23);
            this.txtHp.TabIndex = 11;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb3.Location = new System.Drawing.Point(12, 152);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(51, 19);
            this.lb3.TabIndex = 10;
            this.lb3.Text = "휴대폰";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 40);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 14;
            this.btn1.Text = "버튼1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(93, 40);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 15;
            this.btn2.Text = "버튼2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(174, 40);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 16;
            this.btn3.Text = "버튼3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(255, 40);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 17;
            this.btn4.Text = "버튼4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // lbTitle3
            // 
            this.lbTitle3.AutoSize = true;
            this.lbTitle3.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle3.Location = new System.Drawing.Point(12, 178);
            this.lbTitle3.Name = "lbTitle3";
            this.lbTitle3.Size = new System.Drawing.Size(184, 28);
            this.lbTitle3.TabIndex = 18;
            this.lbTitle3.Text = "#CheckBox 컨트롤";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb4.Location = new System.Drawing.Point(12, 206);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(210, 19);
            this.lb4.TabIndex = 19;
            this.lb4.Text = "좋아하는 과일을 모두 고르세요.";
            // 
            // chbFruit1
            // 
            this.chbFruit1.AutoSize = true;
            this.chbFruit1.Location = new System.Drawing.Point(12, 228);
            this.chbFruit1.Name = "chbFruit1";
            this.chbFruit1.Size = new System.Drawing.Size(50, 19);
            this.chbFruit1.TabIndex = 20;
            this.chbFruit1.Text = "사과";
            this.chbFruit1.UseVisualStyleBackColor = true;
            // 
            // chbFruit2
            // 
            this.chbFruit2.AutoSize = true;
            this.chbFruit2.Location = new System.Drawing.Point(60, 228);
            this.chbFruit2.Name = "chbFruit2";
            this.chbFruit2.Size = new System.Drawing.Size(50, 19);
            this.chbFruit2.TabIndex = 21;
            this.chbFruit2.Text = "딸기";
            this.chbFruit2.UseVisualStyleBackColor = true;
            // 
            // chbFruit3
            // 
            this.chbFruit3.AutoSize = true;
            this.chbFruit3.Location = new System.Drawing.Point(116, 228);
            this.chbFruit3.Name = "chbFruit3";
            this.chbFruit3.Size = new System.Drawing.Size(50, 19);
            this.chbFruit3.TabIndex = 22;
            this.chbFruit3.Text = "포도";
            this.chbFruit3.UseVisualStyleBackColor = true;
            // 
            // chbFruit4
            // 
            this.chbFruit4.AutoSize = true;
            this.chbFruit4.Location = new System.Drawing.Point(172, 228);
            this.chbFruit4.Name = "chbFruit4";
            this.chbFruit4.Size = new System.Drawing.Size(50, 19);
            this.chbFruit4.TabIndex = 23;
            this.chbFruit4.Text = "수박";
            this.chbFruit4.UseVisualStyleBackColor = true;
            // 
            // chbFruit5
            // 
            this.chbFruit5.AutoSize = true;
            this.chbFruit5.Location = new System.Drawing.Point(228, 228);
            this.chbFruit5.Name = "chbFruit5";
            this.chbFruit5.Size = new System.Drawing.Size(62, 19);
            this.chbFruit5.TabIndex = 24;
            this.chbFruit5.Text = "바나나";
            this.chbFruit5.UseVisualStyleBackColor = true;
            // 
            // btnFruit
            // 
            this.btnFruit.Location = new System.Drawing.Point(12, 253);
            this.btnFruit.Name = "btnFruit";
            this.btnFruit.Size = new System.Drawing.Size(75, 23);
            this.btnFruit.TabIndex = 25;
            this.btnFruit.Text = "확인";
            this.btnFruit.UseVisualStyleBackColor = true;
            this.btnFruit.Click += new System.EventHandler(this.btnFruit_Click);
            // 
            // lbResultFruit
            // 
            this.lbResultFruit.AutoSize = true;
            this.lbResultFruit.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbResultFruit.Location = new System.Drawing.Point(93, 256);
            this.lbResultFruit.Name = "lbResultFruit";
            this.lbResultFruit.Size = new System.Drawing.Size(98, 19);
            this.lbResultFruit.TabIndex = 26;
            this.lbResultFruit.Text = "선택한 과일 : ";
            // 
            // lbTitle4
            // 
            this.lbTitle4.AutoSize = true;
            this.lbTitle4.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle4.Location = new System.Drawing.Point(12, 279);
            this.lbTitle4.Name = "lbTitle4";
            this.lbTitle4.Size = new System.Drawing.Size(210, 28);
            this.lbTitle4.TabIndex = 27;
            this.lbTitle4.Text = "#RadioButton 컨트롤";
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(6, 22);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(49, 19);
            this.rdMale.TabIndex = 28;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "남자";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(5, 47);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(49, 19);
            this.rdFemale.TabIndex = 30;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "여자";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdYear2
            // 
            this.rdYear2.AutoSize = true;
            this.rdYear2.Location = new System.Drawing.Point(6, 47);
            this.rdYear2.Name = "rdYear2";
            this.rdYear2.Size = new System.Drawing.Size(56, 19);
            this.rdYear2.TabIndex = 33;
            this.rdYear2.TabStop = true;
            this.rdYear2.Text = "2학년";
            this.rdYear2.UseVisualStyleBackColor = true;
            // 
            // rdYear1
            // 
            this.rdYear1.AutoSize = true;
            this.rdYear1.Location = new System.Drawing.Point(6, 22);
            this.rdYear1.Name = "rdYear1";
            this.rdYear1.Size = new System.Drawing.Size(56, 19);
            this.rdYear1.TabIndex = 31;
            this.rdYear1.TabStop = true;
            this.rdYear1.Text = "1학년";
            this.rdYear1.UseVisualStyleBackColor = true;
            // 
            // rdYear4
            // 
            this.rdYear4.AutoSize = true;
            this.rdYear4.Location = new System.Drawing.Point(6, 97);
            this.rdYear4.Name = "rdYear4";
            this.rdYear4.Size = new System.Drawing.Size(56, 19);
            this.rdYear4.TabIndex = 35;
            this.rdYear4.TabStop = true;
            this.rdYear4.Text = "4학년";
            this.rdYear4.UseVisualStyleBackColor = true;
            // 
            // rdYear3
            // 
            this.rdYear3.AutoSize = true;
            this.rdYear3.Location = new System.Drawing.Point(6, 72);
            this.rdYear3.Name = "rdYear3";
            this.rdYear3.Size = new System.Drawing.Size(56, 19);
            this.rdYear3.TabIndex = 34;
            this.rdYear3.TabStop = true;
            this.rdYear3.Text = "3학년";
            this.rdYear3.UseVisualStyleBackColor = true;
            // 
            // btnGender
            // 
            this.btnGender.Location = new System.Drawing.Point(5, 72);
            this.btnGender.Name = "btnGender";
            this.btnGender.Size = new System.Drawing.Size(75, 23);
            this.btnGender.TabIndex = 36;
            this.btnGender.Text = "확인";
            this.btnGender.UseVisualStyleBackColor = true;
            this.btnGender.Click += new System.EventHandler(this.btnGender_Click);
            // 
            // btnYear
            // 
            this.btnYear.Location = new System.Drawing.Point(6, 122);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(75, 23);
            this.btnYear.TabIndex = 37;
            this.btnYear.Text = "확인";
            this.btnYear.UseVisualStyleBackColor = true;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // lbResultGender
            // 
            this.lbResultGender.AutoSize = true;
            this.lbResultGender.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbResultGender.Location = new System.Drawing.Point(6, 98);
            this.lbResultGender.Name = "lbResultGender";
            this.lbResultGender.Size = new System.Drawing.Size(51, 19);
            this.lbResultGender.TabIndex = 38;
            this.lbResultGender.Text = "결과 : ";
            // 
            // lbResultYear
            // 
            this.lbResultYear.AutoSize = true;
            this.lbResultYear.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbResultYear.Location = new System.Drawing.Point(6, 148);
            this.lbResultYear.Name = "lbResultYear";
            this.lbResultYear.Size = new System.Drawing.Size(51, 19);
            this.lbResultYear.TabIndex = 39;
            this.lbResultYear.Text = "결과 : ";
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rdMale);
            this.gbGender.Controls.Add(this.rdFemale);
            this.gbGender.Controls.Add(this.btnGender);
            this.gbGender.Controls.Add(this.lbResultGender);
            this.gbGender.Location = new System.Drawing.Point(12, 310);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(131, 128);
            this.gbGender.TabIndex = 40;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "성별을 고르세요.";
            // 
            // gbYear
            // 
            this.gbYear.Controls.Add(this.rdYear1);
            this.gbYear.Controls.Add(this.rdYear2);
            this.gbYear.Controls.Add(this.lbResultYear);
            this.gbYear.Controls.Add(this.rdYear3);
            this.gbYear.Controls.Add(this.btnYear);
            this.gbYear.Controls.Add(this.rdYear4);
            this.gbYear.Location = new System.Drawing.Point(149, 310);
            this.gbYear.Name = "gbYear";
            this.gbYear.Size = new System.Drawing.Size(116, 173);
            this.gbYear.TabIndex = 41;
            this.gbYear.TabStop = false;
            this.gbYear.Text = "학년을 고르세요.";
            // 
            // btnForm2
            // 
            this.btnForm2.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnForm2.Location = new System.Drawing.Point(12, 497);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(253, 40);
            this.btnForm2.TabIndex = 40;
            this.btnForm2.Text = "Form2 띄우기";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // btnForm5
            // 
            this.btnForm5.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnForm5.Location = new System.Drawing.Point(12, 543);
            this.btnForm5.Name = "btnForm5";
            this.btnForm5.Size = new System.Drawing.Size(253, 40);
            this.btnForm5.TabIndex = 42;
            this.btnForm5.Text = "Form5 띄우기";
            this.btnForm5.UseVisualStyleBackColor = true;
            this.btnForm5.Click += new System.EventHandler(this.btnForm5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 595);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnForm5);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.gbYear);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.lbTitle4);
            this.Controls.Add(this.lbResultFruit);
            this.Controls.Add(this.btnFruit);
            this.Controls.Add(this.chbFruit5);
            this.Controls.Add(this.chbFruit4);
            this.Controls.Add(this.chbFruit3);
            this.Controls.Add(this.chbFruit2);
            this.Controls.Add(this.chbFruit1);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lbTitle3);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnHp);
            this.Controls.Add(this.lbHp);
            this.Controls.Add(this.txtHp);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.btnUid);
            this.Controls.Add(this.lbUid);
            this.Controls.Add(this.txtUid);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.lbTitle2);
            this.Controls.Add(this.lbTitle1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.gbYear.ResumeLayout(false);
            this.gbYear.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //-Button 컨트롤
        private Label lbTitle1;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;

        //-TextBox 컨트롤
        private Label lbTitle2;
        //아이디
        private Label lb1;
        private TextBox txtUid;
        private Button btnUid;
        private Label lbUid;
        //이름
        private Label lb2;
        private TextBox txtName;
        private Button btnName;
        private Label lbName;
        //휴대폰
        private Label lb3;
        private TextBox txtHp;
        private Button btnHp;
        private Label lbHp;

        //-CheckBox 컨트롤
        private Label lbTitle3;
        private Label lb4;
        private CheckBox chbFruit1;
        private CheckBox chbFruit2;
        private CheckBox chbFruit3;
        private CheckBox chbFruit4;
        private CheckBox chbFruit5;
        private Button btnFruit;
        private Label lbResultFruit;

        //-RadioButton 컨트롤
        private Label lbTitle4;
        //성별
        private GroupBox gbGender;
        private RadioButton rdMale;
        private RadioButton rdFemale;
        private Button btnGender;
        private Label lbResultGender;
        //학년
        private GroupBox gbYear;
        private RadioButton rdYear1;
        private RadioButton rdYear2;
        private RadioButton rdYear3;
        private RadioButton rdYear4;
        private Button btnYear;
        private Label lbResultYear;
        private Button btnForm2;
        private Button btnForm5;
    }
}
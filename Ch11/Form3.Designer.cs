namespace Ch11
{
    partial class Form3
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
            this.lbInfo = new System.Windows.Forms.Label();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.btnCounrty = new System.Windows.Forms.Button();
            this.lbResultCountry = new System.Windows.Forms.Label();
            this.lbResultFirstActivity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(12, 9);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(225, 15);
            this.lbInfo.TabIndex = 2;
            this.lbInfo.Text = "먼저, 여행 가고 싶은 나라를 정해주세요.";
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(12, 27);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(121, 23);
            this.cbCountry.TabIndex = 3;
            // 
            // btnCounrty
            // 
            this.btnCounrty.Location = new System.Drawing.Point(139, 27);
            this.btnCounrty.Name = "btnCounrty";
            this.btnCounrty.Size = new System.Drawing.Size(75, 23);
            this.btnCounrty.TabIndex = 4;
            this.btnCounrty.Text = "확인";
            this.btnCounrty.UseVisualStyleBackColor = true;
            this.btnCounrty.Click += new System.EventHandler(this.btnCounrty_Click);
            // 
            // lbResultCountry
            // 
            this.lbResultCountry.AutoSize = true;
            this.lbResultCountry.Location = new System.Drawing.Point(12, 53);
            this.lbResultCountry.Name = "lbResultCountry";
            this.lbResultCountry.Size = new System.Drawing.Size(94, 15);
            this.lbResultCountry.TabIndex = 5;
            this.lbResultCountry.Text = "가고 싶은 나라 :";
            // 
            // lbResultFirstActivity
            // 
            this.lbResultFirstActivity.AutoSize = true;
            this.lbResultFirstActivity.Location = new System.Drawing.Point(12, 68);
            this.lbResultFirstActivity.Name = "lbResultFirstActivity";
            this.lbResultFirstActivity.Size = new System.Drawing.Size(94, 15);
            this.lbResultFirstActivity.TabIndex = 6;
            this.lbResultFirstActivity.Text = "처음 도착하면 : ";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 89);
            this.Controls.Add(this.lbResultFirstActivity);
            this.Controls.Add(this.lbResultCountry);
            this.Controls.Add(this.btnCounrty);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.lbInfo);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbInfo;
        private ComboBox cbCountry;
        private Button btnCounrty;
        private Label lbResultCountry;
        private Label lbResultFirstActivity;
    }
}
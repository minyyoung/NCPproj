namespace weather01_0510
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose ( bool disposing )
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent ()
        {
            this.dateLabel = new System.Windows.Forms.Label();
            this.cbKind1 = new System.Windows.Forms.ComboBox();
            this.cbKind3 = new System.Windows.Forms.ComboBox();
            this.cbKind2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(40, 30);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(155, 20);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "0000년 0월 0일 0요일";
            this.dateLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbKind1
            // 
            this.cbKind1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKind1.FormattingEnabled = true;
            this.cbKind1.Location = new System.Drawing.Point(247, 30);
            this.cbKind1.Name = "cbKind1";
            this.cbKind1.Size = new System.Drawing.Size(127, 20);
            this.cbKind1.TabIndex = 6;
            // 
            // cbKind3
            // 
            this.cbKind3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKind3.FormattingEnabled = true;
            this.cbKind3.Location = new System.Drawing.Point(507, 30);
            this.cbKind3.Name = "cbKind3";
            this.cbKind3.Size = new System.Drawing.Size(121, 20);
            this.cbKind3.TabIndex = 11;
            // 
            // cbKind2
            // 
            this.cbKind2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKind2.FormattingEnabled = true;
            this.cbKind2.Location = new System.Drawing.Point(380, 30);
            this.cbKind2.Name = "cbKind2";
            this.cbKind2.Size = new System.Drawing.Size(121, 20);
            this.cbKind2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(726, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "검색";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbResult
            // 
            this.tbResult.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.tbResult.Location = new System.Drawing.Point(44, 72);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(584, 366);
            this.tbResult.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 501);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbKind3);
            this.Controls.Add(this.cbKind2);
            this.Controls.Add(this.cbKind1);
            this.Controls.Add(this.dateLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.ComboBox cbKind1;
        private System.Windows.Forms.ComboBox cbKind3;
        private System.Windows.Forms.ComboBox cbKind2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbResult;
    }
}


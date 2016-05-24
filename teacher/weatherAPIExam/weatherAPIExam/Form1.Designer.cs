namespace weatherAPIExam
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
        protected override void Dispose( bool disposing )
        {
            if( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPage = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.cbCode = new System.Windows.Forms.ComboBox();
            this.cbKind1 = new System.Windows.Forms.ComboBox();
            this.cbKind2 = new System.Windows.Forms.ComboBox();
            this.cbKind3 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.areaNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // tbPage
            // 
            this.tbPage.Location = new System.Drawing.Point(397, 381);
            this.tbPage.Name = "tbPage";
            this.tbPage.Size = new System.Drawing.Size(100, 21);
            this.tbPage.TabIndex = 2;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(54, 133);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(327, 139);
            this.tbResult.TabIndex = 3;
            // 
            // cbCode
            // 
            this.cbCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCode.FormattingEnabled = true;
            this.cbCode.Location = new System.Drawing.Point(245, 381);
            this.cbCode.Name = "cbCode";
            this.cbCode.Size = new System.Drawing.Size(121, 20);
            this.cbCode.TabIndex = 4;
            this.cbCode.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbKind1
            // 
            this.cbKind1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKind1.FormattingEnabled = true;
            this.cbKind1.Location = new System.Drawing.Point(54, 303);
            this.cbKind1.Name = "cbKind1";
            this.cbKind1.Size = new System.Drawing.Size(121, 20);
            this.cbKind1.TabIndex = 5;
            this.cbKind1.SelectedIndexChanged += new System.EventHandler(this.cbKind1_SelectedIndexChanged);
            // 
            // cbKind2
            // 
            this.cbKind2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKind2.FormattingEnabled = true;
            this.cbKind2.Location = new System.Drawing.Point(181, 303);
            this.cbKind2.Name = "cbKind2";
            this.cbKind2.Size = new System.Drawing.Size(121, 20);
            this.cbKind2.TabIndex = 6;
            this.cbKind2.SelectedIndexChanged += new System.EventHandler(this.cbKind2_SelectedIndexChanged);
            // 
            // cbKind3
            // 
            this.cbKind3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKind3.FormattingEnabled = true;
            this.cbKind3.Location = new System.Drawing.Point(308, 303);
            this.cbKind3.Name = "cbKind3";
            this.cbKind3.Size = new System.Drawing.Size(121, 20);
            this.cbKind3.TabIndex = 7;
            this.cbKind3.SelectedIndexChanged += new System.EventHandler(this.cbKind3_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(590, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // areaNumber
            // 
            this.areaNumber.Location = new System.Drawing.Point(445, 302);
            this.areaNumber.Name = "areaNumber";
            this.areaNumber.Size = new System.Drawing.Size(100, 21);
            this.areaNumber.TabIndex = 9;
            this.areaNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 500);
            this.Controls.Add(this.areaNumber);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbKind3);
            this.Controls.Add(this.cbKind2);
            this.Controls.Add(this.cbKind1);
            this.Controls.Add(this.cbCode);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbPage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPage;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.ComboBox cbCode;
        private System.Windows.Forms.ComboBox cbKind1;
        private System.Windows.Forms.ComboBox cbKind2;
        private System.Windows.Forms.ComboBox cbKind3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox areaNumber;
    }
}


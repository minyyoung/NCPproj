namespace ourProject160524
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
            this.components = new System.ComponentModel.Container();
            this.cbKind1 = new System.Windows.Forms.ComboBox();
            this.cbKind2 = new System.Windows.Forms.ComboBox();
            this.cbKind3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.areaNumber = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cbKind1
            // 
            this.cbKind1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKind1.DropDownWidth = 121;
            this.cbKind1.FormattingEnabled = true;
            this.cbKind1.Location = new System.Drawing.Point(49, 69);
            this.cbKind1.Name = "cbKind1";
            this.cbKind1.Size = new System.Drawing.Size(121, 20);
            this.cbKind1.TabIndex = 5;
            this.cbKind1.SelectedIndexChanged += new System.EventHandler(this.cbKind1_SelectedIndexChanged);
            // 
            // cbKind2
            // 
            this.cbKind2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKind2.DropDownWidth = 121;
            this.cbKind2.FormattingEnabled = true;
            this.cbKind2.Location = new System.Drawing.Point(176, 69);
            this.cbKind2.Name = "cbKind2";
            this.cbKind2.Size = new System.Drawing.Size(121, 20);
            this.cbKind2.TabIndex = 6;
            this.cbKind2.SelectedIndexChanged += new System.EventHandler(this.cbKind2_SelectedIndexChanged);
            // 
            // cbKind3
            // 
            this.cbKind3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKind3.DropDownWidth = 121;
            this.cbKind3.FormattingEnabled = true;
            this.cbKind3.Location = new System.Drawing.Point(303, 69);
            this.cbKind3.Name = "cbKind3";
            this.cbKind3.Size = new System.Drawing.Size(121, 20);
            this.cbKind3.TabIndex = 7;
            this.cbKind3.SelectedIndexChanged += new System.EventHandler(this.cbKind3_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(441, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "지역 설정";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(49, 119);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(327, 139);
            this.tbResult.TabIndex = 3;
            // 
            // areaNumber
            // 
            this.areaNumber.Location = new System.Drawing.Point(49, 264);
            this.areaNumber.Name = "areaNumber";
            this.areaNumber.Size = new System.Drawing.Size(100, 21);
            this.areaNumber.TabIndex = 9;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(47, 29);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(38, 12);
            this.dateLabel.TabIndex = 10;
            this.dateLabel.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 423);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.areaNumber);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbKind3);
            this.Controls.Add(this.cbKind2);
            this.Controls.Add(this.cbKind1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKind1;
        private System.Windows.Forms.ComboBox cbKind2;
        private System.Windows.Forms.ComboBox cbKind3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.TextBox areaNumber;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer timer1;
    }
}


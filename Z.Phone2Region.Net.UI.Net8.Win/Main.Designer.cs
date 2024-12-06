namespace Z.Phone2Region.Net.UI.Net8.Win
{
    partial class Main
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
            titleLabel = new Label();
            initGroupBox = new GroupBox();
            urlTextBox = new TextBox();
            urlLabel = new Label();
            urlLoadBtn = new Button();
            fileTextBox = new TextBox();
            fileLabel = new Label();
            fileSelectBtn = new Button();
            fileLoadBtn = new Button();
            phoneLabel = new Label();
            phoneTextBox = new TextBox();
            queryBtn = new Button();
            resultTextBox = new TextBox();
            initGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Microsoft YaHei UI", 20F);
            titleLabel.Location = new Point(180, 10);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(204, 35);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "手机号码转区域";
            // 
            // initGroupBox
            // 
            initGroupBox.Controls.Add(urlTextBox);
            initGroupBox.Controls.Add(urlLabel);
            initGroupBox.Controls.Add(urlLoadBtn);
            initGroupBox.Controls.Add(fileTextBox);
            initGroupBox.Controls.Add(fileLabel);
            initGroupBox.Controls.Add(fileSelectBtn);
            initGroupBox.Controls.Add(fileLoadBtn);
            initGroupBox.Location = new Point(5, 40);
            initGroupBox.Name = "initGroupBox";
            initGroupBox.Size = new Size(590, 80);
            initGroupBox.TabIndex = 0;
            initGroupBox.TabStop = false;
            initGroupBox.Text = "初始化";
            // 
            // urlTextBox
            // 
            urlTextBox.Location = new Point(45, 20);
            urlTextBox.Name = "urlTextBox";
            urlTextBox.Size = new Size(440, 23);
            urlTextBox.TabIndex = 1;
            urlTextBox.Text = "https://www.404z.cn/files/phone2region/v2.0.0/data/phone2region.zdb";
            // 
            // urlLabel
            // 
            urlLabel.AutoSize = true;
            urlLabel.Location = new Point(5, 24);
            urlLabel.Name = "urlLabel";
            urlLabel.Size = new Size(43, 17);
            urlLabel.TabIndex = 0;
            urlLabel.Text = "URL：";
            // 
            // urlLoadBtn
            // 
            urlLoadBtn.Location = new Point(500, 20);
            urlLoadBtn.Name = "urlLoadBtn";
            urlLoadBtn.Size = new Size(75, 23);
            urlLoadBtn.TabIndex = 2;
            urlLoadBtn.Text = "加载";
            urlLoadBtn.UseVisualStyleBackColor = true;
            urlLoadBtn.Click += UrlLoadBtn_Click;
            // 
            // fileTextBox
            // 
            fileTextBox.Location = new Point(45, 50);
            fileTextBox.Name = "fileTextBox";
            fileTextBox.Size = new Size(350, 23);
            fileTextBox.TabIndex = 3;
            // 
            // fileLabel
            // 
            fileLabel.AutoSize = true;
            fileLabel.Location = new Point(5, 54);
            fileLabel.Name = "fileLabel";
            fileLabel.Size = new Size(44, 17);
            fileLabel.TabIndex = 0;
            fileLabel.Text = "文件：";
            // 
            // fileSelectBtn
            // 
            fileSelectBtn.Location = new Point(410, 50);
            fileSelectBtn.Name = "fileSelectBtn";
            fileSelectBtn.Size = new Size(75, 23);
            fileSelectBtn.TabIndex = 4;
            fileSelectBtn.Text = "选择文件";
            fileSelectBtn.UseVisualStyleBackColor = true;
            fileSelectBtn.Click += FileSelectBtn_Click;
            // 
            // fileLoadBtn
            // 
            fileLoadBtn.Location = new Point(500, 50);
            fileLoadBtn.Name = "fileLoadBtn";
            fileLoadBtn.Size = new Size(75, 23);
            fileLoadBtn.TabIndex = 5;
            fileLoadBtn.Text = "加载";
            fileLoadBtn.UseVisualStyleBackColor = true;
            fileLoadBtn.Click += FileLoadBtn_Click;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Microsoft YaHei UI", 18F);
            phoneLabel.Location = new Point(50, 136);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(110, 31);
            phoneLabel.TabIndex = 0;
            phoneLabel.Text = "手机号码";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Font = new Font("Microsoft YaHei UI", 18F);
            phoneTextBox.Location = new Point(190, 130);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(200, 38);
            phoneTextBox.TabIndex = 6;
            // 
            // queryBtn
            // 
            queryBtn.Enabled = false;
            queryBtn.Font = new Font("Microsoft YaHei UI", 18F);
            queryBtn.Location = new Point(420, 130);
            queryBtn.Name = "queryBtn";
            queryBtn.Size = new Size(120, 40);
            queryBtn.TabIndex = 7;
            queryBtn.Text = "查询";
            queryBtn.UseVisualStyleBackColor = true;
            queryBtn.Click += QueryBtn_Click;
            // 
            // resultTextBox
            // 
            resultTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            resultTextBox.Font = new Font("Microsoft YaHei UI", 18F);
            resultTextBox.Location = new Point(10, 175);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(580, 90);
            resultTextBox.TabIndex = 8;
            resultTextBox.Text = "省份\t城市\t邮编\t区号\tISP";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 270);
            Controls.Add(titleLabel);
            Controls.Add(initGroupBox);
            Controls.Add(phoneLabel);
            Controls.Add(phoneTextBox);
            Controls.Add(queryBtn);
            Controls.Add(resultTextBox);
            Name = "Main";
            StartPosition = FormStartPosition.CenterParent;
            Text = "手机号码转区域";
            initGroupBox.ResumeLayout(false);
            initGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        /// <summary>
        /// 标题Label
        /// </summary>
        private System.Windows.Forms.Label titleLabel;
        /// <summary>
        /// 初始化GroupBox
        /// </summary>
        private System.Windows.Forms.GroupBox initGroupBox;
        /// <summary>
        /// URL Label
        /// </summary>
        private System.Windows.Forms.Label urlLabel;
        /// <summary>
        /// URL TextBox
        /// </summary>
        private System.Windows.Forms.TextBox urlTextBox;
        /// <summary>
        /// 加载URL Button
        /// </summary>
        private System.Windows.Forms.Button urlLoadBtn;
        /// <summary>
        /// 文件Label
        /// </summary>
        private System.Windows.Forms.Label fileLabel;
        /// <summary>
        /// 文件TextBox
        /// </summary>
        private System.Windows.Forms.TextBox fileTextBox;
        /// <summary>
        /// 选择文件Button
        /// </summary>
        private System.Windows.Forms.Button fileSelectBtn;
        /// <summary>
        /// 加载文件Button
        /// </summary>
        private System.Windows.Forms.Button fileLoadBtn;
        /// <summary>
        /// 手机号码Label
        /// </summary>
        private System.Windows.Forms.Label phoneLabel;
        /// <summary>
        /// 手机号码TextBox
        /// </summary>
        private System.Windows.Forms.TextBox phoneTextBox;
        /// <summary>
        /// 查询Button
        /// </summary>
        private System.Windows.Forms.Button queryBtn;
        /// <summary>
        /// 结果TextBox
        /// </summary>
        private System.Windows.Forms.TextBox resultTextBox;

    }
}

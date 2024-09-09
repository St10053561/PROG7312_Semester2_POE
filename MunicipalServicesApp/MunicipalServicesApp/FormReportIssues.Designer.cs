namespace MunicipalServicesApp
{
    partial class FormReportIssues
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LocationTxtbx = new System.Windows.Forms.TextBox();
            this.CategoryComboBx = new System.Windows.Forms.ComboBox();
            this.DescriptionRichTxtbox = new System.Windows.Forms.RichTextBox();
            this.MediaAttachBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.BackToMainMenuBtn = new System.Windows.Forms.Button();
            this.labelMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category Selection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Description Box";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Media Attachment";
            // 
            // LocationTxtbx
            // 
            this.LocationTxtbx.Location = new System.Drawing.Point(297, 77);
            this.LocationTxtbx.Multiline = true;
            this.LocationTxtbx.Name = "LocationTxtbx";
            this.LocationTxtbx.Size = new System.Drawing.Size(208, 30);
            this.LocationTxtbx.TabIndex = 1;
            // 
            // CategoryComboBx
            // 
            this.CategoryComboBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryComboBx.FormattingEnabled = true;
            this.CategoryComboBx.Location = new System.Drawing.Point(297, 131);
            this.CategoryComboBx.Name = "CategoryComboBx";
            this.CategoryComboBx.Size = new System.Drawing.Size(208, 24);
            this.CategoryComboBx.TabIndex = 2;
            // 
            // DescriptionRichTxtbox
            // 
            this.DescriptionRichTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionRichTxtbox.Location = new System.Drawing.Point(297, 178);
            this.DescriptionRichTxtbox.Name = "DescriptionRichTxtbox";
            this.DescriptionRichTxtbox.Size = new System.Drawing.Size(208, 112);
            this.DescriptionRichTxtbox.TabIndex = 3;
            this.DescriptionRichTxtbox.Text = "";
            // 
            // MediaAttachBtn
            // 
            this.MediaAttachBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediaAttachBtn.Location = new System.Drawing.Point(297, 341);
            this.MediaAttachBtn.Name = "MediaAttachBtn";
            this.MediaAttachBtn.Size = new System.Drawing.Size(208, 35);
            this.MediaAttachBtn.TabIndex = 4;
            this.MediaAttachBtn.Text = "Upload File";
            this.MediaAttachBtn.UseVisualStyleBackColor = true;
            this.MediaAttachBtn.Click += new System.EventHandler(this.MediaAttachBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(84, 396);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(421, 30);
            this.progressBar.TabIndex = 7;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.Location = new System.Drawing.Point(297, 444);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(208, 39);
            this.SubmitBtn.TabIndex = 8;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // BackToMainMenuBtn
            // 
            this.BackToMainMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToMainMenuBtn.Location = new System.Drawing.Point(63, 444);
            this.BackToMainMenuBtn.Name = "BackToMainMenuBtn";
            this.BackToMainMenuBtn.Size = new System.Drawing.Size(208, 39);
            this.BackToMainMenuBtn.TabIndex = 8;
            this.BackToMainMenuBtn.Text = "Back to Main Menu";
            this.BackToMainMenuBtn.UseVisualStyleBackColor = true;
            this.BackToMainMenuBtn.Click += new System.EventHandler(this.BackToMainMenuBtn_Click);
            // 
            // labelMsg
            // 
            this.labelMsg.AutoSize = true;
            this.labelMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMsg.Location = new System.Drawing.Point(28, 410);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(50, 16);
            this.labelMsg.TabIndex = 9;
            this.labelMsg.Text = "label5";
            // 
            // FormReportIssues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 516);
            this.Controls.Add(this.labelMsg);
            this.Controls.Add(this.BackToMainMenuBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.MediaAttachBtn);
            this.Controls.Add(this.DescriptionRichTxtbox);
            this.Controls.Add(this.CategoryComboBx);
            this.Controls.Add(this.LocationTxtbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormReportIssues";
            this.Text = "FormReportIssues";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LocationTxtbx;
        private System.Windows.Forms.ComboBox CategoryComboBx;
        private System.Windows.Forms.RichTextBox DescriptionRichTxtbox;
        private System.Windows.Forms.Button MediaAttachBtn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button BackToMainMenuBtn;
        private System.Windows.Forms.Label labelMsg;
    }
}
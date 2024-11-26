namespace avtorisation
{
    partial class AdminForm
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
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(83, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Аккаунт администратора";
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShow.Location = new System.Drawing.Point(112, 71);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(281, 61);
            this.buttonShow.TabIndex = 1;
            this.buttonShow.Text = "Просмотр пользователей";
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBack.Location = new System.Drawing.Point(371, 480);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(115, 33);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Выйти";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // show
            // 
            this.show.FormattingEnabled = true;
            this.show.Location = new System.Drawing.Point(34, 149);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(427, 303);
            this.show.TabIndex = 4;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(498, 537);
            this.Controls.Add(this.show);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.Text = "Форма админа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ListBox show;
    }
}
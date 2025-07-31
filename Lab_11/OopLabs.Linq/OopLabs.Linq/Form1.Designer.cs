namespace OopLabs.Linq
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ArtistsListBox = new System.Windows.Forms.ListBox();
            this.AlbumsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исполнители";
            // 
            // ArtistsListBox
            // 
            this.ArtistsListBox.FormattingEnabled = true;
            this.ArtistsListBox.ItemHeight = 20;
            this.ArtistsListBox.Location = new System.Drawing.Point(12, 41);
            this.ArtistsListBox.Name = "ArtistsListBox";
            this.ArtistsListBox.Size = new System.Drawing.Size(354, 384);
            this.ArtistsListBox.TabIndex = 1;
            this.ArtistsListBox.SelectedIndexChanged += new System.EventHandler(this.ArtistsListBox_SelectedIndexChanged);
            // 
            // AlbumsListBox
            // 
            this.AlbumsListBox.FormattingEnabled = true;
            this.AlbumsListBox.ItemHeight = 20;
            this.AlbumsListBox.Location = new System.Drawing.Point(397, 41);
            this.AlbumsListBox.Name = "AlbumsListBox";
            this.AlbumsListBox.Size = new System.Drawing.Size(340, 384);
            this.AlbumsListBox.TabIndex = 2;
            this.AlbumsListBox.SelectedIndexChanged += new System.EventHandler(this.ArtistsListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Альбомы";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AlbumsListBox);
            this.Controls.Add(this.ArtistsListBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ArtistsListBox;
        private System.Windows.Forms.ListBox AlbumsListBox;
        private System.Windows.Forms.Label label2;
    }
}


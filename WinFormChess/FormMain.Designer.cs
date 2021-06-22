namespace WinFormChess
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBoxBoard = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxBoard
            // 
            this.richTextBoxBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.richTextBoxBoard.Location = new System.Drawing.Point(26, 21);
            this.richTextBoxBoard.Name = "richTextBoxBoard";
            this.richTextBoxBoard.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxBoard.Size = new System.Drawing.Size(449, 426);
            this.richTextBoxBoard.TabIndex = 0;
            this.richTextBoxBoard.Text = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 478);
            this.Controls.Add(this.richTextBoxBoard);
            this.Name = "FormMain";
            this.Text = "WinForm Chess";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxBoard;
    }
}


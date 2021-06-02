
namespace Aufgabenliste
{
    partial class Aufgabenverwaltung
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
            this.listBoxAufgaben = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxAufgaben
            // 
            this.listBoxAufgaben.FormattingEnabled = true;
            this.listBoxAufgaben.Location = new System.Drawing.Point(60, 22);
            this.listBoxAufgaben.Name = "listBoxAufgaben";
            this.listBoxAufgaben.Size = new System.Drawing.Size(474, 355);
            this.listBoxAufgaben.TabIndex = 0;
            // 
            // AufgabenverwaltungMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxAufgaben);
            this.Name = "AufgabenverwaltungMain";
            this.Text = "Aufgabenverwaltung";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAufgaben;
    }
}



namespace Aufgabenliste
{
    partial class FensterAufgabenverwaltung
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
            this.button1NeueAufgabe = new System.Windows.Forms.Button();
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
            // button1NeueAufgabe
            // 
            this.button1NeueAufgabe.Location = new System.Drawing.Point(572, 79);
            this.button1NeueAufgabe.Name = "button1NeueAufgabe";
            this.button1NeueAufgabe.Size = new System.Drawing.Size(117, 53);
            this.button1NeueAufgabe.TabIndex = 1;
            this.button1NeueAufgabe.Text = "Neue Aufgabe hinzufügen";
            this.button1NeueAufgabe.UseVisualStyleBackColor = true;
            this.button1NeueAufgabe.Click += new System.EventHandler(this.button1NeueAufgabe_Click);
            // 
            // Aufgabenverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1NeueAufgabe);
            this.Controls.Add(this.listBoxAufgaben);
            this.Name = "Aufgabenverwaltung";
            this.Text = "Aufgabenverwaltung";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAufgaben;
        private System.Windows.Forms.Button button1NeueAufgabe;
    }
}


﻿namespace TheSnake
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sTARTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pAUZAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rESTARTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sPEEDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fASTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sLOWERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Playground = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTARTToolStripMenuItem,
            this.pAUZAToolStripMenuItem,
            this.rESTARTToolStripMenuItem,
            this.sPEEDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(296, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // sTARTToolStripMenuItem
            // 
            this.sTARTToolStripMenuItem.Name = "sTARTToolStripMenuItem";
            this.sTARTToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.sTARTToolStripMenuItem.Text = "START";
            this.sTARTToolStripMenuItem.Click += new System.EventHandler(this.sTARTToolStripMenuItem_Click);
            // 
            // pAUZAToolStripMenuItem
            // 
            this.pAUZAToolStripMenuItem.Name = "pAUZAToolStripMenuItem";
            this.pAUZAToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.pAUZAToolStripMenuItem.Text = "STOP";
            this.pAUZAToolStripMenuItem.Click += new System.EventHandler(this.pAUZAToolStripMenuItem_Click);
            // 
            // rESTARTToolStripMenuItem
            // 
            this.rESTARTToolStripMenuItem.Name = "rESTARTToolStripMenuItem";
            this.rESTARTToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.rESTARTToolStripMenuItem.Text = "RESTART";
            // 
            // sPEEDToolStripMenuItem
            // 
            this.sPEEDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fASTERToolStripMenuItem,
            this.sLOWERToolStripMenuItem});
            this.sPEEDToolStripMenuItem.Name = "sPEEDToolStripMenuItem";
            this.sPEEDToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.sPEEDToolStripMenuItem.Text = "SPEED";
            // 
            // fASTERToolStripMenuItem
            // 
            this.fASTERToolStripMenuItem.Name = "fASTERToolStripMenuItem";
            this.fASTERToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.fASTERToolStripMenuItem.Text = "FASTER";
            // 
            // sLOWERToolStripMenuItem
            // 
            this.sLOWERToolStripMenuItem.Name = "sLOWERToolStripMenuItem";
            this.sLOWERToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.sLOWERToolStripMenuItem.Text = "SLOWER";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Playground
            // 
            this.Playground.BackColor = System.Drawing.Color.Green;
            this.Playground.BackgroundImage = global::TheSnake.Properties.Resources.grassSmall;
            this.Playground.Location = new System.Drawing.Point(8, 27);
            this.Playground.Name = "Playground";
            this.Playground.Size = new System.Drawing.Size(280, 280);
            this.Playground.TabIndex = 1;
            this.Playground.Paint += new System.Windows.Forms.PaintEventHandler(this.Playground_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 318);
            this.Controls.Add(this.Playground);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sTARTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pAUZAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rESTARTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sPEEDToolStripMenuItem;
        private System.Windows.Forms.Panel Playground;
        private System.Windows.Forms.ToolStripMenuItem fASTERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sLOWERToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

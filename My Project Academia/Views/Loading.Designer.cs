namespace My_Project_Academia.Views
{
    partial class Loading
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
            components = new System.ComponentModel.Container();
            lbProcessando = new Label();
            ProgressBar1 = new ProgressBar();
            Timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            Timer3 = new System.Windows.Forms.Timer(components);
            Panel1 = new Panel();
            Timer4 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lbProcessando
            // 
            lbProcessando.AutoSize = true;
            lbProcessando.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbProcessando.Location = new Point(271, 166);
            lbProcessando.Name = "lbProcessando";
            lbProcessando.Size = new Size(123, 23);
            lbProcessando.TabIndex = 0;
            lbProcessando.Text = "Processando...";
            // 
            // ProgressBar1
            // 
            ProgressBar1.Location = new Point(223, 213);
            ProgressBar1.Name = "ProgressBar1";
            ProgressBar1.Size = new Size(212, 21);
            ProgressBar1.TabIndex = 1;
            // 
            // Timer1
            // 
            Timer1.Enabled = true;
            Timer1.Interval = 10;
            Timer1.Tick += Timer1_Tick;
            // 
            // Timer3
            // 
            Timer3.Enabled = true;
            Timer3.Interval = 50;
            Timer3.Tick += Timer3_Tick;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.CornflowerBlue;
            Panel1.ForeColor = Color.DarkCyan;
            Panel1.Location = new Point(223, 213);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(202, 10);
            Panel1.TabIndex = 2;
            // 
            // Timer4
            // 
            Timer4.Enabled = true;
            Timer4.Tick += Timer4_Tick;
            // 
            // Loading
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Looes;
            ClientSize = new Size(662, 430);
            Controls.Add(Panel1);
            Controls.Add(ProgressBar1);
            Controls.Add(lbProcessando);
            Name = "Loading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loading";
            Load += Loading_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbProcessando;
        private ProgressBar ProgressBar1;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer Timer3;
        private Panel Panel1;
        private System.Windows.Forms.Timer Timer4;
    }
}
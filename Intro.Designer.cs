namespace Calculator
{
    partial class Calculator3000
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
            this.StartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DropPan = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.Button();
            this.SurpriseButton = new System.Windows.Forms.Button();
            this.DropPan.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(34, 186);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(363, 178);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start this futuristic machine";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(729, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "\"I Albert Einstein, endorse this C# calculator\" - Albert Einstein";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Calculator 3000";
            // 
            // DropPan
            // 
            this.DropPan.Controls.Add(this.SurpriseButton);
            this.DropPan.Controls.Add(this.Menu);
            this.DropPan.Location = new System.Drawing.Point(12, 2);
            this.DropPan.Name = "DropPan";
            this.DropPan.Size = new System.Drawing.Size(89, 27);
            this.DropPan.TabIndex = 5;
            // 
            // Menu
            // 
            this.Menu.Location = new System.Drawing.Point(0, 3);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(89, 23);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            this.Menu.UseVisualStyleBackColor = true;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // SurpriseButton
            // 
            this.SurpriseButton.Location = new System.Drawing.Point(0, 32);
            this.SurpriseButton.Name = "SurpriseButton";
            this.SurpriseButton.Size = new System.Drawing.Size(89, 23);
            this.SurpriseButton.TabIndex = 1;
            this.SurpriseButton.Text = "Joke";
            this.SurpriseButton.UseVisualStyleBackColor = true;
            this.SurpriseButton.Click += new System.EventHandler(this.SurpriseButton_Click);
            // 
            // Calculator3000
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Calculator.Properties.Resources.Screenshot__7_;
            this.ClientSize = new System.Drawing.Size(877, 520);
            this.Controls.Add(this.DropPan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Calculator3000";
            this.Text = "Calculator3000";
            this.Load += new System.EventHandler(this.Calculator3000_Load);
            this.DropPan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel DropPan;
        private System.Windows.Forms.Button SurpriseButton;
        private System.Windows.Forms.Button Menu;
    }
}


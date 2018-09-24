namespace DuckApplication
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbRubber = new System.Windows.Forms.RadioButton();
            this.rdbDecoyDuck = new System.Windows.Forms.RadioButton();
            this.rdbRedHead = new System.Windows.Forms.RadioButton();
            this.rdbMallard = new System.Windows.Forms.RadioButton();
            this.Display = new System.Windows.Forms.Button();
            this.Fly = new System.Windows.Forms.Button();
            this.Quack = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbRubber);
            this.groupBox1.Controls.Add(this.rdbDecoyDuck);
            this.groupBox1.Controls.Add(this.rdbRedHead);
            this.groupBox1.Controls.Add(this.rdbMallard);
            this.groupBox1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(75, 196);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(270, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DuckType";
            // 
            // rdbRubber
            // 
            this.rdbRubber.AutoSize = true;
            this.rdbRubber.Location = new System.Drawing.Point(57, 264);
            this.rdbRubber.Margin = new System.Windows.Forms.Padding(4);
            this.rdbRubber.Name = "rdbRubber";
            this.rdbRubber.Size = new System.Drawing.Size(169, 33);
            this.rdbRubber.TabIndex = 3;
            this.rdbRubber.TabStop = true;
            this.rdbRubber.Text = "Rubber Duck";
            this.rdbRubber.UseVisualStyleBackColor = true;
            // 
            // rdbDecoyDuck
            // 
            this.rdbDecoyDuck.AutoSize = true;
            this.rdbDecoyDuck.Location = new System.Drawing.Point(57, 200);
            this.rdbDecoyDuck.Margin = new System.Windows.Forms.Padding(4);
            this.rdbDecoyDuck.Name = "rdbDecoyDuck";
            this.rdbDecoyDuck.Size = new System.Drawing.Size(156, 33);
            this.rdbDecoyDuck.TabIndex = 2;
            this.rdbDecoyDuck.TabStop = true;
            this.rdbDecoyDuck.Text = "Decoy Duck";
            this.rdbDecoyDuck.UseVisualStyleBackColor = true;
            // 
            // rdbRedHead
            // 
            this.rdbRedHead.AutoSize = true;
            this.rdbRedHead.Location = new System.Drawing.Point(57, 129);
            this.rdbRedHead.Margin = new System.Windows.Forms.Padding(4);
            this.rdbRedHead.Name = "rdbRedHead";
            this.rdbRedHead.Size = new System.Drawing.Size(136, 33);
            this.rdbRedHead.TabIndex = 1;
            this.rdbRedHead.TabStop = true;
            this.rdbRedHead.Text = "Red Head";
            this.rdbRedHead.UseVisualStyleBackColor = true;
            // 
            // rdbMallard
            // 
            this.rdbMallard.AutoSize = true;
            this.rdbMallard.Location = new System.Drawing.Point(57, 60);
            this.rdbMallard.Margin = new System.Windows.Forms.Padding(4);
            this.rdbMallard.Name = "rdbMallard";
            this.rdbMallard.Size = new System.Drawing.Size(116, 33);
            this.rdbMallard.TabIndex = 0;
            this.rdbMallard.TabStop = true;
            this.rdbMallard.Text = "Mallard";
            this.rdbMallard.UseVisualStyleBackColor = true;
            // 
            // Display
            // 
            this.Display.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.Location = new System.Drawing.Point(472, 196);
            this.Display.Margin = new System.Windows.Forms.Padding(4);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(201, 54);
            this.Display.TabIndex = 1;
            this.Display.Text = "Display";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // Fly
            // 
            this.Fly.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fly.Location = new System.Drawing.Point(472, 328);
            this.Fly.Margin = new System.Windows.Forms.Padding(4);
            this.Fly.Name = "Fly";
            this.Fly.Size = new System.Drawing.Size(201, 60);
            this.Fly.TabIndex = 2;
            this.Fly.Text = "Fly";
            this.Fly.UseVisualStyleBackColor = true;
            this.Fly.Click += new System.EventHandler(this.Fly_Click);
            // 
            // Quack
            // 
            this.Quack.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quack.Location = new System.Drawing.Point(472, 472);
            this.Quack.Margin = new System.Windows.Forms.Padding(4);
            this.Quack.Name = "Quack";
            this.Quack.Size = new System.Drawing.Size(200, 50);
            this.Quack.TabIndex = 3;
            this.Quack.Text = "Quack";
            this.Quack.UseVisualStyleBackColor = true;
            this.Quack.Click += new System.EventHandler(this.Quack_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(303, 562);
            this.lblDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(67, 29);
            this.lblDisplay.TabIndex = 4;
            this.lblDisplay.Text = ".........";
            this.lblDisplay.Click += new System.EventHandler(this.lblDisplay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 64);
            this.label1.TabIndex = 5;
            this.label1.Text = "Duck Simulator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 675);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.Quack);
            this.Controls.Add(this.Fly);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbRubber;
        private System.Windows.Forms.RadioButton rdbDecoyDuck;
        private System.Windows.Forms.RadioButton rdbRedHead;
        private System.Windows.Forms.RadioButton rdbMallard;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.Button Fly;
        private System.Windows.Forms.Button Quack;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label label1;
    }
}


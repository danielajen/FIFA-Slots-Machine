
namespace FIFA_Slots_Machine
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pb1messi = new System.Windows.Forms.PictureBox();
            this.pblewa2 = new System.Windows.Forms.PictureBox();
            this.pbronaldo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb1messi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblewa2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbronaldo)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1messi
            // 
            this.pb1messi.BackColor = System.Drawing.Color.Transparent;
            this.pb1messi.Image = global::FIFA_Slots_Machine.Properties.Resources.lionel_messi_fut_base_93_1o3m39jkuh20j1itc0w2pe9x0d;
            this.pb1messi.Location = new System.Drawing.Point(60, 70);
            this.pb1messi.Name = "pb1messi";
            this.pb1messi.Size = new System.Drawing.Size(220, 300);
            this.pb1messi.TabIndex = 0;
            this.pb1messi.TabStop = false;
            this.pb1messi.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pblewa2
            // 
            this.pblewa2.BackColor = System.Drawing.Color.Transparent;
            this.pblewa2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pblewa2.Image = global::FIFA_Slots_Machine.Properties.Resources._0_top_22_lewandowski;
            this.pblewa2.Location = new System.Drawing.Point(334, 70);
            this.pblewa2.Name = "pblewa2";
            this.pblewa2.Size = new System.Drawing.Size(225, 323);
            this.pblewa2.TabIndex = 1;
            this.pblewa2.TabStop = false;
            this.pblewa2.Click += new System.EventHandler(this.pblewa2_Click);
            // 
            // pbronaldo
            // 
            this.pbronaldo.BackColor = System.Drawing.Color.Transparent;
            this.pbronaldo.Image = global::FIFA_Slots_Machine.Properties.Resources.r908859_612x918_2_3;
            this.pbronaldo.Location = new System.Drawing.Point(615, 70);
            this.pbronaldo.Name = "pbronaldo";
            this.pbronaldo.Size = new System.Drawing.Size(225, 303);
            this.pbronaldo.TabIndex = 2;
            this.pbronaldo.TabStop = false;
            this.pbronaldo.Click += new System.EventHandler(this.pbronaldo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(349, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Open Pack";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Points";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Wheat;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "100";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 80;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(893, 490);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbronaldo);
            this.Controls.Add(this.pblewa2);
            this.Controls.Add(this.pb1messi);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb1messi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblewa2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbronaldo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1messi;
        private System.Windows.Forms.PictureBox pblewa2;
        private System.Windows.Forms.PictureBox pbronaldo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}


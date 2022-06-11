namespace ButtonGiroxD
{
    partial class FormStart
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
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMaxNotes = new System.Windows.Forms.TextBox();
            this.txtRepeat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWaitTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMusic = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(155, 28);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(100, 20);
            this.txtSpeed.TabIndex = 0;
            this.txtSpeed.Text = "4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Comenzar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMaxNotes
            // 
            this.txtMaxNotes.Location = new System.Drawing.Point(155, 80);
            this.txtMaxNotes.Name = "txtMaxNotes";
            this.txtMaxNotes.Size = new System.Drawing.Size(100, 20);
            this.txtMaxNotes.TabIndex = 2;
            this.txtMaxNotes.Text = "5";
            // 
            // txtRepeat
            // 
            this.txtRepeat.Location = new System.Drawing.Point(155, 54);
            this.txtRepeat.Name = "txtRepeat";
            this.txtRepeat.Size = new System.Drawing.Size(100, 20);
            this.txtRepeat.TabIndex = 2;
            this.txtRepeat.Text = "170.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Velocidad de movimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tiempo al repetir notas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Maximo Notas (máx. 10)";
            // 
            // txtWaitTime
            // 
            this.txtWaitTime.Location = new System.Drawing.Point(155, 106);
            this.txtWaitTime.Name = "txtWaitTime";
            this.txtWaitTime.Size = new System.Drawing.Size(100, 20);
            this.txtWaitTime.TabIndex = 6;
            this.txtWaitTime.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tiempo de espera al inicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Musica";
            // 
            // txtMusic
            // 
            this.txtMusic.Location = new System.Drawing.Point(155, 132);
            this.txtMusic.Name = "txtMusic";
            this.txtMusic.Size = new System.Drawing.Size(100, 20);
            this.txtMusic.TabIndex = 9;
            this.txtMusic.Text = "Buscar mp3";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "BPM add count (ms)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 221);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtMusic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWaitTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRepeat);
            this.Controls.Add(this.txtMaxNotes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSpeed);
            this.Name = "FormStart";
            this.Text = "Simulador Baile";
            this.Load += new System.EventHandler(this.FormStart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMaxNotes;
        private System.Windows.Forms.TextBox txtRepeat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWaitTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMusic;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}

namespace konversi
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdBalik = new System.Windows.Forms.RadioButton();
            this.rdReplace = new System.Windows.Forms.RadioButton();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ardian_Supardi_txtInput = new System.Windows.Forms.TextBox();
            this.Ardian_Supardi_txtHasil = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "KONVERSI KATA";
            // 
            // rdBalik
            // 
            this.rdBalik.AutoSize = true;
            this.rdBalik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBalik.Location = new System.Drawing.Point(17, 140);
            this.rdBalik.Name = "rdBalik";
            this.rdBalik.Size = new System.Drawing.Size(89, 21);
            this.rdBalik.TabIndex = 2;
            this.rdBalik.TabStop = true;
            this.rdBalik.Text = "Balik Kata";
            this.rdBalik.UseVisualStyleBackColor = true;
            this.rdBalik.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdReplace
            // 
            this.rdReplace.AutoSize = true;
            this.rdReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdReplace.Location = new System.Drawing.Point(204, 140);
            this.rdReplace.Name = "rdReplace";
            this.rdReplace.Size = new System.Drawing.Size(206, 21);
            this.rdReplace.TabIndex = 3;
            this.rdReplace.TabStop = true;
            this.rdReplace.Text = "Replace Hururd A dengan O";
            this.rdReplace.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(32, 180);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(408, 30);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "GENERATE";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Masukkan kata";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hasil Kata yang Digenerate ";
            // 
            // Ardian_Supardi_txtInput
            // 
            this.Ardian_Supardi_txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ardian_Supardi_txtInput.Location = new System.Drawing.Point(154, 89);
            this.Ardian_Supardi_txtInput.Name = "Ardian_Supardi_txtInput";
            this.Ardian_Supardi_txtInput.Size = new System.Drawing.Size(286, 23);
            this.Ardian_Supardi_txtInput.TabIndex = 3;
            // 
            // Ardian_Supardi_txtHasil
            // 
            this.Ardian_Supardi_txtHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ardian_Supardi_txtHasil.Location = new System.Drawing.Point(216, 289);
            this.Ardian_Supardi_txtHasil.Name = "Ardian_Supardi_txtHasil";
            this.Ardian_Supardi_txtHasil.Size = new System.Drawing.Size(255, 23);
            this.Ardian_Supardi_txtHasil.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(386, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "kembali";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Ardian_Supardi_txtHasil);
            this.Controls.Add(this.Ardian_Supardi_txtInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.rdReplace);
            this.Controls.Add(this.rdBalik);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "konversi kata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdBalik;
        private System.Windows.Forms.RadioButton rdReplace;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Ardian_Supardi_txtInput;
        private System.Windows.Forms.TextBox Ardian_Supardi_txtHasil;
        private System.Windows.Forms.Button button1;
    }
}
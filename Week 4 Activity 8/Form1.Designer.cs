
namespace Week_4_Activity_8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fatInput = new System.Windows.Forms.TextBox();
            this.carbInput = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fatOutput = new System.Windows.Forms.Label();
            this.carbOutput = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fat grams consumed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carbohydrate grams consumed:";
            // 
            // fatInput
            // 
            this.fatInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatInput.Location = new System.Drawing.Point(269, 100);
            this.fatInput.Name = "fatInput";
            this.fatInput.Size = new System.Drawing.Size(151, 26);
            this.fatInput.TabIndex = 2;
            // 
            // carbInput
            // 
            this.carbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbInput.Location = new System.Drawing.Point(269, 165);
            this.carbInput.Name = "carbInput";
            this.carbInput.Size = new System.Drawing.Size(151, 26);
            this.carbInput.TabIndex = 3;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(169, 212);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(130, 42);
            this.submit.TabIndex = 4;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total amount of calories from:";
            // 
            // fatOutput
            // 
            this.fatOutput.AutoSize = true;
            this.fatOutput.BackColor = System.Drawing.Color.Transparent;
            this.fatOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatOutput.Location = new System.Drawing.Point(163, 351);
            this.fatOutput.Name = "fatOutput";
            this.fatOutput.Size = new System.Drawing.Size(41, 20);
            this.fatOutput.TabIndex = 6;
            this.fatOutput.Text = "Fat: ";
            // 
            // carbOutput
            // 
            this.carbOutput.AutoSize = true;
            this.carbOutput.BackColor = System.Drawing.Color.Transparent;
            this.carbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbOutput.Location = new System.Drawing.Point(145, 385);
            this.carbOutput.Name = "carbOutput";
            this.carbOutput.Size = new System.Drawing.Size(59, 20);
            this.carbOutput.TabIndex = 7;
            this.carbOutput.Text = "Carbs: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(436, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter the amount of grams consumed per day";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "in the given boxes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(469, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.carbOutput);
            this.Controls.Add(this.fatOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.carbInput);
            this.Controls.Add(this.fatInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calories Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fatInput;
        private System.Windows.Forms.TextBox carbInput;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fatOutput;
        private System.Windows.Forms.Label carbOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


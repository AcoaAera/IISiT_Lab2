namespace Tests_Project__Lab_1_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SystemOutputTB = new System.Windows.Forms.TextBox();
            this.UserAnswerTB = new System.Windows.Forms.TextBox();
            this.UserAnswerBTN = new System.Windows.Forms.Button();
            this.YesRB = new System.Windows.Forms.RadioButton();
            this.NoRB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SystemResetBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SystemOutputTB
            // 
            this.SystemOutputTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SystemOutputTB.Location = new System.Drawing.Point(111, 14);
            this.SystemOutputTB.Multiline = true;
            this.SystemOutputTB.Name = "SystemOutputTB";
            this.SystemOutputTB.ReadOnly = true;
            this.SystemOutputTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SystemOutputTB.Size = new System.Drawing.Size(490, 185);
            this.SystemOutputTB.TabIndex = 0;
            // 
            // UserAnswerTB
            // 
            this.UserAnswerTB.Enabled = false;
            this.UserAnswerTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserAnswerTB.Location = new System.Drawing.Point(159, 239);
            this.UserAnswerTB.Multiline = true;
            this.UserAnswerTB.Name = "UserAnswerTB";
            this.UserAnswerTB.Size = new System.Drawing.Size(442, 32);
            this.UserAnswerTB.TabIndex = 1;
            // 
            // UserAnswerBTN
            // 
            this.UserAnswerBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserAnswerBTN.Location = new System.Drawing.Point(159, 299);
            this.UserAnswerBTN.Name = "UserAnswerBTN";
            this.UserAnswerBTN.Size = new System.Drawing.Size(143, 50);
            this.UserAnswerBTN.TabIndex = 2;
            this.UserAnswerBTN.Text = "Ответить";
            this.UserAnswerBTN.UseVisualStyleBackColor = true;
            this.UserAnswerBTN.Click += new System.EventHandler(this.UserAnswerBTN_Click);
            // 
            // YesRB
            // 
            this.YesRB.AutoSize = true;
            this.YesRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YesRB.Location = new System.Drawing.Point(15, 26);
            this.YesRB.Name = "YesRB";
            this.YesRB.Size = new System.Drawing.Size(47, 24);
            this.YesRB.TabIndex = 3;
            this.YesRB.TabStop = true;
            this.YesRB.Text = "да";
            this.YesRB.UseVisualStyleBackColor = true;
            this.YesRB.CheckedChanged += new System.EventHandler(this.YesRB_CheckedChanged);
            // 
            // NoRB
            // 
            this.NoRB.AutoSize = true;
            this.NoRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoRB.Location = new System.Drawing.Point(15, 56);
            this.NoRB.Name = "NoRB";
            this.NoRB.Size = new System.Drawing.Size(54, 24);
            this.NoRB.TabIndex = 4;
            this.NoRB.TabStop = true;
            this.NoRB.Text = "нет";
            this.NoRB.UseVisualStyleBackColor = true;
            this.NoRB.CheckedChanged += new System.EventHandler(this.NoRB_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Система:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 48);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ответ \r\nпользователя:";
            // 
            // SystemResetBTN
            // 
            this.SystemResetBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SystemResetBTN.Location = new System.Drawing.Point(159, 367);
            this.SystemResetBTN.Name = "SystemResetBTN";
            this.SystemResetBTN.Size = new System.Drawing.Size(143, 29);
            this.SystemResetBTN.TabIndex = 8;
            this.SystemResetBTN.Text = "Начать заново";
            this.SystemResetBTN.UseVisualStyleBackColor = true;
            this.SystemResetBTN.Click += new System.EventHandler(this.SystemResetBTN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NoRB);
            this.groupBox1.Controls.Add(this.YesRB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(339, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 94);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Упрощенные варианты ответа:";
            this.groupBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 408);
            this.Controls.Add(this.SystemResetBTN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserAnswerBTN);
            this.Controls.Add(this.UserAnswerTB);
            this.Controls.Add(this.SystemOutputTB);
            this.Name = "Form1";
            this.Text = "[LAB 0]";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SystemOutputTB;
        private System.Windows.Forms.TextBox UserAnswerTB;
        private System.Windows.Forms.Button UserAnswerBTN;
        private System.Windows.Forms.RadioButton YesRB;
        private System.Windows.Forms.RadioButton NoRB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SystemResetBTN;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


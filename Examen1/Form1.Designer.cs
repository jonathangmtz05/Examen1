﻿namespace Examen1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            butCalculo = new Button();
            openFileDialogAbrir = new OpenFileDialog();
            butAbrir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(628, 371);
            dataGridView1.TabIndex = 0;
            // 
            // butCalculo
            // 
            butCalculo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butCalculo.Location = new Point(12, 12);
            butCalculo.Name = "butCalculo";
            butCalculo.Size = new Size(94, 29);
            butCalculo.TabIndex = 1;
            butCalculo.Text = "Calcular";
            butCalculo.UseVisualStyleBackColor = true;
            butCalculo.Click += butCalculo_Click;
            // 
            // openFileDialogAbrir
            // 
            openFileDialogAbrir.FileName = "openFileDialog1";
            // 
            // butAbrir
            // 
            butAbrir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butAbrir.Location = new Point(158, 12);
            butAbrir.Name = "butAbrir";
            butAbrir.Size = new Size(94, 29);
            butAbrir.TabIndex = 2;
            butAbrir.Text = "Abrir";
            butAbrir.UseVisualStyleBackColor = true;
            butAbrir.Click += butAbrir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 450);
            Controls.Add(butAbrir);
            Controls.Add(butCalculo);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button butCalculo;
        private OpenFileDialog openFileDialogAbrir;
        private Button butAbrir;
    }
}

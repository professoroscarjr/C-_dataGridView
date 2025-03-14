namespace WinFormsApp2
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
            textNome = new TextBox();
            textEmail = new TextBox();
            button1 = new Button();
            dgvDados = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            SuspendLayout();
            // 
            // textNome
            // 
            textNome.Location = new Point(112, 66);
            textNome.Name = "textNome";
            textNome.Size = new Size(235, 23);
            textNome.TabIndex = 0;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(112, 133);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(235, 23);
            textEmail.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(404, 133);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Gravar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvDados
            // 
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(33, 216);
            dgvDados.Name = "dgvDados";
            dgvDados.Size = new Size(589, 150);
            dgvDados.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 33);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 115);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 5;
            label2.Text = "E-mail";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvDados);
            Controls.Add(button1);
            Controls.Add(textEmail);
            Controls.Add(textNome);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNome;
        private TextBox textEmail;
        private Button button1;
        private DataGridView dgvDados;
        private Label label1;
        private Label label2;
    }
}

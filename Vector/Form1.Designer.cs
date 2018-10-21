namespace Vector
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
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnGirarArriba = new System.Windows.Forms.Button();
            this.btnGirarAbajo = new System.Windows.Forms.Button();
            this.btnInvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(16, 157);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(200, 208);
            this.txtContent.TabIndex = 0;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(89, 14);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(58, 26);
            this.txtSize.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tamaño:";
            // 
            // btnCreate
            // 
            this.btnCreate.AutoSize = true;
            this.btnCreate.Location = new System.Drawing.Point(153, 12);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(63, 30);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Crear";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(87, 50);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(60, 26);
            this.txtNumber.TabIndex = 4;
            // 
            // btnFill
            // 
            this.btnFill.AutoSize = true;
            this.btnFill.Location = new System.Drawing.Point(153, 48);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(63, 30);
            this.btnFill.TabIndex = 6;
            this.btnFill.Text = "Llenar";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnShow
            // 
            this.btnShow.AutoSize = true;
            this.btnShow.Location = new System.Drawing.Point(16, 84);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(98, 30);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Mostrar";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnGirarArriba
            // 
            this.btnGirarArriba.AutoSize = true;
            this.btnGirarArriba.Location = new System.Drawing.Point(16, 120);
            this.btnGirarArriba.Name = "btnGirarArriba";
            this.btnGirarArriba.Size = new System.Drawing.Size(98, 30);
            this.btnGirarArriba.TabIndex = 8;
            this.btnGirarArriba.Text = "Girar arriba";
            this.btnGirarArriba.UseVisualStyleBackColor = true;
            this.btnGirarArriba.Click += new System.EventHandler(this.btnGirarArriba_Click);
            // 
            // btnGirarAbajo
            // 
            this.btnGirarAbajo.AutoSize = true;
            this.btnGirarAbajo.Location = new System.Drawing.Point(118, 120);
            this.btnGirarAbajo.Name = "btnGirarAbajo";
            this.btnGirarAbajo.Size = new System.Drawing.Size(98, 30);
            this.btnGirarAbajo.TabIndex = 9;
            this.btnGirarAbajo.Text = "Girar abajo";
            this.btnGirarAbajo.UseVisualStyleBackColor = true;
            this.btnGirarAbajo.Click += new System.EventHandler(this.btnGirarAbajo_Click);
            // 
            // btnInvertir
            // 
            this.btnInvertir.AutoSize = true;
            this.btnInvertir.Location = new System.Drawing.Point(118, 84);
            this.btnInvertir.Name = "btnInvertir";
            this.btnInvertir.Size = new System.Drawing.Size(98, 30);
            this.btnInvertir.TabIndex = 10;
            this.btnInvertir.Text = "Invertir";
            this.btnInvertir.UseVisualStyleBackColor = true;
            this.btnInvertir.Click += new System.EventHandler(this.btnInvertir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 376);
            this.Controls.Add(this.btnInvertir);
            this.Controls.Add(this.btnGirarAbajo);
            this.Controls.Add(this.btnGirarArriba);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtContent);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Vector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnGirarArriba;
        private System.Windows.Forms.Button btnGirarAbajo;
        private System.Windows.Forms.Button btnInvertir;
    }
}


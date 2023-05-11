
namespace Software
{
    partial class Memorama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Memorama));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_reinicio = new System.Windows.Forms.Button();
            this.lbl_texto = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_regresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 357);
            this.panel1.TabIndex = 0;
            // 
            // Btn_reinicio
            // 
            this.Btn_reinicio.BackColor = System.Drawing.Color.DarkGreen;
            this.Btn_reinicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_reinicio.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_reinicio.ForeColor = System.Drawing.Color.White;
            this.Btn_reinicio.Location = new System.Drawing.Point(610, 295);
            this.Btn_reinicio.Name = "Btn_reinicio";
            this.Btn_reinicio.Size = new System.Drawing.Size(116, 34);
            this.Btn_reinicio.TabIndex = 1;
            this.Btn_reinicio.Text = "Reiniciar";
            this.Btn_reinicio.UseVisualStyleBackColor = false;
            this.Btn_reinicio.Click += new System.EventHandler(this.Btn_reinicio_Click);
            // 
            // lbl_texto
            // 
            this.lbl_texto.AutoSize = true;
            this.lbl_texto.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_texto.Location = new System.Drawing.Point(582, 12);
            this.lbl_texto.Name = "lbl_texto";
            this.lbl_texto.Size = new System.Drawing.Size(122, 23);
            this.lbl_texto.TabIndex = 2;
            this.lbl_texto.Text = "Movimientos:";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero.Location = new System.Drawing.Point(704, 12);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(0, 23);
            this.lbl_numero.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.ForeColor = System.Drawing.Color.White;
            this.btn_regresar.Location = new System.Drawing.Point(610, 335);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(116, 34);
            this.btn_regresar.TabIndex = 4;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // Memorama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(752, 381);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.lbl_texto);
            this.Controls.Add(this.Btn_reinicio);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Memorama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memorama";
            this.Load += new System.EventHandler(this.Memorama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_reinicio;
        private System.Windows.Forms.Label lbl_texto;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_regresar;
    }
}
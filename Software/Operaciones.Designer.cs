
namespace Software
{
    partial class Operaciones
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
            this.lblMovesMade = new System.Windows.Forms.Label();
            this.lblNumA = new System.Windows.Forms.Label();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.lblNumB = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMovesMade
            // 
            this.lblMovesMade.AutoSize = true;
            this.lblMovesMade.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovesMade.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblMovesMade.Location = new System.Drawing.Point(420, 90);
            this.lblMovesMade.Name = "lblMovesMade";
            this.lblMovesMade.Size = new System.Drawing.Size(105, 23);
            this.lblMovesMade.TabIndex = 3;
            this.lblMovesMade.Text = "RECORD : 0";
            // 
            // lblNumA
            // 
            this.lblNumA.AutoSize = true;
            this.lblNumA.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumA.Location = new System.Drawing.Point(264, 186);
            this.lblNumA.Name = "lblNumA";
            this.lblNumA.Size = new System.Drawing.Size(49, 33);
            this.lblNumA.TabIndex = 4;
            this.lblNumA.Text = "00";
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbol.Location = new System.Drawing.Point(329, 186);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(33, 33);
            this.lblSymbol.TabIndex = 5;
            this.lblSymbol.Text = "+";
            // 
            // lblNumB
            // 
            this.lblNumB.AutoSize = true;
            this.lblNumB.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumB.Location = new System.Drawing.Point(368, 186);
            this.lblNumB.Name = "lblNumB";
            this.lblNumB.Size = new System.Drawing.Size(49, 33);
            this.lblNumB.TabIndex = 6;
            this.lblNumB.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(423, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "=";
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.BackColor = System.Drawing.Color.Transparent;
            this.answer.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer.ForeColor = System.Drawing.Color.ForestGreen;
            this.answer.Location = new System.Drawing.Point(218, 36);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(83, 23);
            this.answer.TabIndex = 8;
            this.answer.Text = "Correcto";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(462, 183);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(86, 40);
            this.txtAnswer.TabIndex = 9;
            this.txtAnswer.TextChanged += new System.EventHandler(this.CheckAnswer);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.DarkGreen;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(584, 183);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(86, 42);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "Revisar";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(612, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Operaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Software.Properties.Resources.letrerotote;
            this.ClientSize = new System.Drawing.Size(752, 381);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNumB);
            this.Controls.Add(this.lblSymbol);
            this.Controls.Add(this.lblNumA);
            this.Controls.Add(this.lblMovesMade);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Operaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones";
            this.Load += new System.EventHandler(this.Operaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMovesMade;
        private System.Windows.Forms.Label lblNumA;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.Label lblNumB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button button1;
    }
}
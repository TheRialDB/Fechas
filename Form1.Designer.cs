namespace Fechas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblDiaDeHoy = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblDiaDeMañ = new System.Windows.Forms.Label();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAnual = new System.Windows.Forms.TextBox();
            this.epvTextos = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epvTextos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(12, 115);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblDiaDeHoy
            // 
            this.lblDiaDeHoy.AutoSize = true;
            this.lblDiaDeHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaDeHoy.Location = new System.Drawing.Point(12, 9);
            this.lblDiaDeHoy.Name = "lblDiaDeHoy";
            this.lblDiaDeHoy.Size = new System.Drawing.Size(63, 13);
            this.lblDiaDeHoy.TabIndex = 1;
            this.lblDiaDeHoy.Text = "Si hoy es:";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(12, 73);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(35, 20);
            this.txtDia.TabIndex = 2;
            this.txtDia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDia_KeyPress);
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(12, 47);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(28, 13);
            this.lblDia.TabIndex = 3;
            this.lblDia.Text = "Día";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(75, 47);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(30, 13);
            this.lblMes.TabIndex = 4;
            this.lblMes.Text = "Mes";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(145, 47);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(29, 13);
            this.lblAño.TabIndex = 5;
            this.lblAño.Text = "Año";
            // 
            // lblDiaDeMañ
            // 
            this.lblDiaDeMañ.AutoSize = true;
            this.lblDiaDeMañ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaDeMañ.Location = new System.Drawing.Point(271, 9);
            this.lblDiaDeMañ.Name = "lblDiaDeMañ";
            this.lblDiaDeMañ.Size = new System.Drawing.Size(84, 13);
            this.lblDiaDeMañ.TabIndex = 6;
            this.lblDiaDeMañ.Text = "Mañana será:";
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.Location = new System.Drawing.Point(271, 80);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(0, 17);
            this.lblRespuesta.TabIndex = 7;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(78, 73);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(35, 20);
            this.txtMes.TabIndex = 8;
            this.txtMes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMes_KeyPress);
            // 
            // txtAnual
            // 
            this.txtAnual.Location = new System.Drawing.Point(148, 73);
            this.txtAnual.Name = "txtAnual";
            this.txtAnual.Size = new System.Drawing.Size(52, 20);
            this.txtAnual.TabIndex = 9;
            this.txtAnual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnual_KeyPress);
            // 
            // epvTextos
            // 
            this.epvTextos.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epvTextos.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 173);
            this.Controls.Add(this.txtAnual);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.lblDiaDeMañ);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.lblDiaDeHoy);
            this.Controls.Add(this.btnIngresar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.epvTextos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblDiaDeHoy;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblDiaDeMañ;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAnual;
        private System.Windows.Forms.ErrorProvider epvTextos;
    }
}


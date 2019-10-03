using DAO;
using System.Drawing;
using System.Windows.Forms;

namespace ValidacaoEtiquetas
{
    partial class Contador
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contador));
            this.LerEtiqueta = new System.Windows.Forms.Button();
            this.leituraCodigoBarras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LerEtiqueta
            // 
            this.LerEtiqueta.Location = new System.Drawing.Point(325, 77);
            this.LerEtiqueta.Name = "LerEtiqueta";
            this.LerEtiqueta.Size = new System.Drawing.Size(84, 25);
            this.LerEtiqueta.TabIndex = 1;
            this.LerEtiqueta.Text = "Confirmar";
            this.LerEtiqueta.UseVisualStyleBackColor = true;
            this.LerEtiqueta.Click += new System.EventHandler(this.button1_Click);
            // 
            // leituraCodigoBarras
            // 
            this.leituraCodigoBarras.Location = new System.Drawing.Point(12, 80);
            this.leituraCodigoBarras.Name = "leituraCodigoBarras";
            this.leituraCodigoBarras.Size = new System.Drawing.Size(307, 20);
            this.leituraCodigoBarras.TabIndex = 0;
            this.leituraCodigoBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.leituraCodigoBarras_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Leitura de Código de Barras";
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(12, 116);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(397, 329);
            this.lista.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Contador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 482);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leituraCodigoBarras);
            this.Controls.Add(this.LerEtiqueta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Contador";
            this.Text = "Validador de Etiquetas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Contador_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private void AddCustomDataTableStyle()
        {
            DataGridTableStyle ts1 = new DataGridTableStyle();
            ts1.MappingName = "Customers";
            // Set other properties.
            ts1.AlternatingBackColor = Color.LightGray;

        }

        private System.Windows.Forms.Button LerEtiqueta;
        private System.Windows.Forms.TextBox leituraCodigoBarras;
        private System.Windows.Forms.Label label1;
        private ListBox lista;
        private Button button1;
        private Label label2;
    }
}


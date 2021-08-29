
namespace MonitoramentoDeAnimais
{
    partial class FormMenu
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
            this.btRelatorio = new System.Windows.Forms.Button();
            this.btCadastrarAnimal = new System.Windows.Forms.Button();
            this.btExibir = new System.Windows.Forms.Button();
            this.btMonitorar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btRelatorio
            // 
            this.btRelatorio.Location = new System.Drawing.Point(252, 284);
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Size = new System.Drawing.Size(155, 107);
            this.btRelatorio.TabIndex = 0;
            this.btRelatorio.Text = "EMITIR RELATORIO";
            this.btRelatorio.UseVisualStyleBackColor = true;
            this.btRelatorio.Click += new System.EventHandler(this.BtRelatorio_Click);
            // 
            // btCadastrarAnimal
            // 
            this.btCadastrarAnimal.Location = new System.Drawing.Point(59, 284);
            this.btCadastrarAnimal.Name = "btCadastrarAnimal";
            this.btCadastrarAnimal.Size = new System.Drawing.Size(155, 107);
            this.btCadastrarAnimal.TabIndex = 1;
            this.btCadastrarAnimal.Text = "CADASTRAR ANIMAL";
            this.btCadastrarAnimal.UseVisualStyleBackColor = true;
            this.btCadastrarAnimal.Click += new System.EventHandler(this.BtCadastrarAnimal_Click);
            // 
            // btExibir
            // 
            this.btExibir.Location = new System.Drawing.Point(446, 284);
            this.btExibir.Name = "btExibir";
            this.btExibir.Size = new System.Drawing.Size(155, 107);
            this.btExibir.TabIndex = 2;
            this.btExibir.Text = "EXIBIR DADOS";
            this.btExibir.UseVisualStyleBackColor = true;
            this.btExibir.Click += new System.EventHandler(this.btExibir_Click);
            // 
            // btMonitorar
            // 
            this.btMonitorar.Location = new System.Drawing.Point(644, 284);
            this.btMonitorar.Name = "btMonitorar";
            this.btMonitorar.Size = new System.Drawing.Size(155, 107);
            this.btMonitorar.TabIndex = 3;
            this.btMonitorar.Text = "MONITORAR";
            this.btMonitorar.UseVisualStyleBackColor = true;
            this.btMonitorar.Click += new System.EventHandler(this.btMonitorar_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 497);
            this.Controls.Add(this.btMonitorar);
            this.Controls.Add(this.btExibir);
            this.Controls.Add(this.btCadastrarAnimal);
            this.Controls.Add(this.btRelatorio);
            this.Name = "FormMenu";
            this.Text = "Menu Inicial | TESTES DE FUNCIONALIDADES";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRelatorio;
        private System.Windows.Forms.Button btCadastrarAnimal;
        private System.Windows.Forms.Button btExibir;
        private System.Windows.Forms.Button btMonitorar;
    }
}


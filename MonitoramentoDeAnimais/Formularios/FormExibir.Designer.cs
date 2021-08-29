
namespace MonitoramentoDeAnimais.Formularios
{
    partial class FormExibir
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
            this.cbBuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.edNumeroIdPai = new System.Windows.Forms.TextBox();
            this.edNumeroIdMae = new System.Windows.Forms.TextBox();
            this.edNumeroId = new System.Windows.Forms.TextBox();
            this.edEstado = new System.Windows.Forms.TextBox();
            this.edDataNasc = new System.Windows.Forms.TextBox();
            this.edSexo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.edPeso = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbBuscar
            // 
            this.cbBuscar.FormattingEnabled = true;
            this.cbBuscar.Location = new System.Drawing.Point(54, 65);
            this.cbBuscar.Name = "cbBuscar";
            this.cbBuscar.Size = new System.Drawing.Size(209, 24);
            this.cbBuscar.TabIndex = 0;
            this.cbBuscar.SelectedIndexChanged += new System.EventHandler(this.cbBuscar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar por numero Id do animal";
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(307, 26);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(116, 63);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(479, 26);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(116, 63);
            this.btExcluir.TabIndex = 3;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // edNumeroIdPai
            // 
            this.edNumeroIdPai.Location = new System.Drawing.Point(553, 242);
            this.edNumeroIdPai.Name = "edNumeroIdPai";
            this.edNumeroIdPai.Size = new System.Drawing.Size(87, 22);
            this.edNumeroIdPai.TabIndex = 17;
            // 
            // edNumeroIdMae
            // 
            this.edNumeroIdMae.Location = new System.Drawing.Point(692, 242);
            this.edNumeroIdMae.Name = "edNumeroIdMae";
            this.edNumeroIdMae.Size = new System.Drawing.Size(87, 22);
            this.edNumeroIdMae.TabIndex = 16;
            // 
            // edNumeroId
            // 
            this.edNumeroId.Location = new System.Drawing.Point(292, 177);
            this.edNumeroId.Name = "edNumeroId";
            this.edNumeroId.Size = new System.Drawing.Size(174, 22);
            this.edNumeroId.TabIndex = 15;
            // 
            // edEstado
            // 
            this.edEstado.Location = new System.Drawing.Point(292, 243);
            this.edEstado.Name = "edEstado";
            this.edEstado.Size = new System.Drawing.Size(174, 22);
            this.edEstado.TabIndex = 14;
            // 
            // edDataNasc
            // 
            this.edDataNasc.Location = new System.Drawing.Point(53, 177);
            this.edDataNasc.Name = "edDataNasc";
            this.edDataNasc.Size = new System.Drawing.Size(174, 22);
            this.edDataNasc.TabIndex = 18;
            // 
            // edSexo
            // 
            this.edSexo.Location = new System.Drawing.Point(56, 242);
            this.edSexo.Name = "edSexo";
            this.edSexo.Size = new System.Drawing.Size(174, 22);
            this.edSexo.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Data nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Número de identificação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(689, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Id mãe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(550, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Id pai";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Sexo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(536, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Peso";
            // 
            // edPeso
            // 
            this.edPeso.Location = new System.Drawing.Point(539, 177);
            this.edPeso.Name = "edPeso";
            this.edPeso.Size = new System.Drawing.Size(174, 22);
            this.edPeso.TabIndex = 26;
            // 
            // FormExibir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 363);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.edPeso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edSexo);
            this.Controls.Add(this.edDataNasc);
            this.Controls.Add(this.edNumeroIdPai);
            this.Controls.Add(this.edNumeroIdMae);
            this.Controls.Add(this.edNumeroId);
            this.Controls.Add(this.edEstado);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBuscar);
            this.Name = "FormExibir";
            this.Text = "FormExibir";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.TextBox edNumeroIdPai;
        private System.Windows.Forms.TextBox edNumeroIdMae;
        private System.Windows.Forms.TextBox edNumeroId;
        private System.Windows.Forms.TextBox edEstado;
        private System.Windows.Forms.TextBox edDataNasc;
        private System.Windows.Forms.TextBox edSexo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox edPeso;
    }
}

namespace preparacionp
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
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.retirar = new System.Windows.Forms.Button();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.lblConductor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHoraconductorBuscado = new System.Windows.Forms.Label();
            this.txth = new System.Windows.Forms.TextBox();
            this.txtm = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblHoras = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblComentario = new System.Windows.Forms.Label();
            this.txtHorasEntrada = new System.Windows.Forms.TextBox();
            this.txtMinutosEntrada = new System.Windows.Forms.TextBox();
            this.txtdospuntos = new System.Windows.Forms.TextBox();
            this.lblHoraEntrada = new System.Windows.Forms.Label();
            this.lblHoraSalida = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtMinutosDeSalida = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtHoraDeSalida = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblAfiliado = new System.Windows.Forms.Label();
            this.cmbAfiliado = new System.Windows.Forms.ComboBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.lblFecha = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(213, 203);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(124, 24);
            this.txtMarca.TabIndex = 2;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(213, 147);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(124, 24);
            this.txtPlaca.TabIndex = 3;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(704, 91);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(124, 24);
            this.txtCedula.TabIndex = 4;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(351, 372);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(94, 26);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // retirar
            // 
            this.retirar.Location = new System.Drawing.Point(549, 372);
            this.retirar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.retirar.Name = "retirar";
            this.retirar.Size = new System.Drawing.Size(94, 26);
            this.retirar.TabIndex = 8;
            this.retirar.Text = "Facturar";
            this.retirar.UseVisualStyleBackColor = true;
            this.retirar.Click += new System.EventHandler(this.retirar_Click);
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Location = new System.Drawing.Point(133, 34);
            this.lblVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(164, 18);
            this.lblVehiculo.TabIndex = 9;
            this.lblVehiculo.Text = "Información vehiculo";
            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.Location = new System.Drawing.Point(610, 34);
            this.lblConductor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(181, 18);
            this.lblConductor.TabIndex = 10;
            this.lblConductor.Text = "Información Conductor";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblHoraconductorBuscado);
            this.panel1.Controls.Add(this.txth);
            this.panel1.Controls.Add(this.txtm);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.lblHoras);
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Controls.Add(this.lblComentario);
            this.panel1.Controls.Add(this.lblVehiculo);
            this.panel1.Controls.Add(this.retirar);
            this.panel1.Controls.Add(this.txtHorasEntrada);
            this.panel1.Controls.Add(this.btnIngresar);
            this.panel1.Controls.Add(this.txtMinutosEntrada);
            this.panel1.Controls.Add(this.txtMarca);
            this.panel1.Controls.Add(this.txtdospuntos);
            this.panel1.Controls.Add(this.txtPlaca);
            this.panel1.Controls.Add(this.lblHoraEntrada);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.lblHoraSalida);
            this.panel1.Controls.Add(this.lblConductor);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblTipo);
            this.panel1.Controls.Add(this.txtMinutosDeSalida);
            this.panel1.Controls.Add(this.lblMarca);
            this.panel1.Controls.Add(this.txtHoraDeSalida);
            this.panel1.Controls.Add(this.lblPlaca);
            this.panel1.Controls.Add(this.lblSexo);
            this.panel1.Controls.Add(this.lblCedula);
            this.panel1.Controls.Add(this.lblAfiliado);
            this.panel1.Controls.Add(this.cmbAfiliado);
            this.panel1.Controls.Add(this.cmbSexo);
            this.panel1.Location = new System.Drawing.Point(157, 157);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 415);
            this.panel1.TabIndex = 11;
            // 
            // lblHoraconductorBuscado
            // 
            this.lblHoraconductorBuscado.AutoSize = true;
            this.lblHoraconductorBuscado.Location = new System.Drawing.Point(50, 329);
            this.lblHoraconductorBuscado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraconductorBuscado.Name = "lblHoraconductorBuscado";
            this.lblHoraconductorBuscado.Size = new System.Drawing.Size(239, 18);
            this.lblHoraconductorBuscado.TabIndex = 40;
            this.lblHoraconductorBuscado.Text = "Hora llegada vehiculo buscado";
            // 
            // txth
            // 
            this.txth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txth.Location = new System.Drawing.Point(136, 350);
            this.txth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txth.Name = "txth";
            this.txth.ReadOnly = true;
            this.txth.Size = new System.Drawing.Size(31, 27);
            this.txth.TabIndex = 37;
            this.txth.Text = "00";
            // 
            // txtm
            // 
            this.txtm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtm.Location = new System.Drawing.Point(174, 350);
            this.txtm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtm.Name = "txtm";
            this.txtm.ReadOnly = true;
            this.txtm.Size = new System.Drawing.Size(31, 27);
            this.txtm.TabIndex = 38;
            this.txtm.Text = "00";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(165, 350);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(12, 27);
            this.textBox4.TabIndex = 39;
            this.textBox4.Text = ":";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.Location = new System.Drawing.Point(115, 294);
            this.lblHoras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(98, 17);
            this.lblHoras.TabIndex = 36;
            this.lblHoras.Text = "*Formato 24h*";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Por definir",
            "Camioneta",
            "Microbus",
            "Particular"});
            this.cmbTipo.Location = new System.Drawing.Point(213, 83);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 26);
            this.cmbTipo.TabIndex = 35;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentario.Location = new System.Drawing.Point(573, 281);
            this.lblComentario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(119, 17);
            this.lblComentario.TabIndex = 34;
            this.lblComentario.Text = "*solo para Retiro*";
            // 
            // txtHorasEntrada
            // 
            this.txtHorasEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasEntrada.Location = new System.Drawing.Point(213, 264);
            this.txtHorasEntrada.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHorasEntrada.Name = "txtHorasEntrada";
            this.txtHorasEntrada.ReadOnly = true;
            this.txtHorasEntrada.Size = new System.Drawing.Size(30, 27);
            this.txtHorasEntrada.TabIndex = 23;
            this.txtHorasEntrada.Text = "00";
            // 
            // txtMinutosEntrada
            // 
            this.txtMinutosEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinutosEntrada.Location = new System.Drawing.Point(251, 264);
            this.txtMinutosEntrada.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMinutosEntrada.Name = "txtMinutosEntrada";
            this.txtMinutosEntrada.ReadOnly = true;
            this.txtMinutosEntrada.Size = new System.Drawing.Size(30, 27);
            this.txtMinutosEntrada.TabIndex = 24;
            this.txtMinutosEntrada.Text = "00";
            // 
            // txtdospuntos
            // 
            this.txtdospuntos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdospuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdospuntos.Location = new System.Drawing.Point(242, 264);
            this.txtdospuntos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtdospuntos.Name = "txtdospuntos";
            this.txtdospuntos.ReadOnly = true;
            this.txtdospuntos.Size = new System.Drawing.Size(11, 27);
            this.txtdospuntos.TabIndex = 25;
            this.txtdospuntos.Text = ":";
            // 
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.AutoSize = true;
            this.lblHoraEntrada.Location = new System.Drawing.Point(50, 268);
            this.lblHoraEntrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.Size = new System.Drawing.Size(95, 18);
            this.lblHoraEntrada.TabIndex = 33;
            this.lblHoraEntrada.Text = "Hora actual";
            // 
            // lblHoraSalida
            // 
            this.lblHoraSalida.AutoSize = true;
            this.lblHoraSalida.Location = new System.Drawing.Point(573, 263);
            this.lblHoraSalida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraSalida.Name = "lblHoraSalida";
            this.lblHoraSalida.Size = new System.Drawing.Size(117, 18);
            this.lblHoraSalida.TabIndex = 32;
            this.lblHoraSalida.Text = "Hora de saldia";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(732, 259);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(10, 27);
            this.textBox1.TabIndex = 31;
            this.textBox1.Text = ":";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(50, 91);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(41, 18);
            this.lblTipo.TabIndex = 12;
            this.lblTipo.Text = "Tipo";
            // 
            // txtMinutosDeSalida
            // 
            this.txtMinutosDeSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinutosDeSalida.Location = new System.Drawing.Point(741, 259);
            this.txtMinutosDeSalida.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMinutosDeSalida.Name = "txtMinutosDeSalida";
            this.txtMinutosDeSalida.ReadOnly = true;
            this.txtMinutosDeSalida.Size = new System.Drawing.Size(27, 27);
            this.txtMinutosDeSalida.TabIndex = 30;
            this.txtMinutosDeSalida.Text = "00";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(50, 203);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(55, 18);
            this.lblMarca.TabIndex = 13;
            this.lblMarca.Text = "Marca";
            // 
            // txtHoraDeSalida
            // 
            this.txtHoraDeSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraDeSalida.Location = new System.Drawing.Point(704, 259);
            this.txtHoraDeSalida.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHoraDeSalida.Name = "txtHoraDeSalida";
            this.txtHoraDeSalida.ReadOnly = true;
            this.txtHoraDeSalida.Size = new System.Drawing.Size(29, 27);
            this.txtHoraDeSalida.TabIndex = 29;
            this.txtHoraDeSalida.Text = "00";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(50, 150);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(50, 18);
            this.lblPlaca.TabIndex = 14;
            this.lblPlaca.Text = "Placa";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(573, 152);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(46, 18);
            this.lblSexo.TabIndex = 15;
            this.lblSexo.Text = "Sexo";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(573, 91);
            this.lblCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(60, 18);
            this.lblCedula.TabIndex = 16;
            this.lblCedula.Text = "Cedula";
            // 
            // lblAfiliado
            // 
            this.lblAfiliado.AutoSize = true;
            this.lblAfiliado.Location = new System.Drawing.Point(573, 209);
            this.lblAfiliado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAfiliado.Name = "lblAfiliado";
            this.lblAfiliado.Size = new System.Drawing.Size(63, 18);
            this.lblAfiliado.TabIndex = 17;
            this.lblAfiliado.Text = "Afiliado";
            // 
            // cmbAfiliado
            // 
            this.cmbAfiliado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAfiliado.FormattingEnabled = true;
            this.cmbAfiliado.Items.AddRange(new object[] {
            "Por establecer",
            "SI",
            "No"});
            this.cmbAfiliado.Location = new System.Drawing.Point(704, 209);
            this.cmbAfiliado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbAfiliado.Name = "cmbAfiliado";
            this.cmbAfiliado.Size = new System.Drawing.Size(124, 26);
            this.cmbAfiliado.TabIndex = 19;
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Otro",
            "Hombre",
            "Mujer"});
            this.cmbSexo.Location = new System.Drawing.Point(704, 152);
            this.cmbSexo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(124, 26);
            this.cmbSexo.TabIndex = 18;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(527, 125);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(192, 26);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar Para retirar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(561, 77);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(124, 24);
            this.txtBuscar.TabIndex = 21;
            this.txtBuscar.Text = "placa o cedula";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(591, 38);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(61, 18);
            this.lblBuscar.TabIndex = 22;
            this.lblBuscar.Text = "Buscar";
            // 
            // tiempo
            // 
            this.tiempo.Interval = 10;
            this.tiempo.Tick += new System.EventHandler(this.tiempo_Tick);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(376, 595);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 18);
            this.lblFecha.TabIndex = 23;
            this.lblFecha.Text = "Fecha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1334, 623);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Ingresos/Retiros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button retirar;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.Label lblConductor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblAfiliado;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.ComboBox cmbAfiliado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtHorasEntrada;
        private System.Windows.Forms.TextBox txtMinutosEntrada;
        private System.Windows.Forms.TextBox txtdospuntos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtMinutosDeSalida;
        private System.Windows.Forms.TextBox txtHoraDeSalida;
        private System.Windows.Forms.Label lblHoraSalida;
        private System.Windows.Forms.Label lblHoraEntrada;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Timer tiempo;
        private System.Windows.Forms.TextBox txth;
        private System.Windows.Forms.TextBox txtm;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblHoraconductorBuscado;
        private System.Windows.Forms.Label lblFecha;
    }
}


namespace MensajesQueue
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
            this.txtmensaje = new System.Windows.Forms.TextBox();
            this.cmbusuarios = new System.Windows.Forms.ComboBox();
            this.lsvmensajes = new System.Windows.Forms.ListView();
            this.btnultimomensaje = new System.Windows.Forms.Button();
            this.btntodosmensajes = new System.Windows.Forms.Button();
            this.btncrearmensaje = new System.Windows.Forms.Button();
            this.btnborrarmensaje = new System.Windows.Forms.Button();
            this.btnmodificarmensaje = new System.Windows.Forms.Button();
            this.btnborrartareas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Mensajes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblmensaje = new System.Windows.Forms.Label();
            this.btngenerartoken = new System.Windows.Forms.Button();
            this.btnmensajessas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtmensaje
            // 
            this.txtmensaje.Location = new System.Drawing.Point(63, 49);
            this.txtmensaje.Multiline = true;
            this.txtmensaje.Name = "txtmensaje";
            this.txtmensaje.Size = new System.Drawing.Size(416, 154);
            this.txtmensaje.TabIndex = 0;
            // 
            // cmbusuarios
            // 
            this.cmbusuarios.FormattingEnabled = true;
            this.cmbusuarios.Items.AddRange(new object[] {
            "tareas1",
            "tareas2"});
            this.cmbusuarios.Location = new System.Drawing.Point(80, 267);
            this.cmbusuarios.Name = "cmbusuarios";
            this.cmbusuarios.Size = new System.Drawing.Size(121, 28);
            this.cmbusuarios.TabIndex = 1;
            // 
            // lsvmensajes
            // 
            this.lsvmensajes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Mensajes});
            this.lsvmensajes.Location = new System.Drawing.Point(79, 438);
            this.lsvmensajes.Name = "lsvmensajes";
            this.lsvmensajes.Size = new System.Drawing.Size(583, 133);
            this.lsvmensajes.TabIndex = 2;
            this.lsvmensajes.UseCompatibleStateImageBehavior = false;
            this.lsvmensajes.View = System.Windows.Forms.View.Details;
            // 
            // btnultimomensaje
            // 
            this.btnultimomensaje.Location = new System.Drawing.Point(79, 343);
            this.btnultimomensaje.Name = "btnultimomensaje";
            this.btnultimomensaje.Size = new System.Drawing.Size(122, 63);
            this.btnultimomensaje.TabIndex = 3;
            this.btnultimomensaje.Text = "Último mensaje";
            this.btnultimomensaje.UseVisualStyleBackColor = true;
            this.btnultimomensaje.Click += new System.EventHandler(this.btnultimomensaje_Click);
            // 
            // btntodosmensajes
            // 
            this.btntodosmensajes.Location = new System.Drawing.Point(285, 343);
            this.btntodosmensajes.Name = "btntodosmensajes";
            this.btntodosmensajes.Size = new System.Drawing.Size(131, 63);
            this.btntodosmensajes.TabIndex = 4;
            this.btntodosmensajes.Text = "Todos los mensajes";
            this.btntodosmensajes.UseVisualStyleBackColor = true;
            this.btntodosmensajes.Click += new System.EventHandler(this.btntodosmensajes_Click);
            // 
            // btncrearmensaje
            // 
            this.btncrearmensaje.Location = new System.Drawing.Point(519, 36);
            this.btncrearmensaje.Name = "btncrearmensaje";
            this.btncrearmensaje.Size = new System.Drawing.Size(143, 70);
            this.btncrearmensaje.TabIndex = 5;
            this.btncrearmensaje.Text = "Crear Mensaje";
            this.btncrearmensaje.UseVisualStyleBackColor = true;
            this.btncrearmensaje.Click += new System.EventHandler(this.btncrearmensaje_Click);
            // 
            // btnborrarmensaje
            // 
            this.btnborrarmensaje.Location = new System.Drawing.Point(519, 230);
            this.btnborrarmensaje.Name = "btnborrarmensaje";
            this.btnborrarmensaje.Size = new System.Drawing.Size(143, 73);
            this.btnborrarmensaje.TabIndex = 6;
            this.btnborrarmensaje.Text = "Borrar mensaje";
            this.btnborrarmensaje.UseVisualStyleBackColor = true;
            this.btnborrarmensaje.Click += new System.EventHandler(this.btnborrarmensaje_Click);
            // 
            // btnmodificarmensaje
            // 
            this.btnmodificarmensaje.Location = new System.Drawing.Point(519, 133);
            this.btnmodificarmensaje.Name = "btnmodificarmensaje";
            this.btnmodificarmensaje.Size = new System.Drawing.Size(143, 70);
            this.btnmodificarmensaje.TabIndex = 7;
            this.btnmodificarmensaje.Text = "modificar mensaje";
            this.btnmodificarmensaje.UseVisualStyleBackColor = true;
            this.btnmodificarmensaje.Click += new System.EventHandler(this.btnmodificarmensaje_Click);
            // 
            // btnborrartareas
            // 
            this.btnborrartareas.Location = new System.Drawing.Point(506, 336);
            this.btnborrartareas.Name = "btnborrartareas";
            this.btnborrartareas.Size = new System.Drawing.Size(156, 70);
            this.btnborrartareas.TabIndex = 8;
            this.btnborrartareas.Text = "borrar tareas";
            this.btnborrartareas.UseVisualStyleBackColor = true;
            this.btnborrartareas.Click += new System.EventHandler(this.btnborrartareas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mensaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "usuarios";
            // 
            // Mensajes
            // 
            this.Mensajes.Text = "Mensajes";
            this.Mensajes.Width = 573;
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(95, 578);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(51, 20);
            this.lblmensaje.TabIndex = 11;
            this.lblmensaje.Text = "label3";
            // 
            // btngenerartoken
            // 
            this.btngenerartoken.Location = new System.Drawing.Point(683, 36);
            this.btngenerartoken.Name = "btngenerartoken";
            this.btngenerartoken.Size = new System.Drawing.Size(108, 70);
            this.btngenerartoken.TabIndex = 12;
            this.btngenerartoken.Text = "Generar Token";
            this.btngenerartoken.UseVisualStyleBackColor = true;
            this.btngenerartoken.Click += new System.EventHandler(this.btngenerartoken_Click);
            // 
            // btnmensajessas
            // 
            this.btnmensajessas.Location = new System.Drawing.Point(683, 133);
            this.btnmensajessas.Name = "btnmensajessas";
            this.btnmensajessas.Size = new System.Drawing.Size(108, 70);
            this.btnmensajessas.TabIndex = 13;
            this.btnmensajessas.Text = "Mensajes SAS";
            this.btnmensajessas.UseVisualStyleBackColor = true;
            this.btnmensajessas.Click += new System.EventHandler(this.btnmensajessas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 658);
            this.Controls.Add(this.btnmensajessas);
            this.Controls.Add(this.btngenerartoken);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnborrartareas);
            this.Controls.Add(this.btnmodificarmensaje);
            this.Controls.Add(this.btnborrarmensaje);
            this.Controls.Add(this.btncrearmensaje);
            this.Controls.Add(this.btntodosmensajes);
            this.Controls.Add(this.btnultimomensaje);
            this.Controls.Add(this.lsvmensajes);
            this.Controls.Add(this.cmbusuarios);
            this.Controls.Add(this.txtmensaje);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmensaje;
        private System.Windows.Forms.ComboBox cmbusuarios;
        private System.Windows.Forms.ListView lsvmensajes;
        private System.Windows.Forms.ColumnHeader Mensajes;
        private System.Windows.Forms.Button btnultimomensaje;
        private System.Windows.Forms.Button btntodosmensajes;
        private System.Windows.Forms.Button btncrearmensaje;
        private System.Windows.Forms.Button btnborrarmensaje;
        private System.Windows.Forms.Button btnmodificarmensaje;
        private System.Windows.Forms.Button btnborrartareas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Button btngenerartoken;
        private System.Windows.Forms.Button btnmensajessas;
    }
}


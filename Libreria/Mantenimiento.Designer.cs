namespace Libreria
{
    partial class MantenimeintoF
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
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tabNacionalidad = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRecargarNacionalidad = new System.Windows.Forms.Button();
            this.btnEliminarNacionalidad = new System.Windows.Forms.Button();
            this.btnAgregarNacionalidad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.tabEditorial = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRecargarEditorial = new System.Windows.Forms.Button();
            this.btnEliminarEditorial = new System.Windows.Forms.Button();
            this.btnAgregarEditorial = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.tabAutor = new System.Windows.Forms.TabPage();
            this.cmbNacionalidad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRecargarAutor = new System.Windows.Forms.Button();
            this.btnEliminarAutor = new System.Windows.Forms.Button();
            this.btnAgregarAutor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage.SuspendLayout();
            this.tabNacionalidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabEditorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabAutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.tabNacionalidad);
            this.tabPage.Controls.Add(this.tabEditorial);
            this.tabPage.Controls.Add(this.tabAutor);
            this.tabPage.Location = new System.Drawing.Point(37, 57);
            this.tabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(973, 537);
            this.tabPage.TabIndex = 0;
            // 
            // tabNacionalidad
            // 
            this.tabNacionalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.tabNacionalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabNacionalidad.Controls.Add(this.dataGridView3);
            this.tabNacionalidad.Controls.Add(this.btnRecargarNacionalidad);
            this.tabNacionalidad.Controls.Add(this.btnEliminarNacionalidad);
            this.tabNacionalidad.Controls.Add(this.btnAgregarNacionalidad);
            this.tabNacionalidad.Controls.Add(this.label1);
            this.tabNacionalidad.Controls.Add(this.txtNacionalidad);
            this.tabNacionalidad.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F);
            this.tabNacionalidad.Location = new System.Drawing.Point(4, 25);
            this.tabNacionalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabNacionalidad.Name = "tabNacionalidad";
            this.tabNacionalidad.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabNacionalidad.Size = new System.Drawing.Size(965, 508);
            this.tabNacionalidad.TabIndex = 0;
            this.tabNacionalidad.Text = "Nacionalidad";
            this.tabNacionalidad.Enter += new System.EventHandler(this.tabNacionalidad_Enter);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(136)))), ((int)(((byte)(138)))));
            this.dataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.dataGridView3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dataGridView3.Location = new System.Drawing.Point(489, 94);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(429, 382);
            this.dataGridView3.TabIndex = 8;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnRecargarNacionalidad
            // 
            this.btnRecargarNacionalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(37)))), ((int)(((byte)(24)))));
            this.btnRecargarNacionalidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecargarNacionalidad.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F);
            this.btnRecargarNacionalidad.ForeColor = System.Drawing.Color.White;
            this.btnRecargarNacionalidad.Location = new System.Drawing.Point(781, 30);
            this.btnRecargarNacionalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRecargarNacionalidad.Name = "btnRecargarNacionalidad";
            this.btnRecargarNacionalidad.Size = new System.Drawing.Size(139, 46);
            this.btnRecargarNacionalidad.TabIndex = 5;
            this.btnRecargarNacionalidad.Text = "Recargar";
            this.btnRecargarNacionalidad.UseVisualStyleBackColor = false;
            this.btnRecargarNacionalidad.Click += new System.EventHandler(this.btnRecargarNacionalidad_Click);
            // 
            // btnEliminarNacionalidad
            // 
            this.btnEliminarNacionalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(37)))), ((int)(((byte)(24)))));
            this.btnEliminarNacionalidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarNacionalidad.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F);
            this.btnEliminarNacionalidad.ForeColor = System.Drawing.Color.White;
            this.btnEliminarNacionalidad.Location = new System.Drawing.Point(269, 238);
            this.btnEliminarNacionalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarNacionalidad.Name = "btnEliminarNacionalidad";
            this.btnEliminarNacionalidad.Size = new System.Drawing.Size(139, 46);
            this.btnEliminarNacionalidad.TabIndex = 4;
            this.btnEliminarNacionalidad.Text = "Eliminar";
            this.btnEliminarNacionalidad.UseVisualStyleBackColor = false;
            this.btnEliminarNacionalidad.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregarNacionalidad
            // 
            this.btnAgregarNacionalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(37)))), ((int)(((byte)(24)))));
            this.btnAgregarNacionalidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarNacionalidad.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F);
            this.btnAgregarNacionalidad.ForeColor = System.Drawing.Color.White;
            this.btnAgregarNacionalidad.Location = new System.Drawing.Point(49, 238);
            this.btnAgregarNacionalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarNacionalidad.Name = "btnAgregarNacionalidad";
            this.btnAgregarNacionalidad.Size = new System.Drawing.Size(139, 46);
            this.btnAgregarNacionalidad.TabIndex = 3;
            this.btnAgregarNacionalidad.Text = "Agregar";
            this.btnAgregarNacionalidad.UseVisualStyleBackColor = false;
            this.btnAgregarNacionalidad.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nacionalidad:";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.txtNacionalidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNacionalidad.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNacionalidad.ForeColor = System.Drawing.Color.White;
            this.txtNacionalidad.Location = new System.Drawing.Point(51, 106);
            this.txtNacionalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(283, 25);
            this.txtNacionalidad.TabIndex = 0;
            this.txtNacionalidad.Text = "_____________________________";
            this.txtNacionalidad.Enter += new System.EventHandler(this.txtNacionalidad_Enter);
            // 
            // tabEditorial
            // 
            this.tabEditorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.tabEditorial.Controls.Add(this.dataGridView1);
            this.tabEditorial.Controls.Add(this.btnRecargarEditorial);
            this.tabEditorial.Controls.Add(this.btnEliminarEditorial);
            this.tabEditorial.Controls.Add(this.btnAgregarEditorial);
            this.tabEditorial.Controls.Add(this.label2);
            this.tabEditorial.Controls.Add(this.txtEditorial);
            this.tabEditorial.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F);
            this.tabEditorial.Location = new System.Drawing.Point(4, 25);
            this.tabEditorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEditorial.Name = "tabEditorial";
            this.tabEditorial.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEditorial.Size = new System.Drawing.Size(965, 508);
            this.tabEditorial.TabIndex = 1;
            this.tabEditorial.Text = "Editoriales";
            this.tabEditorial.Enter += new System.EventHandler(this.tabEditorial_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(136)))), ((int)(((byte)(138)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dataGridView1.Location = new System.Drawing.Point(489, 94);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(429, 382);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnRecargarEditorial
            // 
            this.btnRecargarEditorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(37)))), ((int)(((byte)(24)))));
            this.btnRecargarEditorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecargarEditorial.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F);
            this.btnRecargarEditorial.ForeColor = System.Drawing.Color.White;
            this.btnRecargarEditorial.Location = new System.Drawing.Point(781, 30);
            this.btnRecargarEditorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRecargarEditorial.Name = "btnRecargarEditorial";
            this.btnRecargarEditorial.Size = new System.Drawing.Size(139, 46);
            this.btnRecargarEditorial.TabIndex = 11;
            this.btnRecargarEditorial.Text = "Recargar";
            this.btnRecargarEditorial.UseVisualStyleBackColor = false;
            this.btnRecargarEditorial.Click += new System.EventHandler(this.btnRecargarEditorial_Click);
            // 
            // btnEliminarEditorial
            // 
            this.btnEliminarEditorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(37)))), ((int)(((byte)(24)))));
            this.btnEliminarEditorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarEditorial.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F);
            this.btnEliminarEditorial.ForeColor = System.Drawing.Color.White;
            this.btnEliminarEditorial.Location = new System.Drawing.Point(269, 238);
            this.btnEliminarEditorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarEditorial.Name = "btnEliminarEditorial";
            this.btnEliminarEditorial.Size = new System.Drawing.Size(139, 46);
            this.btnEliminarEditorial.TabIndex = 10;
            this.btnEliminarEditorial.Text = "Eliminar";
            this.btnEliminarEditorial.UseVisualStyleBackColor = false;
            this.btnEliminarEditorial.Click += new System.EventHandler(this.btnEliminarEditorial_Click);
            // 
            // btnAgregarEditorial
            // 
            this.btnAgregarEditorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(37)))), ((int)(((byte)(24)))));
            this.btnAgregarEditorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarEditorial.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F);
            this.btnAgregarEditorial.ForeColor = System.Drawing.Color.White;
            this.btnAgregarEditorial.Location = new System.Drawing.Point(49, 238);
            this.btnAgregarEditorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarEditorial.Name = "btnAgregarEditorial";
            this.btnAgregarEditorial.Size = new System.Drawing.Size(139, 46);
            this.btnAgregarEditorial.TabIndex = 9;
            this.btnAgregarEditorial.Text = "Agregar";
            this.btnAgregarEditorial.UseVisualStyleBackColor = false;
            this.btnAgregarEditorial.Click += new System.EventHandler(this.btnAgregarEditorial_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre de la editorial:";
            // 
            // txtEditorial
            // 
            this.txtEditorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.txtEditorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditorial.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditorial.ForeColor = System.Drawing.Color.White;
            this.txtEditorial.Location = new System.Drawing.Point(51, 106);
            this.txtEditorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(283, 25);
            this.txtEditorial.TabIndex = 6;
            this.txtEditorial.Text = "_____________________________";
            this.txtEditorial.Enter += new System.EventHandler(this.txtEditorial_Enter);
            // 
            // tabAutor
            // 
            this.tabAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.tabAutor.Controls.Add(this.cmbNacionalidad);
            this.tabAutor.Controls.Add(this.label4);
            this.tabAutor.Controls.Add(this.btnRecargarAutor);
            this.tabAutor.Controls.Add(this.btnEliminarAutor);
            this.tabAutor.Controls.Add(this.btnAgregarAutor);
            this.tabAutor.Controls.Add(this.label3);
            this.tabAutor.Controls.Add(this.dataGridView2);
            this.tabAutor.Controls.Add(this.txtAutor);
            this.tabAutor.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F);
            this.tabAutor.Location = new System.Drawing.Point(4, 25);
            this.tabAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAutor.Name = "tabAutor";
            this.tabAutor.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAutor.Size = new System.Drawing.Size(965, 508);
            this.tabAutor.TabIndex = 2;
            this.tabAutor.Text = "Autores";
            this.tabAutor.Enter += new System.EventHandler(this.tabAutor_Enter);
            // 
            // cmbNacionalidad
            // 
            this.cmbNacionalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.cmbNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNacionalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNacionalidad.ForeColor = System.Drawing.Color.White;
            this.cmbNacionalidad.FormattingEnabled = true;
            this.cmbNacionalidad.Location = new System.Drawing.Point(51, 252);
            this.cmbNacionalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNacionalidad.Name = "cmbNacionalidad";
            this.cmbNacionalidad.Size = new System.Drawing.Size(281, 33);
            this.cmbNacionalidad.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(45, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nacionalidad:";
            // 
            // btnRecargarAutor
            // 
            this.btnRecargarAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(37)))), ((int)(((byte)(24)))));
            this.btnRecargarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecargarAutor.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F);
            this.btnRecargarAutor.ForeColor = System.Drawing.Color.White;
            this.btnRecargarAutor.Location = new System.Drawing.Point(781, 30);
            this.btnRecargarAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRecargarAutor.Name = "btnRecargarAutor";
            this.btnRecargarAutor.Size = new System.Drawing.Size(139, 46);
            this.btnRecargarAutor.TabIndex = 11;
            this.btnRecargarAutor.Text = "Recargar";
            this.btnRecargarAutor.UseVisualStyleBackColor = false;
            this.btnRecargarAutor.Click += new System.EventHandler(this.btnRecargarAutor_Click);
            // 
            // btnEliminarAutor
            // 
            this.btnEliminarAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(37)))), ((int)(((byte)(24)))));
            this.btnEliminarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarAutor.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F);
            this.btnEliminarAutor.ForeColor = System.Drawing.Color.White;
            this.btnEliminarAutor.Location = new System.Drawing.Point(271, 370);
            this.btnEliminarAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarAutor.Name = "btnEliminarAutor";
            this.btnEliminarAutor.Size = new System.Drawing.Size(139, 46);
            this.btnEliminarAutor.TabIndex = 10;
            this.btnEliminarAutor.Text = "Eliminar";
            this.btnEliminarAutor.UseVisualStyleBackColor = false;
            this.btnEliminarAutor.Click += new System.EventHandler(this.btnEliminarAutor_Click);
            // 
            // btnAgregarAutor
            // 
            this.btnAgregarAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(37)))), ((int)(((byte)(24)))));
            this.btnAgregarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarAutor.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F);
            this.btnAgregarAutor.ForeColor = System.Drawing.Color.White;
            this.btnAgregarAutor.Location = new System.Drawing.Point(51, 370);
            this.btnAgregarAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarAutor.Name = "btnAgregarAutor";
            this.btnAgregarAutor.Size = new System.Drawing.Size(139, 46);
            this.btnAgregarAutor.TabIndex = 9;
            this.btnAgregarAutor.Text = "Agregar";
            this.btnAgregarAutor.UseVisualStyleBackColor = false;
            this.btnAgregarAutor.Click += new System.EventHandler(this.btnAgregarAutor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(136)))), ((int)(((byte)(138)))));
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Nacionalidad});
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dataGridView2.Location = new System.Drawing.Point(488, 94);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(429, 382);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.HeaderText = "Nacionalidad";
            this.Nacionalidad.MinimumWidth = 6;
            this.Nacionalidad.Name = "Nacionalidad";
            this.Nacionalidad.ReadOnly = true;
            // 
            // txtAutor
            // 
            this.txtAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.txtAutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAutor.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.ForeColor = System.Drawing.Color.White;
            this.txtAutor.Location = new System.Drawing.Point(51, 106);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(283, 25);
            this.txtAutor.TabIndex = 6;
            this.txtAutor.Text = "_____________________________";
            this.txtAutor.Enter += new System.EventHandler(this.txtAutor_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(37, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "< REGRESAR";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // MantenimeintoF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1052, 633);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MantenimeintoF";
            this.Text = "                                                                               ";
            this.Load += new System.EventHandler(this.MantenimeintoF_Load);
            this.tabPage.ResumeLayout(false);
            this.tabNacionalidad.ResumeLayout(false);
            this.tabNacionalidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabEditorial.ResumeLayout(false);
            this.tabEditorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabAutor.ResumeLayout(false);
            this.tabAutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage tabNacionalidad;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.Button btnRecargarNacionalidad;
        private System.Windows.Forms.Button btnEliminarNacionalidad;
        private System.Windows.Forms.Button btnAgregarNacionalidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabEditorial;
        private System.Windows.Forms.TabPage tabAutor;
        private System.Windows.Forms.Button btnRecargarEditorial;
        private System.Windows.Forms.Button btnEliminarEditorial;
        private System.Windows.Forms.Button btnAgregarEditorial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.ComboBox cmbNacionalidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRecargarAutor;
        private System.Windows.Forms.Button btnEliminarAutor;
        private System.Windows.Forms.Button btnAgregarAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacionalidad;
        private System.Windows.Forms.Label label5;
    }
}


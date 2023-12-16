
namespace Examen_de__Reposición_by_Kim
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.añoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nummotorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numchasisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblvehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbparquevehicularFunesKimberlyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_parque_vehicular_Funes_KimberlyDataSet = new Examen_de__Reposición_by_Kim.db_parque_vehicular_Funes_KimberlyDataSet();
            this.tbl_vehiculosTableAdapter = new Examen_de__Reposición_by_Kim.db_parque_vehicular_Funes_KimberlyDataSetTableAdapters.tbl_vehiculosTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seleccioneVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jeepCompassSportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jeepRenegadeLatitudeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jeepCherokeeTrailhawkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jeepGrandCherokeeLimitedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jeepWranglerSportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblNumDeChasis = new System.Windows.Forms.Label();
            this.lblNumDeMotor = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.grbEdicionAlumno = new System.Windows.Forms.GroupBox();
            this.btnEliminarVehiculo = new System.Windows.Forms.Button();
            this.btnModificarVehiculo = new System.Windows.Forms.Button();
            this.btnNuevoVehiculo = new System.Windows.Forms.Button();
            this.grbNavegacionAlumno = new System.Windows.Forms.GroupBox();
            this.lblnRegistroAlumno = new System.Windows.Forms.Label();
            this.btnUltimoVehiculo = new System.Windows.Forms.Button();
            this.btnSiguienteVehiculo = new System.Windows.Forms.Button();
            this.btnAnteriorVehiculo = new System.Windows.Forms.Button();
            this.btnPrimeroVehiculo = new System.Windows.Forms.Button();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblvehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbparquevehicularFunesKimberlyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_parque_vehicular_Funes_KimberlyDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grbEdicionAlumno.SuspendLayout();
            this.grbNavegacionAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVehiculoDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.añoDataGridViewTextBoxColumn,
            this.nummotorDataGridViewTextBoxColumn,
            this.numchasisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblvehiculosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(93, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idVehiculoDataGridViewTextBoxColumn
            // 
            this.idVehiculoDataGridViewTextBoxColumn.DataPropertyName = "idVehiculo";
            this.idVehiculoDataGridViewTextBoxColumn.HeaderText = "idVehiculo";
            this.idVehiculoDataGridViewTextBoxColumn.Name = "idVehiculoDataGridViewTextBoxColumn";
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            // 
            // añoDataGridViewTextBoxColumn
            // 
            this.añoDataGridViewTextBoxColumn.DataPropertyName = "año";
            this.añoDataGridViewTextBoxColumn.HeaderText = "año";
            this.añoDataGridViewTextBoxColumn.Name = "añoDataGridViewTextBoxColumn";
            // 
            // nummotorDataGridViewTextBoxColumn
            // 
            this.nummotorDataGridViewTextBoxColumn.DataPropertyName = "num_motor";
            this.nummotorDataGridViewTextBoxColumn.HeaderText = "num_motor";
            this.nummotorDataGridViewTextBoxColumn.Name = "nummotorDataGridViewTextBoxColumn";
            // 
            // numchasisDataGridViewTextBoxColumn
            // 
            this.numchasisDataGridViewTextBoxColumn.DataPropertyName = "num_chasis";
            this.numchasisDataGridViewTextBoxColumn.HeaderText = "num_chasis";
            this.numchasisDataGridViewTextBoxColumn.Name = "numchasisDataGridViewTextBoxColumn";
            // 
            // tblvehiculosBindingSource
            // 
            this.tblvehiculosBindingSource.DataMember = "tbl_vehiculos";
            this.tblvehiculosBindingSource.DataSource = this.dbparquevehicularFunesKimberlyDataSetBindingSource;
            // 
            // dbparquevehicularFunesKimberlyDataSetBindingSource
            // 
            this.dbparquevehicularFunesKimberlyDataSetBindingSource.DataSource = this.db_parque_vehicular_Funes_KimberlyDataSet;
            this.dbparquevehicularFunesKimberlyDataSetBindingSource.Position = 0;
            // 
            // db_parque_vehicular_Funes_KimberlyDataSet
            // 
            this.db_parque_vehicular_Funes_KimberlyDataSet.DataSetName = "db_parque_vehicular_Funes_KimberlyDataSet";
            this.db_parque_vehicular_Funes_KimberlyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_vehiculosTableAdapter
            // 
            this.tbl_vehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seleccioneVehiculoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seleccioneVehiculoToolStripMenuItem
            // 
            this.seleccioneVehiculoToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.seleccioneVehiculoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jeepCompassSportToolStripMenuItem,
            this.jeepRenegadeLatitudeToolStripMenuItem,
            this.jeepCherokeeTrailhawkToolStripMenuItem,
            this.jeepGrandCherokeeLimitedToolStripMenuItem,
            this.jeepWranglerSportToolStripMenuItem});
            this.seleccioneVehiculoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.seleccioneVehiculoToolStripMenuItem.Name = "seleccioneVehiculoToolStripMenuItem";
            this.seleccioneVehiculoToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.seleccioneVehiculoToolStripMenuItem.Text = "Seleccione Vehiculo";
            // 
            // jeepCompassSportToolStripMenuItem
            // 
            this.jeepCompassSportToolStripMenuItem.Name = "jeepCompassSportToolStripMenuItem";
            this.jeepCompassSportToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.jeepCompassSportToolStripMenuItem.Text = "Jeep Compass Sport";
            this.jeepCompassSportToolStripMenuItem.Click += new System.EventHandler(this.jeepCompassSportToolStripMenuItem_Click);
            // 
            // jeepRenegadeLatitudeToolStripMenuItem
            // 
            this.jeepRenegadeLatitudeToolStripMenuItem.Name = "jeepRenegadeLatitudeToolStripMenuItem";
            this.jeepRenegadeLatitudeToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.jeepRenegadeLatitudeToolStripMenuItem.Text = "Jeep Renegade Latitude";
            this.jeepRenegadeLatitudeToolStripMenuItem.Click += new System.EventHandler(this.jeepRenegadeLatitudeToolStripMenuItem_Click);
            // 
            // jeepCherokeeTrailhawkToolStripMenuItem
            // 
            this.jeepCherokeeTrailhawkToolStripMenuItem.Name = "jeepCherokeeTrailhawkToolStripMenuItem";
            this.jeepCherokeeTrailhawkToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.jeepCherokeeTrailhawkToolStripMenuItem.Text = "Jeep Cherokee Trailhawk";
            this.jeepCherokeeTrailhawkToolStripMenuItem.Click += new System.EventHandler(this.jeepCherokeeTrailhawkToolStripMenuItem_Click);
            // 
            // jeepGrandCherokeeLimitedToolStripMenuItem
            // 
            this.jeepGrandCherokeeLimitedToolStripMenuItem.Name = "jeepGrandCherokeeLimitedToolStripMenuItem";
            this.jeepGrandCherokeeLimitedToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.jeepGrandCherokeeLimitedToolStripMenuItem.Text = "Jeep Grand Cherokee Limited";
            this.jeepGrandCherokeeLimitedToolStripMenuItem.Click += new System.EventHandler(this.jeepGrandCherokeeLimitedToolStripMenuItem_Click);
            // 
            // jeepWranglerSportToolStripMenuItem
            // 
            this.jeepWranglerSportToolStripMenuItem.Name = "jeepWranglerSportToolStripMenuItem";
            this.jeepWranglerSportToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.jeepWranglerSportToolStripMenuItem.Text = "Jeep Wrangler Sport";
            this.jeepWranglerSportToolStripMenuItem.Click += new System.EventHandler(this.jeepWranglerSportToolStripMenuItem_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(25, 47);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(60, 31);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // lblNumDeChasis
            // 
            this.lblNumDeChasis.AutoSize = true;
            this.lblNumDeChasis.BackColor = System.Drawing.Color.Transparent;
            this.lblNumDeChasis.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDeChasis.ForeColor = System.Drawing.Color.White;
            this.lblNumDeChasis.Location = new System.Drawing.Point(25, 171);
            this.lblNumDeChasis.Name = "lblNumDeChasis";
            this.lblNumDeChasis.Size = new System.Drawing.Size(142, 31);
            this.lblNumDeChasis.TabIndex = 3;
            this.lblNumDeChasis.Text = "Numero de chasis";
            // 
            // lblNumDeMotor
            // 
            this.lblNumDeMotor.AutoSize = true;
            this.lblNumDeMotor.BackColor = System.Drawing.Color.Transparent;
            this.lblNumDeMotor.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDeMotor.ForeColor = System.Drawing.Color.White;
            this.lblNumDeMotor.Location = new System.Drawing.Point(25, 140);
            this.lblNumDeMotor.Name = "lblNumDeMotor";
            this.lblNumDeMotor.Size = new System.Drawing.Size(145, 31);
            this.lblNumDeMotor.TabIndex = 4;
            this.lblNumDeMotor.Text = "Numero de motor";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.BackColor = System.Drawing.Color.Transparent;
            this.lblAño.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.ForeColor = System.Drawing.Color.White;
            this.lblAño.Location = new System.Drawing.Point(25, 109);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(45, 31);
            this.lblAño.TabIndex = 5;
            this.lblAño.Text = "Año";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.BackColor = System.Drawing.Color.Transparent;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.White;
            this.lblModelo.Location = new System.Drawing.Point(25, 78);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(70, 31);
            this.lblModelo.TabIndex = 6;
            this.lblModelo.Text = "Modelo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(67, 117);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(164, 146);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(206, 20);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(164, 177);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(206, 20);
            this.textBox5.TabIndex = 11;
            // 
            // grbEdicionAlumno
            // 
            this.grbEdicionAlumno.Controls.Add(this.btnEliminarVehiculo);
            this.grbEdicionAlumno.Controls.Add(this.btnModificarVehiculo);
            this.grbEdicionAlumno.Controls.Add(this.btnNuevoVehiculo);
            this.grbEdicionAlumno.Location = new System.Drawing.Point(456, 227);
            this.grbEdicionAlumno.Name = "grbEdicionAlumno";
            this.grbEdicionAlumno.Size = new System.Drawing.Size(281, 73);
            this.grbEdicionAlumno.TabIndex = 13;
            this.grbEdicionAlumno.TabStop = false;
            this.grbEdicionAlumno.Text = "Edicion";
            // 
            // btnEliminarVehiculo
            // 
            this.btnEliminarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarVehiculo.ForeColor = System.Drawing.Color.Red;
            this.btnEliminarVehiculo.Location = new System.Drawing.Point(192, 33);
            this.btnEliminarVehiculo.Name = "btnEliminarVehiculo";
            this.btnEliminarVehiculo.Size = new System.Drawing.Size(85, 38);
            this.btnEliminarVehiculo.TabIndex = 9;
            this.btnEliminarVehiculo.Text = "Eliminar";
            this.btnEliminarVehiculo.UseVisualStyleBackColor = true;
            this.btnEliminarVehiculo.Click += new System.EventHandler(this.btnEliminarVehiculo_Click);
            // 
            // btnModificarVehiculo
            // 
            this.btnModificarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarVehiculo.Location = new System.Drawing.Point(88, 33);
            this.btnModificarVehiculo.Name = "btnModificarVehiculo";
            this.btnModificarVehiculo.Size = new System.Drawing.Size(95, 38);
            this.btnModificarVehiculo.TabIndex = 8;
            this.btnModificarVehiculo.Text = "Modificar";
            this.btnModificarVehiculo.UseVisualStyleBackColor = true;
            this.btnModificarVehiculo.Click += new System.EventHandler(this.btnModificarVehiculo_Click);
            // 
            // btnNuevoVehiculo
            // 
            this.btnNuevoVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoVehiculo.Location = new System.Drawing.Point(6, 33);
            this.btnNuevoVehiculo.Name = "btnNuevoVehiculo";
            this.btnNuevoVehiculo.Size = new System.Drawing.Size(83, 38);
            this.btnNuevoVehiculo.TabIndex = 7;
            this.btnNuevoVehiculo.Text = "Nuevo";
            this.btnNuevoVehiculo.UseVisualStyleBackColor = true;
            this.btnNuevoVehiculo.Click += new System.EventHandler(this.btnNuevoVehiculo_Click);
            // 
            // grbNavegacionAlumno
            // 
            this.grbNavegacionAlumno.Controls.Add(this.lblnRegistroAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnUltimoVehiculo);
            this.grbNavegacionAlumno.Controls.Add(this.btnSiguienteVehiculo);
            this.grbNavegacionAlumno.Controls.Add(this.btnAnteriorVehiculo);
            this.grbNavegacionAlumno.Controls.Add(this.btnPrimeroVehiculo);
            this.grbNavegacionAlumno.Location = new System.Drawing.Point(91, 227);
            this.grbNavegacionAlumno.Name = "grbNavegacionAlumno";
            this.grbNavegacionAlumno.Size = new System.Drawing.Size(229, 73);
            this.grbNavegacionAlumno.TabIndex = 12;
            this.grbNavegacionAlumno.TabStop = false;
            this.grbNavegacionAlumno.Text = "Navegacion";
            // 
            // lblnRegistroAlumno
            // 
            this.lblnRegistroAlumno.AutoSize = true;
            this.lblnRegistroAlumno.Location = new System.Drawing.Point(75, 47);
            this.lblnRegistroAlumno.Name = "lblnRegistroAlumno";
            this.lblnRegistroAlumno.Size = new System.Drawing.Size(36, 13);
            this.lblnRegistroAlumno.TabIndex = 6;
            this.lblnRegistroAlumno.Text = "x de n";
            // 
            // btnUltimoVehiculo
            // 
            this.btnUltimoVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoVehiculo.Location = new System.Drawing.Point(187, 33);
            this.btnUltimoVehiculo.Name = "btnUltimoVehiculo";
            this.btnUltimoVehiculo.Size = new System.Drawing.Size(33, 38);
            this.btnUltimoVehiculo.TabIndex = 3;
            this.btnUltimoVehiculo.Text = ">|";
            this.btnUltimoVehiculo.UseVisualStyleBackColor = true;
            // 
            // btnSiguienteVehiculo
            // 
            this.btnSiguienteVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteVehiculo.Location = new System.Drawing.Point(156, 33);
            this.btnSiguienteVehiculo.Name = "btnSiguienteVehiculo";
            this.btnSiguienteVehiculo.Size = new System.Drawing.Size(33, 38);
            this.btnSiguienteVehiculo.TabIndex = 2;
            this.btnSiguienteVehiculo.Text = ">";
            this.btnSiguienteVehiculo.UseVisualStyleBackColor = true;
            // 
            // btnAnteriorVehiculo
            // 
            this.btnAnteriorVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorVehiculo.Location = new System.Drawing.Point(36, 33);
            this.btnAnteriorVehiculo.Name = "btnAnteriorVehiculo";
            this.btnAnteriorVehiculo.Size = new System.Drawing.Size(33, 38);
            this.btnAnteriorVehiculo.TabIndex = 1;
            this.btnAnteriorVehiculo.Text = "<";
            this.btnAnteriorVehiculo.UseVisualStyleBackColor = true;
            // 
            // btnPrimeroVehiculo
            // 
            this.btnPrimeroVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroVehiculo.Location = new System.Drawing.Point(5, 33);
            this.btnPrimeroVehiculo.Name = "btnPrimeroVehiculo";
            this.btnPrimeroVehiculo.Size = new System.Drawing.Size(33, 38);
            this.btnPrimeroVehiculo.TabIndex = 0;
            this.btnPrimeroVehiculo.Text = "|<";
            this.btnPrimeroVehiculo.UseVisualStyleBackColor = true;
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 479);
            this.Controls.Add(this.grbEdicionAlumno);
            this.Controls.Add(this.grbNavegacionAlumno);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblNumDeMotor);
            this.Controls.Add(this.lblNumDeChasis);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Vehiculos by Kim Registro";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblvehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbparquevehicularFunesKimberlyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_parque_vehicular_Funes_KimberlyDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbEdicionAlumno.ResumeLayout(false);
            this.grbNavegacionAlumno.ResumeLayout(false);
            this.grbNavegacionAlumno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private db_parque_vehicular_Funes_KimberlyDataSet db_parque_vehicular_Funes_KimberlyDataSet;
        private System.Windows.Forms.BindingSource dbparquevehicularFunesKimberlyDataSetBindingSource;
        private System.Windows.Forms.BindingSource tblvehiculosBindingSource;
        private db_parque_vehicular_Funes_KimberlyDataSetTableAdapters.tbl_vehiculosTableAdapter tbl_vehiculosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn añoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nummotorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numchasisDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seleccioneVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jeepCompassSportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jeepRenegadeLatitudeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jeepCherokeeTrailhawkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jeepGrandCherokeeLimitedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jeepWranglerSportToolStripMenuItem;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblNumDeChasis;
        private System.Windows.Forms.Label lblNumDeMotor;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox grbEdicionAlumno;
        private System.Windows.Forms.Button btnEliminarVehiculo;
        private System.Windows.Forms.Button btnModificarVehiculo;
        private System.Windows.Forms.Button btnNuevoVehiculo;
        private System.Windows.Forms.GroupBox grbNavegacionAlumno;
        private System.Windows.Forms.Label lblnRegistroAlumno;
        private System.Windows.Forms.Button btnUltimoVehiculo;
        private System.Windows.Forms.Button btnSiguienteVehiculo;
        private System.Windows.Forms.Button btnAnteriorVehiculo;
        private System.Windows.Forms.Button btnPrimeroVehiculo;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}
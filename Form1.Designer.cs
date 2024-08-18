namespace Nori_player
{
    partial class Nori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nori));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.labelchannel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkOnlyMusic = new System.Windows.Forms.CheckBox();
            this.buttonFilePath = new System.Windows.Forms.Button();
            this.Time_video = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.TextFilePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboCalidadVideo = new System.Windows.Forms.ComboBox();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textUrl = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listViewMusictPlaylist = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.LabelTotalMusic = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textUrl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 681);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelTotalMusic);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.listViewMusictPlaylist);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.webBrowser1);
            this.groupBox1.Controls.Add(this.labelchannel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkOnlyMusic);
            this.groupBox1.Controls.Add(this.buttonFilePath);
            this.groupBox1.Controls.Add(this.Time_video);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Guardar);
            this.groupBox1.Controls.Add(this.TextFilePath);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboCalidadVideo);
            this.groupBox1.Controls.Add(this.textTitle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1240, 560);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion del video";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(98, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "LISTA DE MUSICA";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(6, 19);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(566, 250);
            this.webBrowser1.TabIndex = 17;
            // 
            // labelchannel
            // 
            this.labelchannel.AutoSize = true;
            this.labelchannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelchannel.ForeColor = System.Drawing.Color.White;
            this.labelchannel.Location = new System.Drawing.Point(707, 85);
            this.labelchannel.Name = "labelchannel";
            this.labelchannel.Size = new System.Drawing.Size(133, 20);
            this.labelchannel.TabIndex = 16;
            this.labelchannel.Text = "Sin informacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(942, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "TIEMPO";
            // 
            // checkOnlyMusic
            // 
            this.checkOnlyMusic.AutoSize = true;
            this.checkOnlyMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOnlyMusic.ForeColor = System.Drawing.Color.White;
            this.checkOnlyMusic.Location = new System.Drawing.Point(729, 419);
            this.checkOnlyMusic.Name = "checkOnlyMusic";
            this.checkOnlyMusic.Size = new System.Drawing.Size(150, 24);
            this.checkOnlyMusic.TabIndex = 13;
            this.checkOnlyMusic.Text = "SOLO MUSICA";
            this.checkOnlyMusic.UseVisualStyleBackColor = true;
            // 
            // buttonFilePath
            // 
            this.buttonFilePath.Location = new System.Drawing.Point(1024, 319);
            this.buttonFilePath.Name = "buttonFilePath";
            this.buttonFilePath.Size = new System.Drawing.Size(129, 23);
            this.buttonFilePath.TabIndex = 12;
            this.buttonFilePath.Text = "RUTA DE CARPETA";
            this.buttonFilePath.UseVisualStyleBackColor = true;
            this.buttonFilePath.Click += new System.EventHandler(this.buttonFilePath_Click);
            // 
            // Time_video
            // 
            this.Time_video.AutoSize = true;
            this.Time_video.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_video.ForeColor = System.Drawing.Color.White;
            this.Time_video.Location = new System.Drawing.Point(1020, 85);
            this.Time_video.Name = "Time_video";
            this.Time_video.Size = new System.Drawing.Size(79, 20);
            this.Time_video.TabIndex = 11;
            this.Time_video.Text = "00:00:00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(634, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "CANAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(707, 504);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(337, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "CREADO POR JHONATAN FERNANDEZ";
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(902, 409);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(115, 45);
            this.Guardar.TabIndex = 8;
            this.Guardar.Text = "DESCARAGAR";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // TextFilePath
            // 
            this.TextFilePath.Location = new System.Drawing.Point(602, 319);
            this.TextFilePath.Name = "TextFilePath";
            this.TextFilePath.Size = new System.Drawing.Size(415, 20);
            this.TextFilePath.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(751, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "RUTA A GUARDAR";
            // 
            // comboCalidadVideo
            // 
            this.comboCalidadVideo.FormattingEnabled = true;
            this.comboCalidadVideo.Location = new System.Drawing.Point(902, 183);
            this.comboCalidadVideo.Name = "comboCalidadVideo";
            this.comboCalidadVideo.Size = new System.Drawing.Size(233, 21);
            this.comboCalidadVideo.TabIndex = 4;
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(593, 50);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(547, 20);
            this.textTitle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(657, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CALIDAD DEL VIDEO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(837, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TITULO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Obtener informacion del video";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textUrl
            // 
            this.textUrl.Location = new System.Drawing.Point(232, 27);
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(715, 20);
            this.textUrl.TabIndex = 0;
            this.textUrl.Text = "Ingrese url";
            // 
            // listViewMusictPlaylist
            // 
            this.listViewMusictPlaylist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewMusictPlaylist.HideSelection = false;
            this.listViewMusictPlaylist.Location = new System.Drawing.Point(6, 319);
            this.listViewMusictPlaylist.Name = "listViewMusictPlaylist";
            this.listViewMusictPlaylist.Size = new System.Drawing.Size(566, 205);
            this.listViewMusictPlaylist.TabIndex = 19;
            this.listViewMusictPlaylist.UseCompatibleStateImageBehavior = false;
            this.listViewMusictPlaylist.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "NOMBRE";
            this.columnHeader4.Width = 230;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "AUTOR";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "TIEMPO";
            this.columnHeader6.Width = 100;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(285, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "TOTAL CANCIONES";
            // 
            // LabelTotalMusic
            // 
            this.LabelTotalMusic.AutoSize = true;
            this.LabelTotalMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalMusic.ForeColor = System.Drawing.Color.White;
            this.LabelTotalMusic.Location = new System.Drawing.Point(463, 281);
            this.LabelTotalMusic.Name = "LabelTotalMusic";
            this.LabelTotalMusic.Size = new System.Drawing.Size(19, 20);
            this.LabelTotalMusic.TabIndex = 21;
            this.LabelTotalMusic.Text = "0";
            // 
            // Nori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Nori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nory player";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textUrl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboCalidadVideo;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.TextBox TextFilePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Time_video;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkOnlyMusic;
        private System.Windows.Forms.Button buttonFilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelchannel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ListView listViewMusictPlaylist;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label LabelTotalMusic;
        private System.Windows.Forms.Label label8;
    }
}


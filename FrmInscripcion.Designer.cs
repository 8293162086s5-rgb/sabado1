namespace AppModeloCapas
{
    partial class FrmInscripcion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtHorai = new System.Windows.Forms.TextBox();
            this.txtFechai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDetallei = new System.Windows.Forms.GroupBox();
            this.dgvDetallei = new System.Windows.Forms.DataGridView();
            this.gbEstudiantesi = new System.Windows.Forms.GroupBox();
            this.btnBuscari = new System.Windows.Forms.Button();
            this.txtCedulai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombrei = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbAñadirCursoi = new System.Windows.Forms.GroupBox();
            this.btnAgregari = new System.Windows.Forms.Button();
            this.txtDescripcioni = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodigoi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCursoi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtComentarioi = new System.Windows.Forms.TextBox();
            this.btnProcesari = new System.Windows.Forms.Button();
            this.btnCancelari = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbDetallei.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallei)).BeginInit();
            this.gbEstudiantesi.SuspendLayout();
            this.gbAñadirCursoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 103);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtHorai);
            this.panel2.Controls.Add(this.txtFechai);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(566, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 80);
            this.panel2.TabIndex = 2;
            // 
            // txtHorai
            // 
            this.txtHorai.Location = new System.Drawing.Point(69, 48);
            this.txtHorai.Name = "txtHorai";
            this.txtHorai.Size = new System.Drawing.Size(150, 20);
            this.txtHorai.TabIndex = 3;
            // 
            // txtFechai
            // 
            this.txtFechai.Location = new System.Drawing.Point(69, 21);
            this.txtFechai.Name = "txtFechai";
            this.txtFechai.Size = new System.Drawing.Size(150, 20);
            this.txtFechai.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inscripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "University System";
            // 
            // gbDetallei
            // 
            this.gbDetallei.Controls.Add(this.dgvDetallei);
            this.gbDetallei.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetallei.Location = new System.Drawing.Point(430, 109);
            this.gbDetallei.Name = "gbDetallei";
            this.gbDetallei.Size = new System.Drawing.Size(375, 407);
            this.gbDetallei.TabIndex = 1;
            this.gbDetallei.TabStop = false;
            this.gbDetallei.Text = "Detalle de la Inscripcion ";
            this.gbDetallei.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgvDetallei
            // 
            this.dgvDetallei.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallei.Location = new System.Drawing.Point(7, 19);
            this.dgvDetallei.Name = "dgvDetallei";
            this.dgvDetallei.Size = new System.Drawing.Size(362, 381);
            this.dgvDetallei.TabIndex = 0;
            // 
            // gbEstudiantesi
            // 
            this.gbEstudiantesi.Controls.Add(this.btnBuscari);
            this.gbEstudiantesi.Controls.Add(this.txtCedulai);
            this.gbEstudiantesi.Controls.Add(this.label7);
            this.gbEstudiantesi.Controls.Add(this.txtIDi);
            this.gbEstudiantesi.Controls.Add(this.label6);
            this.gbEstudiantesi.Controls.Add(this.txtNombrei);
            this.gbEstudiantesi.Controls.Add(this.label5);
            this.gbEstudiantesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEstudiantesi.Location = new System.Drawing.Point(12, 109);
            this.gbEstudiantesi.Name = "gbEstudiantesi";
            this.gbEstudiantesi.Size = new System.Drawing.Size(411, 100);
            this.gbEstudiantesi.TabIndex = 2;
            this.gbEstudiantesi.TabStop = false;
            this.gbEstudiantesi.Text = "Datos del Estudiante";
            // 
            // btnBuscari
            // 
            this.btnBuscari.Location = new System.Drawing.Point(336, 30);
            this.btnBuscari.Name = "btnBuscari";
            this.btnBuscari.Size = new System.Drawing.Size(75, 64);
            this.btnBuscari.TabIndex = 6;
            this.btnBuscari.Text = "Buscar";
            this.btnBuscari.UseVisualStyleBackColor = true;
            // 
            // txtCedulai
            // 
            this.txtCedulai.Location = new System.Drawing.Point(201, 71);
            this.txtCedulai.Name = "txtCedulai";
            this.txtCedulai.Size = new System.Drawing.Size(132, 22);
            this.txtCedulai.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cedula";
            // 
            // txtIDi
            // 
            this.txtIDi.Location = new System.Drawing.Point(69, 68);
            this.txtIDi.Name = "txtIDi";
            this.txtIDi.Size = new System.Drawing.Size(70, 22);
            this.txtIDi.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "ID";
            // 
            // txtNombrei
            // 
            this.txtNombrei.Location = new System.Drawing.Point(69, 30);
            this.txtNombrei.Name = "txtNombrei";
            this.txtNombrei.Size = new System.Drawing.Size(264, 22);
            this.txtNombrei.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre";
            // 
            // gbAñadirCursoi
            // 
            this.gbAñadirCursoi.Controls.Add(this.btnAgregari);
            this.gbAñadirCursoi.Controls.Add(this.txtDescripcioni);
            this.gbAñadirCursoi.Controls.Add(this.label10);
            this.gbAñadirCursoi.Controls.Add(this.txtCodigoi);
            this.gbAñadirCursoi.Controls.Add(this.label9);
            this.gbAñadirCursoi.Controls.Add(this.txtCursoi);
            this.gbAñadirCursoi.Controls.Add(this.label8);
            this.gbAñadirCursoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAñadirCursoi.Location = new System.Drawing.Point(12, 215);
            this.gbAñadirCursoi.Name = "gbAñadirCursoi";
            this.gbAñadirCursoi.Size = new System.Drawing.Size(410, 147);
            this.gbAñadirCursoi.TabIndex = 3;
            this.gbAñadirCursoi.TabStop = false;
            this.gbAñadirCursoi.Text = "Añadir Curso/Asignatura";
            // 
            // btnAgregari
            // 
            this.btnAgregari.Location = new System.Drawing.Point(315, 61);
            this.btnAgregari.Name = "btnAgregari";
            this.btnAgregari.Size = new System.Drawing.Size(89, 54);
            this.btnAgregari.TabIndex = 6;
            this.btnAgregari.Text = "Agregar";
            this.btnAgregari.UseVisualStyleBackColor = true;
            // 
            // txtDescripcioni
            // 
            this.txtDescripcioni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcioni.Location = new System.Drawing.Point(86, 61);
            this.txtDescripcioni.Multiline = true;
            this.txtDescripcioni.Name = "txtDescripcioni";
            this.txtDescripcioni.Size = new System.Drawing.Size(200, 68);
            this.txtDescripcioni.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Descripcion";
            // 
            // txtCodigoi
            // 
            this.txtCodigoi.Location = new System.Drawing.Point(315, 23);
            this.txtCodigoi.Name = "txtCodigoi";
            this.txtCodigoi.Size = new System.Drawing.Size(89, 22);
            this.txtCodigoi.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(258, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Codigo";
            // 
            // txtCursoi
            // 
            this.txtCursoi.Location = new System.Drawing.Point(58, 22);
            this.txtCursoi.Name = "txtCursoi";
            this.txtCursoi.Size = new System.Drawing.Size(194, 22);
            this.txtCursoi.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Curso";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 379);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Comentario";
            // 
            // txtComentarioi
            // 
            this.txtComentarioi.Location = new System.Drawing.Point(95, 379);
            this.txtComentarioi.Multiline = true;
            this.txtComentarioi.Name = "txtComentarioi";
            this.txtComentarioi.Size = new System.Drawing.Size(203, 114);
            this.txtComentarioi.TabIndex = 5;
            // 
            // btnProcesari
            // 
            this.btnProcesari.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnProcesari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesari.Location = new System.Drawing.Point(327, 379);
            this.btnProcesari.Name = "btnProcesari";
            this.btnProcesari.Size = new System.Drawing.Size(97, 46);
            this.btnProcesari.TabIndex = 6;
            this.btnProcesari.Text = "Procesar";
            this.btnProcesari.UseVisualStyleBackColor = false;
            // 
            // btnCancelari
            // 
            this.btnCancelari.BackColor = System.Drawing.Color.Salmon;
            this.btnCancelari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelari.Location = new System.Drawing.Point(327, 453);
            this.btnCancelari.Name = "btnCancelari";
            this.btnCancelari.Size = new System.Drawing.Size(97, 40);
            this.btnCancelari.TabIndex = 7;
            this.btnCancelari.Text = "Cancelar";
            this.btnCancelari.UseVisualStyleBackColor = false;
            // 
            // FrmInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 523);
            this.Controls.Add(this.btnCancelari);
            this.Controls.Add(this.btnProcesari);
            this.Controls.Add(this.txtComentarioi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gbAñadirCursoi);
            this.Controls.Add(this.gbEstudiantesi);
            this.Controls.Add(this.gbDetallei);
            this.Controls.Add(this.panel1);
            this.Name = "FrmInscripcion";
            this.Text = "FrmInscripcion";
            this.Load += new System.EventHandler(this.FrmInscripcion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbDetallei.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallei)).EndInit();
            this.gbEstudiantesi.ResumeLayout(false);
            this.gbEstudiantesi.PerformLayout();
            this.gbAñadirCursoi.ResumeLayout(false);
            this.gbAñadirCursoi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFechai;
        private System.Windows.Forms.TextBox txtHorai;
        private System.Windows.Forms.GroupBox gbDetallei;
        private System.Windows.Forms.DataGridView dgvDetallei;
        private System.Windows.Forms.GroupBox gbEstudiantesi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscari;
        private System.Windows.Forms.TextBox txtCedulai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIDi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombrei;
        private System.Windows.Forms.GroupBox gbAñadirCursoi;
        private System.Windows.Forms.TextBox txtDescripcioni;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodigoi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCursoi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAgregari;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtComentarioi;
        private System.Windows.Forms.Button btnProcesari;
        private System.Windows.Forms.Button btnCancelari;
    }
}
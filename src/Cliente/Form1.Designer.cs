namespace Cliente
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabInteractions = new TabPage();
            groupBox2 = new GroupBox();
            lstView = new ListView();
            Numero = new ColumnHeader();
            Ocorrencia = new ColumnHeader();
            lblStatus = new Label();
            groupBox1 = new GroupBox();
            txtNumberOfInteractions = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtValue = new TextBox();
            cmdExecute = new Button();
            tabControl1.SuspendLayout();
            tabInteractions.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabInteractions);
            tabControl1.Location = new Point(26, 30);
            tabControl1.Margin = new Padding(6, 7, 6, 7);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1202, 1159);
            tabControl1.TabIndex = 9;
            // 
            // tabInteractions
            // 
            tabInteractions.Controls.Add(groupBox2);
            tabInteractions.Controls.Add(groupBox1);
            tabInteractions.Location = new Point(10, 55);
            tabInteractions.Margin = new Padding(6, 7, 6, 7);
            tabInteractions.Name = "tabInteractions";
            tabInteractions.Padding = new Padding(6, 7, 6, 7);
            tabInteractions.Size = new Size(1182, 1094);
            tabInteractions.TabIndex = 0;
            tabInteractions.Text = "Interações";
            tabInteractions.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstView);
            groupBox2.Controls.Add(lblStatus);
            groupBox2.Location = new Point(13, 303);
            groupBox2.Margin = new Padding(6, 7, 6, 7);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(6, 7, 6, 7);
            groupBox2.Size = new Size(1151, 762);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Saída";
            // 
            // lstView
            // 
            lstView.Columns.AddRange(new ColumnHeader[] { Numero, Ocorrencia });
            lstView.FullRowSelect = true;
            lstView.GridLines = true;
            lstView.Location = new Point(9, 60);
            lstView.Name = "lstView";
            lstView.Size = new Size(1105, 579);
            lstView.Sorting = SortOrder.Ascending;
            lstView.TabIndex = 11;
            lstView.UseCompatibleStateImageBehavior = false;
            lstView.View = View.Details;
            lstView.ColumnClick += lstView_ColumnClick;
            // 
            // Numero
            // 
            Numero.Text = "Número";
            Numero.Width = 500;
            // 
            // Ocorrencia
            // 
            Ocorrencia.Text = "Ocorrências";
            Ocorrencia.Width = 500;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(28, 691);
            lblStatus.Margin = new Padding(6, 0, 6, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(99, 37);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "status: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNumberOfInteractions);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtValue);
            groupBox1.Controls.Add(cmdExecute);
            groupBox1.Location = new Point(13, 37);
            groupBox1.Margin = new Padding(6, 7, 6, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 7, 6, 7);
            groupBox1.Size = new Size(1151, 215);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Entrada:";
            // 
            // txtNumberOfInteractions
            // 
            txtNumberOfInteractions.Location = new Point(287, 111);
            txtNumberOfInteractions.Margin = new Padding(6, 7, 6, 7);
            txtNumberOfInteractions.Name = "txtNumberOfInteractions";
            txtNumberOfInteractions.Size = new Size(400, 43);
            txtNumberOfInteractions.TabIndex = 9;
            txtNumberOfInteractions.Text = "50";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 111);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(285, 37);
            label2.TabIndex = 8;
            label2.Text = "Número de Interações:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 47);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(202, 37);
            label1.TabIndex = 7;
            label1.Text = "Valor a Fatorar: ";
            // 
            // txtValue
            // 
            txtValue.Location = new Point(287, 39);
            txtValue.Margin = new Padding(6, 7, 6, 7);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(400, 43);
            txtValue.TabIndex = 6;
            txtValue.Text = "21";
            // 
            // cmdExecute
            // 
            cmdExecute.Location = new Point(887, 39);
            cmdExecute.Margin = new Padding(2);
            cmdExecute.Name = "cmdExecute";
            cmdExecute.Size = new Size(227, 131);
            cmdExecute.TabIndex = 5;
            cmdExecute.Text = "Executar";
            cmdExecute.UseVisualStyleBackColor = true;
            cmdExecute.Click += cmdExecute_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 1214);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "frmPrincipal";
            Text = "Fatoração com Algoritmo de Groover com Quantum Computing";
            tabControl1.ResumeLayout(false);
            tabInteractions.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabInteractions;
        private GroupBox groupBox2;
        private Label lblStatus;
        private GroupBox groupBox1;
        private TextBox txtNumberOfInteractions;
        private Label label2;
        private Label label1;
        private TextBox txtValue;
        private Button cmdExecute;
        private ListView lstView;
        private ColumnHeader Numero;
        private ColumnHeader Ocorrencia;
    }
}
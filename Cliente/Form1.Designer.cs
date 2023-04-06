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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInteractions = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumberOfInteractions = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.cmdExecute = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabInteractions.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInteractions);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(561, 470);
            this.tabControl1.TabIndex = 9;
            // 
            // tabInteractions
            // 
            this.tabInteractions.Controls.Add(this.groupBox2);
            this.tabInteractions.Controls.Add(this.groupBox1);
            this.tabInteractions.Location = new System.Drawing.Point(4, 24);
            this.tabInteractions.Name = "tabInteractions";
            this.tabInteractions.Padding = new System.Windows.Forms.Padding(3);
            this.tabInteractions.Size = new System.Drawing.Size(553, 442);
            this.tabInteractions.TabIndex = 0;
            this.tabInteractions.Text = "Interações";
            this.tabInteractions.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.lstOutput);
            this.groupBox2.Location = new System.Drawing.Point(6, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 309);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saída";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 280);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 15);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "status: ";
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 15;
            this.lstOutput.Location = new System.Drawing.Point(13, 22);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(507, 244);
            this.lstOutput.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumberOfInteractions);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtValue);
            this.groupBox1.Controls.Add(this.cmdExecute);
            this.groupBox1.Location = new System.Drawing.Point(6, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 87);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada:";
            // 
            // txtNumberOfInteractions
            // 
            this.txtNumberOfInteractions.Location = new System.Drawing.Point(134, 45);
            this.txtNumberOfInteractions.Name = "txtNumberOfInteractions";
            this.txtNumberOfInteractions.Size = new System.Drawing.Size(189, 23);
            this.txtNumberOfInteractions.TabIndex = 9;
            this.txtNumberOfInteractions.Text = "50";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Número de Interações:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Valor a Fatorar: ";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(134, 16);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(189, 23);
            this.txtValue.TabIndex = 6;
            this.txtValue.Text = "21";
            // 
            // cmdExecute
            // 
            this.cmdExecute.Location = new System.Drawing.Point(414, 16);
            this.cmdExecute.Margin = new System.Windows.Forms.Padding(1);
            this.cmdExecute.Name = "cmdExecute";
            this.cmdExecute.Size = new System.Drawing.Size(106, 53);
            this.cmdExecute.TabIndex = 5;
            this.cmdExecute.Text = "Executar";
            this.cmdExecute.UseVisualStyleBackColor = true;
            this.cmdExecute.Click += new System.EventHandler(this.cmdExecute_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 492);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Fatoração com Algoritmo de Groover com Quantum Computing";
            this.tabControl1.ResumeLayout(false);
            this.tabInteractions.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabInteractions;
        private GroupBox groupBox2;
        private Label lblStatus;
        private ListBox lstOutput;
        private GroupBox groupBox1;
        private TextBox txtNumberOfInteractions;
        private Label label2;
        private Label label1;
        private TextBox txtValue;
        private Button cmdExecute;
    }
}
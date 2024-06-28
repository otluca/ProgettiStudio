namespace StudiVari
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbStackTraceTest = new System.Windows.Forms.GroupBox();
            this.cmdRethrownStackTraceTest = new System.Windows.Forms.Button();
            this.cmdNestedStackTraceTest = new System.Windows.Forms.Button();
            this.cmdDirectStackTraceTest = new System.Windows.Forms.Button();
            this.cmdStaticStackTraceTest = new System.Windows.Forms.Button();
            this.gbVariousTest = new System.Windows.Forms.GroupBox();
            this.cmdClassComparer = new System.Windows.Forms.Button();
            this.gbStackTraceTest.SuspendLayout();
            this.gbVariousTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbStackTraceTest
            // 
            this.gbStackTraceTest.Controls.Add(this.cmdRethrownStackTraceTest);
            this.gbStackTraceTest.Controls.Add(this.cmdNestedStackTraceTest);
            this.gbStackTraceTest.Controls.Add(this.cmdDirectStackTraceTest);
            this.gbStackTraceTest.Controls.Add(this.cmdStaticStackTraceTest);
            this.gbStackTraceTest.Location = new System.Drawing.Point(4, 8);
            this.gbStackTraceTest.Name = "gbStackTraceTest";
            this.gbStackTraceTest.Size = new System.Drawing.Size(186, 134);
            this.gbStackTraceTest.TabIndex = 0;
            this.gbStackTraceTest.TabStop = false;
            this.gbStackTraceTest.Text = "StackTrace Test";
            // 
            // cmdRethrownStackTraceTest
            // 
            this.cmdRethrownStackTraceTest.Location = new System.Drawing.Point(3, 102);
            this.cmdRethrownStackTraceTest.Name = "cmdRethrownStackTraceTest";
            this.cmdRethrownStackTraceTest.Size = new System.Drawing.Size(177, 23);
            this.cmdRethrownStackTraceTest.TabIndex = 3;
            this.cmdRethrownStackTraceTest.Text = "Re-thrown";
            this.cmdRethrownStackTraceTest.UseVisualStyleBackColor = true;
            this.cmdRethrownStackTraceTest.Click += new System.EventHandler(this.cmdRethrownStackTraceTest_Click);
            // 
            // cmdNestedStackTraceTest
            // 
            this.cmdNestedStackTraceTest.Location = new System.Drawing.Point(3, 73);
            this.cmdNestedStackTraceTest.Name = "cmdNestedStackTraceTest";
            this.cmdNestedStackTraceTest.Size = new System.Drawing.Size(177, 23);
            this.cmdNestedStackTraceTest.TabIndex = 2;
            this.cmdNestedStackTraceTest.Text = "Nested";
            this.cmdNestedStackTraceTest.UseVisualStyleBackColor = true;
            this.cmdNestedStackTraceTest.Click += new System.EventHandler(this.cmdNestedStackTraceTest_Click);
            // 
            // cmdDirectStackTraceTest
            // 
            this.cmdDirectStackTraceTest.Location = new System.Drawing.Point(3, 44);
            this.cmdDirectStackTraceTest.Name = "cmdDirectStackTraceTest";
            this.cmdDirectStackTraceTest.Size = new System.Drawing.Size(177, 23);
            this.cmdDirectStackTraceTest.TabIndex = 1;
            this.cmdDirectStackTraceTest.Text = "Direct";
            this.cmdDirectStackTraceTest.UseVisualStyleBackColor = true;
            this.cmdDirectStackTraceTest.Click += new System.EventHandler(this.cmdDirectStackTraceTest_Click);
            // 
            // cmdStaticStackTraceTest
            // 
            this.cmdStaticStackTraceTest.Location = new System.Drawing.Point(3, 16);
            this.cmdStaticStackTraceTest.Name = "cmdStaticStackTraceTest";
            this.cmdStaticStackTraceTest.Size = new System.Drawing.Size(177, 23);
            this.cmdStaticStackTraceTest.TabIndex = 0;
            this.cmdStaticStackTraceTest.Text = "Static";
            this.cmdStaticStackTraceTest.UseVisualStyleBackColor = true;
            this.cmdStaticStackTraceTest.Click += new System.EventHandler(this.cmdStaticStackTraceTest_Click);
            // 
            // gbVariousTest
            // 
            this.gbVariousTest.Controls.Add(this.cmdClassComparer);
            this.gbVariousTest.Location = new System.Drawing.Point(196, 8);
            this.gbVariousTest.Name = "gbVariousTest";
            this.gbVariousTest.Size = new System.Drawing.Size(186, 134);
            this.gbVariousTest.TabIndex = 1;
            this.gbVariousTest.TabStop = false;
            this.gbVariousTest.Text = "Various Test";
            // 
            // cmdClassComparer
            // 
            this.cmdClassComparer.Location = new System.Drawing.Point(3, 16);
            this.cmdClassComparer.Name = "cmdClassComparer";
            this.cmdClassComparer.Size = new System.Drawing.Size(177, 23);
            this.cmdClassComparer.TabIndex = 0;
            this.cmdClassComparer.Text = "ClassComparer";
            this.cmdClassComparer.UseVisualStyleBackColor = true;
            this.cmdClassComparer.Click += new System.EventHandler(this.cmdClassComparer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbVariousTest);
            this.Controls.Add(this.gbStackTraceTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbStackTraceTest.ResumeLayout(false);
            this.gbVariousTest.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStackTraceTest;
        private System.Windows.Forms.Button cmdRethrownStackTraceTest;
        private System.Windows.Forms.Button cmdNestedStackTraceTest;
        private System.Windows.Forms.Button cmdDirectStackTraceTest;
        private System.Windows.Forms.Button cmdStaticStackTraceTest;
        private System.Windows.Forms.GroupBox gbVariousTest;
        private System.Windows.Forms.Button cmdClassComparer;
    }
}


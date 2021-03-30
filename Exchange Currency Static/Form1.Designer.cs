
namespace Exchange_Currency_Static
{
    partial class Form1
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
            this.inCurrency = new System.Windows.Forms.ComboBox();
            this.outCurrency = new System.Windows.Forms.ComboBox();
            this.inputs = new System.Windows.Forms.TextBox();
            this.outputs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inCurrency
            // 
            this.inCurrency.FormattingEnabled = true;
            this.inCurrency.Items.AddRange(new object[] {
            "IDR",
            "USD",
            "GBP",
            "EUR",
            "NTD",
            "SGD",
            "CAD",
            "AUD",
            "PHP",
            "HKD"});
            this.inCurrency.Location = new System.Drawing.Point(189, 189);
            this.inCurrency.Name = "inCurrency";
            this.inCurrency.Size = new System.Drawing.Size(151, 28);
            this.inCurrency.TabIndex = 0;
            this.inCurrency.SelectedIndexChanged += new System.EventHandler(this.inCurrency_SelectedIndexChanged);
            // 
            // outCurrency
            // 
            this.outCurrency.FormattingEnabled = true;
            this.outCurrency.Items.AddRange(new object[] {
            "IDR",
            "USD",
            "GBP",
            "EUR",
            "NTD",
            "SGD",
            "CAD",
            "AUD",
            "PHP",
            "HKD"});
            this.outCurrency.Location = new System.Drawing.Point(406, 190);
            this.outCurrency.Name = "outCurrency";
            this.outCurrency.Size = new System.Drawing.Size(151, 28);
            this.outCurrency.TabIndex = 1;
            this.outCurrency.SelectedIndexChanged += new System.EventHandler(this.outCurrency_SelectedIndexChanged);
            // 
            // inputs
            // 
            this.inputs.Location = new System.Drawing.Point(12, 190);
            this.inputs.Name = "inputs";
            this.inputs.Size = new System.Drawing.Size(125, 27);
            this.inputs.TabIndex = 2;
            this.inputs.TextChanged += new System.EventHandler(this.inputs_TextChanged);
            // 
            // outputs
            // 
            this.outputs.Location = new System.Drawing.Point(624, 190);
            this.outputs.Name = "outputs";
            this.outputs.Size = new System.Drawing.Size(125, 27);
            this.outputs.TabIndex = 3;
            this.outputs.TextChanged += new System.EventHandler(this.outputs_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input Currency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output Currency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(624, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputs);
            this.Controls.Add(this.inputs);
            this.Controls.Add(this.outCurrency);
            this.Controls.Add(this.inCurrency);
            this.Name = "Form1";
            this.Text = "Static Currency Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox inCurrency;
        private System.Windows.Forms.ComboBox outCurrency;
        private System.Windows.Forms.TextBox inputs;
        private System.Windows.Forms.TextBox outputs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


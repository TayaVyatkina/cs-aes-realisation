
namespace AES_encoder_decoder
{
    partial class AES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AES));
            this.Encrypt = new System.Windows.Forms.GroupBox();
            this.last_saved_textbox = new System.Windows.Forms.TextBox();
            this.last_opened_textbox = new System.Windows.Forms.TextBox();
            this.output_buffer_label = new System.Windows.Forms.Label();
            this.input_buffer_label = new System.Windows.Forms.Label();
            this.Swap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Cleaner = new System.Windows.Forms.Button();
            this.SaveText = new System.Windows.Forms.Button();
            this.FromFile = new System.Windows.Forms.Button();
            this.KeySize = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Decrypter = new System.Windows.Forms.Button();
            this.Encrypter = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Random = new System.Windows.Forms.Button();
            this.Key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Encrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // Encrypt
            // 
            this.Encrypt.Controls.Add(this.last_saved_textbox);
            this.Encrypt.Controls.Add(this.last_opened_textbox);
            this.Encrypt.Controls.Add(this.output_buffer_label);
            this.Encrypt.Controls.Add(this.input_buffer_label);
            this.Encrypt.Controls.Add(this.Swap);
            this.Encrypt.Controls.Add(this.label2);
            this.Encrypt.Controls.Add(this.Cleaner);
            this.Encrypt.Controls.Add(this.SaveText);
            this.Encrypt.Controls.Add(this.FromFile);
            this.Encrypt.Controls.Add(this.KeySize);
            this.Encrypt.Controls.Add(this.textBox2);
            this.Encrypt.Controls.Add(this.button2);
            this.Encrypt.Controls.Add(this.Decrypter);
            this.Encrypt.Controls.Add(this.Encrypter);
            this.Encrypt.Controls.Add(this.textBox1);
            this.Encrypt.Controls.Add(this.Random);
            this.Encrypt.Controls.Add(this.Key);
            this.Encrypt.Controls.Add(this.label1);
            this.Encrypt.Location = new System.Drawing.Point(12, 12);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(776, 519);
            this.Encrypt.TabIndex = 1;
            this.Encrypt.TabStop = false;
            // 
            // last_saved_textbox
            // 
            this.last_saved_textbox.Location = new System.Drawing.Point(115, 451);
            this.last_saved_textbox.Name = "last_saved_textbox";
            this.last_saved_textbox.ReadOnly = true;
            this.last_saved_textbox.Size = new System.Drawing.Size(354, 23);
            this.last_saved_textbox.TabIndex = 18;
            // 
            // last_opened_textbox
            // 
            this.last_opened_textbox.Location = new System.Drawing.Point(115, 236);
            this.last_opened_textbox.Name = "last_opened_textbox";
            this.last_opened_textbox.ReadOnly = true;
            this.last_opened_textbox.Size = new System.Drawing.Size(354, 23);
            this.last_opened_textbox.TabIndex = 17;
            // 
            // output_buffer_label
            // 
            this.output_buffer_label.AutoSize = true;
            this.output_buffer_label.Location = new System.Drawing.Point(15, 265);
            this.output_buffer_label.Name = "output_buffer_label";
            this.output_buffer_label.Size = new System.Drawing.Size(48, 15);
            this.output_buffer_label.TabIndex = 16;
            this.output_buffer_label.Text = "Output:";
            // 
            // input_buffer_label
            // 
            this.input_buffer_label.AutoSize = true;
            this.input_buffer_label.Location = new System.Drawing.Point(15, 55);
            this.input_buffer_label.Name = "input_buffer_label";
            this.input_buffer_label.Size = new System.Drawing.Size(38, 15);
            this.input_buffer_label.TabIndex = 15;
            this.input_buffer_label.Text = "Input:";
            // 
            // Swap
            // 
            this.Swap.Image = ((System.Drawing.Image)(resources.GetObject("Swap.Image")));
            this.Swap.Location = new System.Drawing.Point(676, 232);
            this.Swap.Name = "Swap";
            this.Swap.Size = new System.Drawing.Size(94, 29);
            this.Swap.TabIndex = 14;
            this.Swap.Text = "Swap";
            this.Swap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Swap.UseVisualStyleBackColor = true;
            this.Swap.Click += new System.EventHandler(this.Swap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Key Size (bit)";
            // 
            // Cleaner
            // 
            this.Cleaner.Location = new System.Drawing.Point(676, 447);
            this.Cleaner.Name = "Cleaner";
            this.Cleaner.Size = new System.Drawing.Size(94, 29);
            this.Cleaner.TabIndex = 7;
            this.Cleaner.Text = "Clean all";
            this.Cleaner.UseVisualStyleBackColor = true;
            this.Cleaner.Click += new System.EventHandler(this.Cleaner_Click);
            // 
            // SaveText
            // 
            this.SaveText.Location = new System.Drawing.Point(15, 447);
            this.SaveText.Name = "SaveText";
            this.SaveText.Size = new System.Drawing.Size(94, 29);
            this.SaveText.TabIndex = 9;
            this.SaveText.Text = "Save";
            this.SaveText.UseVisualStyleBackColor = true;
            this.SaveText.Click += new System.EventHandler(this.SaveText_Click);
            // 
            // FromFile
            // 
            this.FromFile.Location = new System.Drawing.Point(15, 232);
            this.FromFile.Name = "FromFile";
            this.FromFile.Size = new System.Drawing.Size(94, 29);
            this.FromFile.TabIndex = 3;
            this.FromFile.Text = "Open";
            this.FromFile.UseVisualStyleBackColor = true;
            this.FromFile.Click += new System.EventHandler(this.FromFile_Click);
            // 
            // KeySize
            // 
            this.KeySize.AutoCompleteCustomSource.AddRange(new string[] {
            "128"});
            this.KeySize.FormattingEnabled = true;
            this.KeySize.Items.AddRange(new object[] {
            "128"});
            this.KeySize.Location = new System.Drawing.Point(115, 26);
            this.KeySize.Name = "KeySize";
            this.KeySize.Size = new System.Drawing.Size(79, 23);
            this.KeySize.TabIndex = 12;
            this.KeySize.Text = "128";
            this.KeySize.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 286);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(755, 146);
            this.textBox2.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(676, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 10;
            this.button2.Text = "Open";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Decrypter
            // 
            this.Decrypter.Location = new System.Drawing.Point(575, 232);
            this.Decrypter.Name = "Decrypter";
            this.Decrypter.Size = new System.Drawing.Size(94, 29);
            this.Decrypter.TabIndex = 8;
            this.Decrypter.Text = "Decrypt";
            this.Decrypter.UseVisualStyleBackColor = true;
            this.Decrypter.Click += new System.EventHandler(this.Decrypter_Click);
            // 
            // Encrypter
            // 
            this.Encrypter.Location = new System.Drawing.Point(475, 232);
            this.Encrypter.Name = "Encrypter";
            this.Encrypter.Size = new System.Drawing.Size(94, 29);
            this.Encrypter.TabIndex = 6;
            this.Encrypter.Text = "Encrypt";
            this.Encrypter.UseVisualStyleBackColor = true;
            this.Encrypter.Click += new System.EventHandler(this.Encrypter_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 76);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(755, 146);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Random
            // 
            this.Random.Location = new System.Drawing.Point(576, 26);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(94, 29);
            this.Random.TabIndex = 2;
            this.Random.Text = "Random";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.Click += new System.EventHandler(this.Random_Click);
            // 
            // Key
            // 
            this.Key.Location = new System.Drawing.Point(269, 26);
            this.Key.MaxLength = 48;
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(288, 23);
            this.Key.TabIndex = 1;
            this.Key.TextChanged += new System.EventHandler(this.Key_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key";
            // 
            // AES
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(807, 543);
            this.Controls.Add(this.Encrypt);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AESли зашифровать?";
            this.Load += new System.EventHandler(this.AES_Load);
            this.Encrypt.ResumeLayout(false);
            this.Encrypt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Encrypt;
        private System.Windows.Forms.TextBox Key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Encrypter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button FromFile;
        private System.Windows.Forms.Button Random;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SaveText;
        private System.Windows.Forms.Button Decrypter;
        private System.Windows.Forms.Button Cleaner;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox KeySize;
        private System.Windows.Forms.Button Swap;
        private System.Windows.Forms.Label input_buffer_label;
        private System.Windows.Forms.Label output_buffer_label;
        private System.Windows.Forms.TextBox last_opened_textbox;
        private System.Windows.Forms.TextBox last_saved_textbox;
    }
}


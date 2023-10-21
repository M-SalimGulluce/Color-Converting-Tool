namespace Renk_Hesaplayici
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rgbLabel = new System.Windows.Forms.Label();
            this.hexLabel = new System.Windows.Forms.Label();
            this.bgGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bgComboBox = new System.Windows.Forms.ComboBox();
            this.bgColorName = new System.Windows.Forms.Label();
            this.bgColorSelect = new System.Windows.Forms.Button();
            this.bgHex = new System.Windows.Forms.TextBox();
            this.bgDecimal = new System.Windows.Forms.TextBox();
            this.bgHexBlue = new System.Windows.Forms.TextBox();
            this.bgHexGreen = new System.Windows.Forms.TextBox();
            this.bgBlue = new System.Windows.Forms.TextBox();
            this.bgGreen = new System.Windows.Forms.TextBox();
            this.bgHexRed = new System.Windows.Forms.TextBox();
            this.bgRed = new System.Windows.Forms.TextBox();
            this.fgGroup = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fgComboBox = new System.Windows.Forms.ComboBox();
            this.fgColorName = new System.Windows.Forms.Label();
            this.fgColorSelect = new System.Windows.Forms.Button();
            this.fgHex = new System.Windows.Forms.TextBox();
            this.fgDecimal = new System.Windows.Forms.TextBox();
            this.fgHexBlue = new System.Windows.Forms.TextBox();
            this.fgRGBLabel = new System.Windows.Forms.Label();
            this.fgHexGreen = new System.Windows.Forms.TextBox();
            this.fgHEXLabel = new System.Windows.Forms.Label();
            this.fgBlue = new System.Windows.Forms.TextBox();
            this.fgGreen = new System.Windows.Forms.TextBox();
            this.fgRed = new System.Windows.Forms.TextBox();
            this.fgHexRed = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.bgGroup.SuspendLayout();
            this.fgGroup.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rgbLabel
            // 
            resources.ApplyResources(this.rgbLabel, "rgbLabel");
            this.rgbLabel.Name = "rgbLabel";
            // 
            // hexLabel
            // 
            resources.ApplyResources(this.hexLabel, "hexLabel");
            this.hexLabel.Name = "hexLabel";
            // 
            // bgGroup
            // 
            this.bgGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.bgGroup.Controls.Add(this.label1);
            this.bgGroup.Controls.Add(this.bgComboBox);
            this.bgGroup.Controls.Add(this.bgColorName);
            this.bgGroup.Controls.Add(this.bgColorSelect);
            this.bgGroup.Controls.Add(this.bgHex);
            this.bgGroup.Controls.Add(this.bgDecimal);
            this.bgGroup.Controls.Add(this.bgHexBlue);
            this.bgGroup.Controls.Add(this.bgHexGreen);
            this.bgGroup.Controls.Add(this.bgBlue);
            this.bgGroup.Controls.Add(this.bgGreen);
            this.bgGroup.Controls.Add(this.bgHexRed);
            this.bgGroup.Controls.Add(this.bgRed);
            this.bgGroup.Controls.Add(this.rgbLabel);
            this.bgGroup.Controls.Add(this.hexLabel);
            resources.ApplyResources(this.bgGroup, "bgGroup");
            this.bgGroup.Name = "bgGroup";
            this.bgGroup.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Name = "label1";
            // 
            // bgComboBox
            // 
            this.bgComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.bgComboBox, "bgComboBox");
            this.bgComboBox.Name = "bgComboBox";
            this.bgComboBox.SelectedIndexChanged += new System.EventHandler(this.bgComboBox_SelectedIndexChanged);
            this.bgComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bgComboBox_KeyPress);
            // 
            // bgColorName
            // 
            resources.ApplyResources(this.bgColorName, "bgColorName");
            this.bgColorName.Name = "bgColorName";
            // 
            // bgColorSelect
            // 
            resources.ApplyResources(this.bgColorSelect, "bgColorSelect");
            this.bgColorSelect.Name = "bgColorSelect";
            this.bgColorSelect.UseVisualStyleBackColor = true;
            this.bgColorSelect.Click += new System.EventHandler(this.bgColorSelect_Click);
            // 
            // bgHex
            // 
            resources.ApplyResources(this.bgHex, "bgHex");
            this.bgHex.Name = "bgHex";
            this.bgHex.ReadOnly = true;
            // 
            // bgDecimal
            // 
            resources.ApplyResources(this.bgDecimal, "bgDecimal");
            this.bgDecimal.Name = "bgDecimal";
            this.bgDecimal.ReadOnly = true;
            this.bgDecimal.TextChanged += new System.EventHandler(this.bgDecimal_TextChanged);
            // 
            // bgHexBlue
            // 
            this.bgHexBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.bgHexBlue, "bgHexBlue");
            this.bgHexBlue.ForeColor = System.Drawing.Color.Black;
            this.bgHexBlue.Name = "bgHexBlue";
            this.bgHexBlue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bgHexBlue_KeyPress);
            this.bgHexBlue.Leave += new System.EventHandler(this.bgHexBlue_Leave);
            // 
            // bgHexGreen
            // 
            this.bgHexGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(200)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.bgHexGreen, "bgHexGreen");
            this.bgHexGreen.ForeColor = System.Drawing.Color.Black;
            this.bgHexGreen.Name = "bgHexGreen";
            this.bgHexGreen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bgHexGreen_KeyPress);
            this.bgHexGreen.Leave += new System.EventHandler(this.bgHexGreen_Leave);
            // 
            // bgBlue
            // 
            this.bgBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.bgBlue, "bgBlue");
            this.bgBlue.ForeColor = System.Drawing.Color.Black;
            this.bgBlue.Name = "bgBlue";
            this.bgBlue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bgBlue_KeyPress);
            this.bgBlue.Leave += new System.EventHandler(this.bgBlue_Leave);
            // 
            // bgGreen
            // 
            this.bgGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(200)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.bgGreen, "bgGreen");
            this.bgGreen.ForeColor = System.Drawing.Color.Black;
            this.bgGreen.Name = "bgGreen";
            this.bgGreen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bgGreen_KeyPress);
            this.bgGreen.Leave += new System.EventHandler(this.bgGreen_Leave);
            // 
            // bgHexRed
            // 
            this.bgHexRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.bgHexRed, "bgHexRed");
            this.bgHexRed.ForeColor = System.Drawing.Color.Black;
            this.bgHexRed.Name = "bgHexRed";
            this.bgHexRed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bgHexRed_KeyPress);
            this.bgHexRed.Leave += new System.EventHandler(this.bgHexRed_Leave);
            // 
            // bgRed
            // 
            this.bgRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.bgRed, "bgRed");
            this.bgRed.ForeColor = System.Drawing.Color.Black;
            this.bgRed.Name = "bgRed";
            this.bgRed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bgRed_KeyPress);
            this.bgRed.Leave += new System.EventHandler(this.bgRed_Leave);
            // 
            // fgGroup
            // 
            this.fgGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.fgGroup.Controls.Add(this.label2);
            this.fgGroup.Controls.Add(this.fgComboBox);
            this.fgGroup.Controls.Add(this.fgColorName);
            this.fgGroup.Controls.Add(this.fgColorSelect);
            this.fgGroup.Controls.Add(this.fgHex);
            this.fgGroup.Controls.Add(this.fgDecimal);
            this.fgGroup.Controls.Add(this.fgHexBlue);
            this.fgGroup.Controls.Add(this.fgRGBLabel);
            this.fgGroup.Controls.Add(this.fgHexGreen);
            this.fgGroup.Controls.Add(this.fgHEXLabel);
            this.fgGroup.Controls.Add(this.fgBlue);
            this.fgGroup.Controls.Add(this.fgGreen);
            this.fgGroup.Controls.Add(this.fgRed);
            this.fgGroup.Controls.Add(this.fgHexRed);
            resources.ApplyResources(this.fgGroup, "fgGroup");
            this.fgGroup.Name = "fgGroup";
            this.fgGroup.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Name = "label2";
            // 
            // fgComboBox
            // 
            this.fgComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.fgComboBox, "fgComboBox");
            this.fgComboBox.Name = "fgComboBox";
            this.fgComboBox.SelectedIndexChanged += new System.EventHandler(this.fgComboBox_SelectedIndexChanged);
            this.fgComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fgComboBox_KeyPress);
            // 
            // fgColorName
            // 
            resources.ApplyResources(this.fgColorName, "fgColorName");
            this.fgColorName.Name = "fgColorName";
            // 
            // fgColorSelect
            // 
            resources.ApplyResources(this.fgColorSelect, "fgColorSelect");
            this.fgColorSelect.Name = "fgColorSelect";
            this.fgColorSelect.UseVisualStyleBackColor = true;
            this.fgColorSelect.Click += new System.EventHandler(this.fgColorSelect_Click);
            // 
            // fgHex
            // 
            resources.ApplyResources(this.fgHex, "fgHex");
            this.fgHex.Name = "fgHex";
            this.fgHex.ReadOnly = true;
            // 
            // fgDecimal
            // 
            resources.ApplyResources(this.fgDecimal, "fgDecimal");
            this.fgDecimal.Name = "fgDecimal";
            this.fgDecimal.ReadOnly = true;
            this.fgDecimal.TextChanged += new System.EventHandler(this.fgDecimal_TextChanged);
            // 
            // fgHexBlue
            // 
            this.fgHexBlue.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.fgHexBlue, "fgHexBlue");
            this.fgHexBlue.ForeColor = System.Drawing.Color.Blue;
            this.fgHexBlue.Name = "fgHexBlue";
            this.fgHexBlue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fgHexBlue_KeyPress);
            this.fgHexBlue.Leave += new System.EventHandler(this.fgHexBlue_Leave);
            // 
            // fgRGBLabel
            // 
            resources.ApplyResources(this.fgRGBLabel, "fgRGBLabel");
            this.fgRGBLabel.Name = "fgRGBLabel";
            // 
            // fgHexGreen
            // 
            this.fgHexGreen.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.fgHexGreen, "fgHexGreen");
            this.fgHexGreen.ForeColor = System.Drawing.Color.Green;
            this.fgHexGreen.Name = "fgHexGreen";
            this.fgHexGreen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fgHexGreen_KeyPress);
            this.fgHexGreen.Leave += new System.EventHandler(this.fgHexGreen_Leave);
            // 
            // fgHEXLabel
            // 
            resources.ApplyResources(this.fgHEXLabel, "fgHEXLabel");
            this.fgHEXLabel.Name = "fgHEXLabel";
            // 
            // fgBlue
            // 
            this.fgBlue.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.fgBlue, "fgBlue");
            this.fgBlue.ForeColor = System.Drawing.Color.Blue;
            this.fgBlue.Name = "fgBlue";
            this.fgBlue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fgBlue_KeyPress);
            this.fgBlue.Leave += new System.EventHandler(this.fgBlue_Leave);
            // 
            // fgGreen
            // 
            this.fgGreen.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.fgGreen, "fgGreen");
            this.fgGreen.ForeColor = System.Drawing.Color.Green;
            this.fgGreen.Name = "fgGreen";
            this.fgGreen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fgGreen_KeyPress);
            this.fgGreen.Leave += new System.EventHandler(this.fgGreen_Leave);
            // 
            // fgRed
            // 
            this.fgRed.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.fgRed, "fgRed");
            this.fgRed.ForeColor = System.Drawing.Color.Red;
            this.fgRed.Name = "fgRed";
            this.fgRed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fgRed_KeyPress);
            this.fgRed.Leave += new System.EventHandler(this.fgRed_Leave);
            // 
            // fgHexRed
            // 
            this.fgHexRed.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.fgHexRed, "fgHexRed");
            this.fgHexRed.ForeColor = System.Drawing.Color.Red;
            this.fgHexRed.Name = "fgHexRed";
            this.fgHexRed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fgHexRed_KeyPress);
            this.fgHexRed.Leave += new System.EventHandler(this.fgHexRed_Leave);
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MistyRose;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.infoToolStripMenuItem.AutoToolTip = true;
            this.infoToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.infoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            resources.ApplyResources(this.infoToolStripMenuItem, "infoToolStripMenuItem");
            this.infoToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.fgGroup);
            this.Controls.Add(this.bgGroup);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bgGroup.ResumeLayout(false);
            this.bgGroup.PerformLayout();
            this.fgGroup.ResumeLayout(false);
            this.fgGroup.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rgbLabel;
        private System.Windows.Forms.Label hexLabel;
        private System.Windows.Forms.GroupBox bgGroup;
        private System.Windows.Forms.GroupBox fgGroup;
        private System.Windows.Forms.Label fgRGBLabel;
        private System.Windows.Forms.Label fgHEXLabel;
        private System.Windows.Forms.TextBox bgHexRed;
        private System.Windows.Forms.TextBox bgRed;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.TextBox bgBlue;
        private System.Windows.Forms.TextBox bgGreen;
        private System.Windows.Forms.TextBox bgHexBlue;
        private System.Windows.Forms.TextBox bgHexGreen;
        private System.Windows.Forms.TextBox fgHexBlue;
        private System.Windows.Forms.TextBox fgHexGreen;
        private System.Windows.Forms.TextBox fgBlue;
        private System.Windows.Forms.TextBox fgGreen;
        private System.Windows.Forms.TextBox fgRed;
        private System.Windows.Forms.TextBox fgHexRed;
        private System.Windows.Forms.TextBox bgHex;
        private System.Windows.Forms.TextBox bgDecimal;
        private System.Windows.Forms.TextBox fgHex;
        private System.Windows.Forms.TextBox fgDecimal;
        private System.Windows.Forms.Button bgColorSelect;
        private System.Windows.Forms.Button fgColorSelect;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label bgColorName;
        private System.Windows.Forms.Label fgColorName;
        private System.Windows.Forms.ComboBox bgComboBox;
        private System.Windows.Forms.ComboBox fgComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


namespace lab03_02
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_system = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tool_font = new System.Windows.Forms.ToolStripComboBox();
            this.tool_size = new System.Windows.Forms.ToolStripComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tool_new = new System.Windows.Forms.ToolStripButton();
            this.tool_save = new System.Windows.Forms.ToolStripButton();
            this.tool_dam = new System.Windows.Forms.ToolStripButton();
            this.tool_nghieng = new System.Windows.Forms.ToolStripButton();
            this.tool_gach = new System.Windows.Forms.ToolStripButton();
            this.tạoVănBảnMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mởTậpTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuNộiDungVănBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_system,
            this.menu_edit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menu_system
            // 
            this.menu_system.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoVănBảnMớiToolStripMenuItem,
            this.mởTậpTinToolStripMenuItem,
            this.lưuNộiDungVănBảnToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menu_system.Name = "menu_system";
            this.menu_system.Size = new System.Drawing.Size(85, 24);
            this.menu_system.Text = "Hệ thống";
            // 
            // menu_edit
            // 
            this.menu_edit.Name = "menu_edit";
            this.menu_edit.Size = new System.Drawing.Size(92, 24);
            this.menu_edit.Text = "Định dạng";
            this.menu_edit.Click += new System.EventHandler(this.menu_edit_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_new,
            this.tool_save,
            this.tool_font,
            this.tool_size,
            this.tool_dam,
            this.tool_nghieng,
            this.tool_gach});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tool_font
            // 
            this.tool_font.Name = "tool_font";
            this.tool_font.Size = new System.Drawing.Size(121, 28);
            this.tool_font.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // tool_size
            // 
            this.tool_size.Name = "tool_size";
            this.tool_size.Size = new System.Drawing.Size(121, 28);
            this.tool_size.Click += new System.EventHandler(this.toolStripComboBox2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 56);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 394);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // tool_new
            // 
            this.tool_new.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_new.Image = ((System.Drawing.Image)(resources.GetObject("tool_new.Image")));
            this.tool_new.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_new.Name = "tool_new";
            this.tool_new.Size = new System.Drawing.Size(29, 25);
            this.tool_new.Text = "toolStripButton1";
            // 
            // tool_save
            // 
            this.tool_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_save.Image = ((System.Drawing.Image)(resources.GetObject("tool_save.Image")));
            this.tool_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_save.Name = "tool_save";
            this.tool_save.Size = new System.Drawing.Size(29, 25);
            this.tool_save.Text = "toolStripButton2";
            // 
            // tool_dam
            // 
            this.tool_dam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_dam.Image = ((System.Drawing.Image)(resources.GetObject("tool_dam.Image")));
            this.tool_dam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_dam.Name = "tool_dam";
            this.tool_dam.Size = new System.Drawing.Size(29, 25);
            this.tool_dam.Text = "toolStripButton3";
            this.tool_dam.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // tool_nghieng
            // 
            this.tool_nghieng.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_nghieng.Image = ((System.Drawing.Image)(resources.GetObject("tool_nghieng.Image")));
            this.tool_nghieng.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_nghieng.Name = "tool_nghieng";
            this.tool_nghieng.Size = new System.Drawing.Size(29, 25);
            this.tool_nghieng.Text = "toolStripButton4";
            this.tool_nghieng.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // tool_gach
            // 
            this.tool_gach.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_gach.Image = ((System.Drawing.Image)(resources.GetObject("tool_gach.Image")));
            this.tool_gach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_gach.Name = "tool_gach";
            this.tool_gach.Size = new System.Drawing.Size(29, 25);
            this.tool_gach.Text = "toolStripButton5";
            this.tool_gach.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // tạoVănBảnMớiToolStripMenuItem
            // 
            this.tạoVănBảnMớiToolStripMenuItem.Image = global::lab03_02.Properties.Resources.tải_xuống;
            this.tạoVănBảnMớiToolStripMenuItem.Name = "tạoVănBảnMớiToolStripMenuItem";
            this.tạoVănBảnMớiToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.tạoVănBảnMớiToolStripMenuItem.Text = "Tạo văn bản mới";
            this.tạoVănBảnMớiToolStripMenuItem.Click += new System.EventHandler(this.tạoVănBảnMớiToolStripMenuItem_Click);
            // 
            // mởTậpTinToolStripMenuItem
            // 
            this.mởTậpTinToolStripMenuItem.Image = global::lab03_02.Properties.Resources.tải_xuống__2_;
            this.mởTậpTinToolStripMenuItem.Name = "mởTậpTinToolStripMenuItem";
            this.mởTậpTinToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.mởTậpTinToolStripMenuItem.Text = "Mở tập tin";
            this.mởTậpTinToolStripMenuItem.Click += new System.EventHandler(this.mởTậpTinToolStripMenuItem_Click);
            // 
            // lưuNộiDungVănBảnToolStripMenuItem
            // 
            this.lưuNộiDungVănBảnToolStripMenuItem.Image = global::lab03_02.Properties.Resources.tải_xuống__1_;
            this.lưuNộiDungVănBảnToolStripMenuItem.Name = "lưuNộiDungVănBảnToolStripMenuItem";
            this.lưuNộiDungVănBảnToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.lưuNộiDungVănBảnToolStripMenuItem.Text = "Lưu nội dung văn bản";
            this.lưuNộiDungVănBảnToolStripMenuItem.Click += new System.EventHandler(this.lưuNộiDungVănBảnToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Soạn thảo văn bản";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_system;
        private System.Windows.Forms.ToolStripMenuItem tạoVănBảnMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mởTậpTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuNộiDungVănBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_edit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tool_new;
        private System.Windows.Forms.ToolStripButton tool_save;
        private System.Windows.Forms.ToolStripComboBox tool_font;
        private System.Windows.Forms.ToolStripComboBox tool_size;
        private System.Windows.Forms.ToolStripButton tool_dam;
        private System.Windows.Forms.ToolStripButton tool_nghieng;
        private System.Windows.Forms.ToolStripButton tool_gach;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}


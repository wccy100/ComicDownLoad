﻿namespace comicDownLoad
{
    partial class ComicReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComicReader));
            this.mainContext = new CCWin.SkinControl.SkinContextMenuStrip();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenTool = new System.Windows.Forms.ToolStripMenuItem();
            this.放大ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.缩小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoWidth = new System.Windows.Forms.ToolStripMenuItem();
            this.原始比例IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageLabel = new System.Windows.Forms.Label();
            this.progressBar = new CCWin.SkinControl.SkinTrackBar();
            this.menuTool = new CCWin.SkinControl.SkinMenuStrip();
            this.菜单MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.打开目录DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开URLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除缓存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.书签ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图像PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.拆分CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于BToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).BeginInit();
            this.menuTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContext
            // 
            this.mainContext.Arrow = System.Drawing.Color.Black;
            this.mainContext.Back = System.Drawing.Color.White;
            this.mainContext.BackRadius = 4;
            this.mainContext.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.mainContext.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.mainContext.Fore = System.Drawing.Color.Black;
            this.mainContext.HoverFore = System.Drawing.Color.White;
            this.mainContext.ItemAnamorphosis = true;
            this.mainContext.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.mainContext.ItemBorderShow = true;
            this.mainContext.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.mainContext.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.mainContext.ItemRadius = 4;
            this.mainContext.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.mainContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.fullScreenTool,
            this.放大ToolStripMenuItem,
            this.缩小ToolStripMenuItem,
            this.autoWidth,
            this.原始比例IToolStripMenuItem});
            this.mainContext.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.mainContext.Name = "mainContext";
            this.mainContext.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.mainContext.Size = new System.Drawing.Size(141, 136);
            this.mainContext.SkinAllColor = true;
            this.mainContext.TitleAnamorphosis = true;
            this.mainContext.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.mainContext.TitleRadius = 4;
            this.mainContext.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.打开ToolStripMenuItem.Text = "打开(&O)";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // fullScreenTool
            // 
            this.fullScreenTool.Name = "fullScreenTool";
            this.fullScreenTool.Size = new System.Drawing.Size(140, 22);
            this.fullScreenTool.Text = "全屏(&F)";
            this.fullScreenTool.Click += new System.EventHandler(this.全屏ToolStripMenuItem_Click);
            // 
            // 放大ToolStripMenuItem
            // 
            this.放大ToolStripMenuItem.Name = "放大ToolStripMenuItem";
            this.放大ToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.放大ToolStripMenuItem.Text = "放大(&+)";
            this.放大ToolStripMenuItem.Click += new System.EventHandler(this.放大ToolStripMenuItem_Click);
            // 
            // 缩小ToolStripMenuItem
            // 
            this.缩小ToolStripMenuItem.Name = "缩小ToolStripMenuItem";
            this.缩小ToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.缩小ToolStripMenuItem.Text = "缩小(&-)";
            this.缩小ToolStripMenuItem.Click += new System.EventHandler(this.缩小ToolStripMenuItem_Click);
            // 
            // autoWidth
            // 
            this.autoWidth.Name = "autoWidth";
            this.autoWidth.Size = new System.Drawing.Size(140, 22);
            this.autoWidth.Text = "适应宽度(&A)";
            this.autoWidth.Click += new System.EventHandler(this.适应宽度ToolStripMenuItem_Click);
            // 
            // 原始比例IToolStripMenuItem
            // 
            this.原始比例IToolStripMenuItem.Name = "原始比例IToolStripMenuItem";
            this.原始比例IToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.原始比例IToolStripMenuItem.Text = "原始比例(&I)";
            this.原始比例IToolStripMenuItem.Click += new System.EventHandler(this.原始比例IToolStripMenuItem_Click);
            // 
            // pageLabel
            // 
            this.pageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pageLabel.AutoSize = true;
            this.pageLabel.Font = new System.Drawing.Font("宋体", 10F);
            this.pageLabel.ForeColor = System.Drawing.Color.White;
            this.pageLabel.Location = new System.Drawing.Point(1188, 640);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(0, 14);
            this.pageLabel.TabIndex = 2;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.BackColor = System.Drawing.Color.Transparent;
            this.progressBar.Bar = null;
            this.progressBar.BarStyle = CCWin.SkinControl.HSLTrackBarStyle.Opacity;
            this.progressBar.BaseColor = System.Drawing.Color.White;
            this.progressBar.Location = new System.Drawing.Point(306, 625);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(614, 45);
            this.progressBar.TabIndex = 3;
            this.progressBar.Track = null;
            this.progressBar.Visible = false;
            // 
            // menuTool
            // 
            this.menuTool.Arrow = System.Drawing.Color.Black;
            this.menuTool.Back = System.Drawing.Color.White;
            this.menuTool.BackRadius = 4;
            this.menuTool.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.menuTool.Base = System.Drawing.Color.White;
            this.menuTool.BaseFore = System.Drawing.Color.Black;
            this.menuTool.BaseForeAnamorphosis = false;
            this.menuTool.BaseForeAnamorphosisBorder = 4;
            this.menuTool.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.menuTool.BaseHoverFore = System.Drawing.Color.White;
            this.menuTool.BaseItemAnamorphosis = true;
            this.menuTool.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menuTool.BaseItemBorderShow = true;
            this.menuTool.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("menuTool.BaseItemDown")));
            this.menuTool.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menuTool.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("menuTool.BaseItemMouse")));
            this.menuTool.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menuTool.BaseItemRadius = 4;
            this.menuTool.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.menuTool.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menuTool.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.menuTool.Fore = System.Drawing.Color.Black;
            this.menuTool.HoverFore = System.Drawing.Color.White;
            this.menuTool.ItemAnamorphosis = true;
            this.menuTool.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menuTool.ItemBorderShow = true;
            this.menuTool.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menuTool.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menuTool.ItemRadius = 4;
            this.menuTool.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.menuTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单MToolStripMenuItem,
            this.historyMenu,
            this.书签ToolStripMenuItem,
            this.图像PToolStripMenuItem,
            this.关于BToolStripMenuItem});
            this.menuTool.Location = new System.Drawing.Point(0, 0);
            this.menuTool.Name = "menuTool";
            this.menuTool.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.menuTool.Size = new System.Drawing.Size(1264, 25);
            this.menuTool.SkinAllColor = true;
            this.menuTool.TabIndex = 1;
            this.menuTool.Text = "skinMenuStrip1";
            this.menuTool.TitleAnamorphosis = true;
            this.menuTool.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.menuTool.TitleRadius = 4;
            this.menuTool.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // 菜单MToolStripMenuItem
            // 
            this.菜单MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem1,
            this.打开目录DToolStripMenuItem,
            this.打开URLToolStripMenuItem,
            this.清除缓存ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.菜单MToolStripMenuItem.Name = "菜单MToolStripMenuItem";
            this.菜单MToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.菜单MToolStripMenuItem.Text = "菜单(&M)";
            // 
            // 打开ToolStripMenuItem1
            // 
            this.打开ToolStripMenuItem1.Name = "打开ToolStripMenuItem1";
            this.打开ToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.打开ToolStripMenuItem1.Text = "打开(&O)";
            this.打开ToolStripMenuItem1.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 打开目录DToolStripMenuItem
            // 
            this.打开目录DToolStripMenuItem.Name = "打开目录DToolStripMenuItem";
            this.打开目录DToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.打开目录DToolStripMenuItem.Text = "打开目录(&D)";
            // 
            // 打开URLToolStripMenuItem
            // 
            this.打开URLToolStripMenuItem.Name = "打开URLToolStripMenuItem";
            this.打开URLToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.打开URLToolStripMenuItem.Text = "打开URL(&U)";
            // 
            // 清除缓存ToolStripMenuItem
            // 
            this.清除缓存ToolStripMenuItem.Name = "清除缓存ToolStripMenuItem";
            this.清除缓存ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.清除缓存ToolStripMenuItem.Text = "清除缓存";
            this.清除缓存ToolStripMenuItem.Click += new System.EventHandler(this.清除缓存ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // historyMenu
            // 
            this.historyMenu.Name = "historyMenu";
            this.historyMenu.Size = new System.Drawing.Size(61, 21);
            this.historyMenu.Text = "历史(&H)";
            this.historyMenu.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.historyMenu_DropDownItemClicked);
            // 
            // 书签ToolStripMenuItem
            // 
            this.书签ToolStripMenuItem.Name = "书签ToolStripMenuItem";
            this.书签ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.书签ToolStripMenuItem.Text = "书签(&B)";
            // 
            // 图像PToolStripMenuItem
            // 
            this.图像PToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.拆分CToolStripMenuItem});
            this.图像PToolStripMenuItem.Name = "图像PToolStripMenuItem";
            this.图像PToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.图像PToolStripMenuItem.Text = "图像(&P)";
            // 
            // 拆分CToolStripMenuItem
            // 
            this.拆分CToolStripMenuItem.Name = "拆分CToolStripMenuItem";
            this.拆分CToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.拆分CToolStripMenuItem.Text = "拆分(&C)";
            // 
            // 关于BToolStripMenuItem
            // 
            this.关于BToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于BToolStripMenuItem1});
            this.关于BToolStripMenuItem.Name = "关于BToolStripMenuItem";
            this.关于BToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.关于BToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 关于BToolStripMenuItem1
            // 
            this.关于BToolStripMenuItem1.Name = "关于BToolStripMenuItem1";
            this.关于BToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.关于BToolStripMenuItem1.Text = "关于(&B)";
            this.关于BToolStripMenuItem1.Click += new System.EventHandler(this.关于BToolStripMenuItem1_Click);
            // 
            // ComicReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.ContextMenuStrip = this.mainContext;
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pageLabel);
            this.Controls.Add(this.menuTool);
            this.MainMenuStrip = this.menuTool;
            this.Name = "ComicReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "漫画阅读器V1.0";
            this.Click += new System.EventHandler(this.ComicReader_Click);
            this.DoubleClick += new System.EventHandler(this.全屏ToolStripMenuItem_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComicReader_KeyDown);
            this.mainContext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).EndInit();
            this.menuTool.ResumeLayout(false);
            this.menuTool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinContextMenuStrip mainContext;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullScreenTool;
        private System.Windows.Forms.ToolStripMenuItem 放大ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 缩小ToolStripMenuItem;
        private CCWin.SkinControl.SkinMenuStrip menuTool;
        private System.Windows.Forms.ToolStripMenuItem 菜单MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 书签ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoWidth;
        private System.Windows.Forms.ToolStripMenuItem 原始比例IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyMenu;
        private System.Windows.Forms.ToolStripMenuItem 图像PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 拆分CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开目录DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开URLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除缓存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于BToolStripMenuItem1;
        private System.Windows.Forms.Label pageLabel;
        private CCWin.SkinControl.SkinTrackBar progressBar;
    }
}
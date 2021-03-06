﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CCWin.SkinControl;
using System.Runtime.InteropServices;

namespace comicDownLoad
{
    public partial class ComicReader : Form
    {
        public ComicReader()
        {          
            //开启双缓冲
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            this.MouseWheel += ComicReader_MouseWheel;
            timer = new Timer();
            timer.Interval = 1;
            timer.Tick += timer_Tick;
        }

        private int sum;
        private int m_Page;
        private int m_clientWidth;
        private int m_clientHeight;
        private int m_posX;
        private int m_posY;
        private bool isAdd;
        private float t = 0;
        private double scale = 1.0;
        private Graphics memoryGraphic;
        private Image m_showImage;
        private Image m_nextImage;
        private Timer timer;//定时器启动
        GifBox gifBox;

        public enum PaintStatusEnum
        { 
            PaintLast,
            PaintOne,
            PaintCurrent,
            PaintNext
        }

        public List<string> FileUrl
        {
            get;
            set;
        }

        private void AddLoadingGif()
        {
            gifBox = new GifBox();
            gifBox.Image = Properties.Resources.bycleLoad;
            gifBox.Width = gifBox.Image.Width;
            gifBox.Height = gifBox.Image.Height;
            int x = (this.Width - gifBox.Image.Width) / 2;
            int y = (this.Height - gifBox.Image.Height) / 2;
            gifBox.Location = new Point(x,y);
            this.Controls.Add(gifBox);
        }

        private void RemoveLoadingGif()
        {
            this.Invoke(new Action(() =>
            {
                gifBox.Image = null;
                this.Controls.Remove(gifBox);
            }));
           
        }

        private Image JoinImage()
        {
            int pos = 0;
            int maxWidth = 0;
            int totalHeigtht = 0;
            Graphics graphic = null;
            Image tempImage = null;
            Bitmap retImage;
            List<Image> showimageList;
            List<string> list;
            list = new List<string>();
            showimageList = new List<Image>();

            foreach (var fileName in FileUrl)
            {
                tempImage = Image.FromFile(fileName);
                showimageList.Add(tempImage);
                totalHeigtht = totalHeigtht + tempImage.Height;

                if (tempImage.Width > maxWidth)
                {
                    maxWidth = tempImage.Width;
                }

                tempImage = null;
            }

            retImage = new Bitmap(maxWidth, totalHeigtht);
            graphic = Graphics.FromImage(retImage);

            foreach (Image img in showimageList)
            {
                graphic.DrawImage(img, 0, pos);
                pos = pos + img.Height;
            }

            graphic.Dispose();
            showimageList.Clear();
            GC.Collect();
            return retImage;
        }

        public void AddFileToList(object sender, string fileName)//添加文件到文件集合
        {
            if (FileUrl == null)
            {
                FileUrl = new List<string>();
            }

            FileUrl.Add(fileName);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var rate = 0.0;
            float show_x = 0.0f;
            int m_imageWidth;
            int m_imageHeight;
            PaintStatusEnum paintStatus;
            RectangleF destRect;
            RectangleF srcRect;
            RectangleF tempRect;
            Graphics gra = e.Graphics;
            base.OnPaint(e);

            paintStatus = PaintStatusEnum.PaintCurrent;
            tempRect = new RectangleF();
            destRect = new RectangleF();
            srcRect = new RectangleF();

            if (m_showImage == null)
                return;

            m_imageWidth = m_showImage.Width;
            m_imageHeight = m_showImage.Height;
            m_clientWidth = this.Width;
            m_clientHeight = this.Height;

            rate = (m_imageHeight * 1.0f) / m_imageWidth;//计算宽高比

            if (rate == 0.0f)
                rate = 1.0f;

            if (m_posY >= m_showImage.Height)//要翻页
            {
                m_posY = 0;
               
                if (m_Page + 1 <= FileUrl.Count -1)
                {
                    m_showImage = m_nextImage;
                    m_Page++;
                }
                
            }

            srcRect.X = 0;
            srcRect.Y = m_posY;
            srcRect.Width = m_imageWidth;//图像宽度小于客户区宽度, 取图矩形宽度等于原图宽度

            if (m_posY + m_clientHeight >= m_imageHeight)//第一页已经见底
            {
                paintStatus = PaintStatusEnum.PaintNext;
                srcRect.Height = Convert.ToInt32(m_imageHeight - m_posY);

                if (m_Page + 1 < FileUrl.Count)
                    m_nextImage = Image.FromFile(FileUrl[m_Page + 1]);
                else
                {
                    m_nextImage = m_showImage;            
                    return;
                }
 
                tempRect.X = 0;
                tempRect.Y = 0;
                tempRect.Width = m_nextImage.Width;
                tempRect.Height = Convert.ToInt32(tempRect.Width * rate);
                //tempRect.Height = m_clientHeight - (m_imageHeight - m_posY);
            }
            else
            {
                if (m_posY < 0)
                {
                    var pos = Math.Abs(m_posY);
                    paintStatus = PaintStatusEnum.PaintLast;

                    if (m_Page - 1 >= 0)
                    {
                        if (m_nextImage == null || pos >= m_nextImage.Height)//什么时候加载上一张图片
                        {
                            m_nextImage = Image.FromFile(FileUrl[--m_Page]);//上一张图片赋值

                            if (Math.Abs(m_posY) >= m_nextImage.Height)//往上翻到头了，而且先画上一张
                            {
                                m_showImage = m_nextImage;

                                if (m_Page - 1 >= 0)
                                    m_nextImage = Image.FromFile(FileUrl[--m_Page]);

                                m_posY = m_showImage.Height - m_clientHeight;
                                srcRect.Y = m_posY;
                                srcRect.Width = m_showImage.Width;
                                srcRect.Height = m_clientHeight;                              
                                paintStatus = PaintStatusEnum.PaintCurrent;//转为绘制当前
                                
                            }

                        }
                        else
                        {
                            srcRect.Y = m_nextImage.Height - pos;
                            srcRect.Width = m_nextImage.Width;
                            srcRect.Height = pos;
                            tempRect.Y = 0;
                            tempRect.Width = m_nextImage.Width;
                            tempRect.Height = m_clientHeight - pos;
                        }

                        
                    }

                }
                else
                {
                    srcRect.Height = m_imageHeight;
                }
                //GC.Collect();
            }

            if (m_clientWidth >= srcRect.Width)//
            {
                destRect.Width = Convert.ToInt32(srcRect.Width* scale);
                destRect.Height = Convert.ToInt32(srcRect.Height * scale);
   
            }
            else
            {
                destRect.Width = Convert.ToInt32(srcRect.Width * scale);
                destRect.Height = Convert.ToInt32(srcRect.Height * scale);
            }

            show_x = (m_clientWidth - destRect.Width) / 2;//水平居中显示
            destRect.X = show_x;
            destRect.Y = 0;

            Bitmap m_memoryBmp = new Bitmap(m_clientWidth, m_clientHeight);

            using (Graphics memoryGraphic = Graphics.FromImage(m_memoryBmp))
            {              
                memoryGraphic.Clear(Color.Black);

                if (paintStatus == PaintStatusEnum.PaintCurrent || paintStatus == PaintStatusEnum.PaintNext)
                {
                    memoryGraphic.DrawImage(m_showImage, destRect, srcRect, GraphicsUnit.Pixel);//绘制到内存图上
  
                    if (paintStatus == PaintStatusEnum.PaintNext)
                    {
                        destRect.Y = Convert.ToInt32(srcRect.Height * scale) + 10;
                        destRect.Width = Convert.ToInt32(tempRect.Width * scale);
                        destRect.Height = Convert.ToInt32(tempRect.Height * scale);
                        memoryGraphic.DrawImage(m_nextImage, destRect, tempRect, GraphicsUnit.Pixel);//第二次绘制
                    }
                }
                else//往上翻页
                {                  
                    if (paintStatus == PaintStatusEnum.PaintLast)
                    {
                        memoryGraphic.DrawImage(m_nextImage, destRect, srcRect, GraphicsUnit.Pixel);
                        destRect.Y = Convert.ToInt32(srcRect.Height * scale) + 10;
                        destRect.Width = Convert.ToInt32(tempRect.Width * scale);
                        destRect.Height = Convert.ToInt32(tempRect.Height * scale);                     
                        memoryGraphic.DrawImage(m_showImage, destRect, tempRect, GraphicsUnit.Pixel);
                    }
                   
                }
                                   
                gra.DrawImage(m_memoryBmp, 0, 0);//绘制到屏幕上
                m_memoryBmp.Dispose();
                memoryGraphic.Dispose();
            }

        }

        private void showScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue > e.OldValue)
            {
                m_posY += e.NewValue - e.OldValue;
                Invalidate();
            }
            else
            {
                m_posY -= e.OldValue - e.NewValue;
                Invalidate();
            }
        }

        public void StartRead()
        {
            AddLoadingGif();

            try
            {
                Task task = new Task(() =>
                {
                    while (FileUrl == null || FileUrl.Count < 2)
                    {
                    }

                    m_Page = 0;
                    m_showImage = Image.FromFile(FileUrl[m_Page]);
                    RemoveLoadingGif();
                    Invalidate();
                });
                task.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show("StartRead" + ex.Message);
            }
        }

        public void LoadImage(string path, int currentPage)
        {
            FileUrl = new List<string>();
            var count = Directory.GetFiles(path ,"*.jpg").Length;

            for (int i = 0; i < count; i++)
            {
                FileUrl.Add(path + "\\" +i.ToString() + ".jpg");
            }

            m_Page = currentPage;
            m_showImage = Image.FromFile(FileUrl[m_Page]);
            this.Text = FileUrl[m_Page].Substring(0, FileUrl[m_Page].LastIndexOf(".")-2);
            Init();

            foreach (ToolStripMenuItem t in menuTool.Items)
            {         
                if(t.Text.Equals("历史(&H)"))
                    t.DropDownItems.Add(FileUrl[m_Page]);               
            }
            
            Invalidate();
        }

        void Init()
        {
            progressBar.Maximum = FileUrl.Count;
            progressBar.Value = m_Page;
            pageLabel.Text = m_Page.ToString() + "/" + FileUrl.Count.ToString() + "页";
        }

        void ComicReader_MouseWheel(object sender, MouseEventArgs e)
        {
            sum = Math.Abs(e.Delta);

            if (e.Delta < 0)
            {
                UpScroll(sum);
                //m_posY += sum;
            }
            else
            {
                DownScroll(sum);
                //m_posY -= sum;
            }

            //Invalidate();
        }

        void UpScroll(int offset)
        { 
            t = 0;
            sum = offset;
            isAdd = true;           
            timer.Start();
        }

        void DownScroll(int offset)
        { 
            t = 0;
            sum = offset;
            isAdd = false;           
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            int dat = Convert.ToInt32(Math.Abs(m_posY));
            float dt = 0.0f;
            dt = (sum * t + -sum * (t + 1)) / (t * t + 1);

            if (isAdd)
            {
                m_posY = m_posY - Convert.ToInt32(dt);
            }
            else
            {
                m_posY = m_posY + Convert.ToInt32(dt);

            }

            Console.WriteLine("sum值:{0},滚动位移:{1},t值:{2}", sum, dt, t);

            if (Math.Abs(dt) < 0.1)
            {
                timer.Stop();
                Console.WriteLine("定时器停止");
                sum = 0;
            }

            t++;
            Invalidate();
        }

        private void OpenFile()
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string path = openFile.FileName;
                int page = Convert.ToInt32(openFile.SafeFileName.Substring(0, openFile.SafeFileName.IndexOf(".")));
                LoadImage(path.Substring(0, path.LastIndexOf(@"\")), page);
            }
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void FullScreen()
        {
            if (fullScreenTool.Checked == false)
            {
                this.SetVisibleCore(false);
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                this.SetVisibleCore(true);
                progressBar.Visible = false;
                pageLabel.Visible = false;
                menuTool.Visible = false;
                fullScreenTool.Checked = true;
                
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                this.Width = 1280;
                this.Height = 720;
                //progressBar.Visible = true;
                pageLabel.Visible = true;
                fullScreenTool.Checked = false;
                menuTool.Visible = true;
            }
        }

        private void 全屏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FullScreen();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            scale = scale + 0.2;
            Invalidate();
        }

        private void prograssBar_Scroll(object sender, EventArgs e)
        {
            /*m_Page = prograssBar.Value;
            m_showImage = Image.FromFile(FileUrl[m_Page]);
            m_posY = 0;
            Invalidate();*/
        }

        private void ComicReader_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up: DownScroll(120); break;
                case Keys.Down: UpScroll(120); break;
                case Keys.Add: Enlarge(); break;
                case Keys.Subtract: Narrow(); break;
                case Keys.Enter:FullScreen(); break;
                
            }
        }

        private void ComicReader_Click(object sender, EventArgs e)
        {
            
        }

        private void 放大ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enlarge();
        }

     
        private void 缩小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Narrow();
        }

        private void Enlarge()
        {
            scale = scale + 0.2;
            Invalidate();
        }

        private void Narrow()
        {
            scale = scale - 0.2;
            Invalidate();
        }

        private void 适应宽度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scale = m_clientWidth > m_showImage.Width ? m_clientWidth / m_showImage.Width : m_showImage.Width / m_clientWidth;
            autoWidth.Checked = !autoWidth.Checked;
            Invalidate();
        }

        private void 原始比例IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scale = 1.0;
            Invalidate();
        }

        private void historyMenu_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            int index = FileUrl.FindIndex(a=>a == e.ClickedItem.Text);

            if (index == -1)
            { 
                
            }

            if (m_Page == index)
            {
                return;
            }

            m_Page = index;
            m_showImage = Image.FromFile(FileUrl[m_Page]);
            Invalidate();
        }

        private void 清除缓存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteFiles("temp\\");
            MessageBox.Show("缓存清除成功");
        }

        private void 关于BToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            comicDownLoad.Properties.AboutBox about = new Properties.AboutBox();
            about.Show();
        }

        public void DeleteFiles(string str)
        {
            DirectoryInfo fatherFolder = new DirectoryInfo(str);
            //删除当前文件夹内文件
            FileInfo[] files = fatherFolder.GetFiles();
            foreach (FileInfo file in files)
            {
                //string fileName = file.FullName.Substring((file.FullName.LastIndexOf("\\") + 1), file.FullName.Length - file.FullName.LastIndexOf("\\") - 1);
                string fileName = file.Name;
                try
                {
                    if (!fileName.Equals("index.dat"))
                    {
                        File.Delete(file.FullName);
                    }
                }
                catch (Exception ex)
                {
                }
            }
            //递归删除子文件夹内文件
            foreach (DirectoryInfo childFolder in fatherFolder.GetDirectories())
            {
                DeleteFiles(childFolder.FullName);
            }


        }

    }
}

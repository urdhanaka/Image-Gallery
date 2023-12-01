namespace Image_Gallery
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
            components = new System.ComponentModel.Container();
            imageList1 = new ImageList(components);
            albumFotoToolStripMenuItem = new ToolStripMenuItem();
            openDirectoryBtn = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            imageList = new ListView();
            selectedImage = new PictureBox();
            PrevImgBtn = new Button();
            NextImgBtn = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)selectedImage).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // albumFotoToolStripMenuItem
            // 
            albumFotoToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            albumFotoToolStripMenuItem.Name = "albumFotoToolStripMenuItem";
            albumFotoToolStripMenuItem.Size = new Size(142, 34);
            albumFotoToolStripMenuItem.Text = "Album Foto";
            // 
            // openDirectoryBtn
            // 
            openDirectoryBtn.Alignment = ToolStripItemAlignment.Right;
            openDirectoryBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            openDirectoryBtn.Name = "openDirectoryBtn";
            openDirectoryBtn.Size = new Size(109, 34);
            openDirectoryBtn.Text = "Open Directory";
            openDirectoryBtn.Click += UploadFileToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLightLight;
            menuStrip1.Items.AddRange(new ToolStripItem[] { albumFotoToolStripMenuItem, openDirectoryBtn });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 5, 0, 5);
            menuStrip1.Size = new Size(1497, 44);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += MenuStrip1_ItemClicked;
            // 
            // imageList
            // 
            imageList.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            imageList.Location = new Point(12, 47);
            imageList.Name = "imageList";
            imageList.Size = new Size(200, 669);
            imageList.TabIndex = 1;
            imageList.UseCompatibleStateImageBehavior = false;
            imageList.ItemSelectionChanged += ImageList_ItemSelectionChanged;
            // 
            // selectedImage
            // 
            selectedImage.Location = new Point(248, 47);
            selectedImage.Name = "selectedImage";
            selectedImage.Size = new Size(1237, 669);
            selectedImage.TabIndex = 2;
            selectedImage.TabStop = false;
            // 
            // PrevImgBtn
            // 
            PrevImgBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PrevImgBtn.Location = new Point(1247, 722);
            PrevImgBtn.Name = "PrevImgBtn";
            PrevImgBtn.Size = new Size(123, 27);
            PrevImgBtn.TabIndex = 4;
            PrevImgBtn.Text = "< Previous";
            PrevImgBtn.UseVisualStyleBackColor = true;
            PrevImgBtn.Click += PrevImgBtn_Click;
            // 
            // NextImgBtn
            // 
            NextImgBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NextImgBtn.Location = new Point(1376, 722);
            NextImgBtn.Name = "NextImgBtn";
            NextImgBtn.Size = new Size(109, 27);
            NextImgBtn.TabIndex = 5;
            NextImgBtn.Text = "Next >";
            NextImgBtn.UseVisualStyleBackColor = true;
            NextImgBtn.Click += NextImgBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1497, 761);
            Controls.Add(NextImgBtn);
            Controls.Add(PrevImgBtn);
            Controls.Add(selectedImage);
            Controls.Add(imageList);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 7, 5, 7);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)selectedImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList imageList1;
        private ToolStripMenuItem albumFotoToolStripMenuItem;
        private ToolStripMenuItem openDirectoryBtn;
        private MenuStrip menuStrip1;
        private ListView imageList;
        private PictureBox selectedImage;
        private Button PrevImgBtn;
        private Button NextImgBtn;
    }
}
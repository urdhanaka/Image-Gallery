using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Collections.Generic;

namespace Image_Gallery
{
    public partial class Form1 : Form
    {
        private int SelectedImageIndex = 0;
        private List<Image> LoadedImages { get; set; }

        public Form1() => InitializeComponent();

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void UploadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadDirectory();
        }

        private void LoadImageFromFolder(string[] paths)
        {
            LoadedImages = new List<Image>();
            foreach (var path in paths)
            {
                try
                {
                    var tempImage = Image.FromFile(path);
                    LoadedImages.Add(tempImage);
                } catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        private static void SelectTheClickedItem(ListView list, int index)
        {
            for (int item = 0; item < list.Items.Count; item++)
            {
                if (item == index)
                {
                    list.Items[item].Selected = true;
                }
                else
                {
                    list.Items[item].Selected = false;
                }
            }
        }

        private void LoadDirectory()
        {
            FolderBrowserDialog folderBrowser = new();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                // Selected directory
                var selectedDirectory = folderBrowser.SelectedPath;
                // Select image paths from selecte directory
                var imagePaths = Directory.GetFiles(selectedDirectory);
                // Loading images from images paths
                LoadImageFromFolder(imagePaths);

                ImageList images = new()
                {
                    ImageSize = new Size(120, 60)
                };

                foreach (var image in LoadedImages)
                {
                    images.Images.Add(image);
                }

                if (images.Images.Count > 0)
                {
                    imageList.Visible = true;
                    selectedImage.Visible = true;
                    menuStrip1.Visible = true;
                    NextImgBtn.Visible = true;
                    PrevImgBtn.Visible = true;
                    menuStrip1.Visible = true;
                }
                else
                {
                    selectedImage.Visible = false;
                    NextImgBtn.Visible = false;
                    PrevImgBtn.Visible = false;
                }

                // Set up our listview with imageList
                imageList.LargeImageList = images;
                for (int itemIndex = 1; itemIndex <= LoadedImages.Count; itemIndex++)
                {
                    imageList.Items.Add(new ListViewItem($"Image {itemIndex}", itemIndex - 1));
                }
            }
        }

        private void ImageList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (imageList.SelectedIndices.Count > 0)
            {
                var selectedIndex = imageList.SelectedIndices[0];
                Image selectedImg = LoadedImages[selectedIndex];
                selectedImage.Image = selectedImg;
                SelectedImageIndex = selectedIndex;
            }
        }

        private void PrevImgBtn_Click(object sender, EventArgs e)
        {
            if (SelectedImageIndex > 0)
            {
                SelectedImageIndex -= 1;
                Image selectedImg = LoadedImages[SelectedImageIndex]; if (selectedImg != null)
                {
                    selectedImage.Image = selectedImg;
                    SelectTheClickedItem(imageList, SelectedImageIndex);
                }
            }
        }

        private void NextImgBtn_Click(object sender, EventArgs e)
        {
            if (SelectedImageIndex < (LoadedImages.Count - 1))
            {
                SelectedImageIndex += 1;
                Image selectedImg = LoadedImages[SelectedImageIndex];
                selectedImage.Image = selectedImg;
                SelectTheClickedItem(imageList, SelectedImageIndex);
            }
        }
    }
}
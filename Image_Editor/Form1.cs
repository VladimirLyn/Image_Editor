
using System.Drawing.Imaging;
using System.IO;

namespace Image_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void OpenImage()
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if(dr == DialogResult.OK)
            {
                File = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = File;
                Opened = true;
            }
        }

        void SaveImage()
        {
            if (Opened)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Images|*.png;*.bpm;*.jpg";
                ImageFormat format = ImageFormat.Png;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string ext = Path.GetExtension(sfd.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    pictureBox1.Image.Save(sfd.FileName, format);
                }
            }
            else { MessageBox.Show("Не удаётся загрузить изображение"); }
        }

        void Reload()
        {
            if(!Opened)
            {
                MessageBox.Show("Ошибка");
            }
            else
            {
                if(Opened)
                {
                    File = Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.Image = File;
                    Opened = true;
                }
            }

        }
        void hue()
        {
            float changered = redbar.Value * 0.1f;
            float changegreen = greenbar.Value * 0.1f;
            float changeblue = bluebar.Value * 0.1f;

            //  redvalue.Text = changered.ToString();
            //  greenvalue.Text = changeblue.ToString();
            //  bluevalue.Text = changegreen.ToString();

            Reload();
            if (!Opened)
            {
            }
            else
            {



                Image img = pictureBox1.Image;                             // storing image into img variable of image type from picturebox1
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[]{1+changered, 0, 0, 0, 0},
            new float[]{0, 1+changegreen, 0, 0, 0},
            new float[]{0, 0, 1+changeblue, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
               location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
               format of graphics unit,provide the image attributes   */


                g.Dispose();                            //Releases all resources used by this Graphics.
                pictureBox1.Image = bmpInverted;


            }
        }









        Image File;
        Boolean Opened = false;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenImage();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SaveImage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void redbar_ValueChanged(object sender, EventArgs e)
        {
            hue();
        }

        private void greenbar_ValueChanged(object sender, EventArgs e)
        {
            hue();
        }

        private void bluebar_ValueChanged(object sender, EventArgs e)
        {
            hue();
        }
    }
}
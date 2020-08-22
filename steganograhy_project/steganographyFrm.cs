using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace steganograhy_project
{
    public partial class steganographyFrm : Form
    {
        public steganographyFrm()
        {
            InitializeComponent();
        }

        string loadedTrueImagePath, loadedFilePath, saveToImage, DLoadImagePath, DSaveFilePath;
        int height, width;
        long fileSize, fileNameSize;
        Image loadedTrueImage, DecryptedImage, AfterEncryption;

        private Bitmap bmp;

        Bitmap loadedTrueBitmap, DecryptedBitmap;
        Rectangle previewImage = new Rectangle(20, 160, 490, 470);

  
        bool canPaint = false, EncriptionDone = false;

   
        byte[] fileContainer;

      

        private void btn_imageENCRYPT_Click(object sender, EventArgs e)
        {
            if (dialog_imageENCRYPT.ShowDialog() == DialogResult.OK)
            {
                loadedTrueImagePath = dialog_imageENCRYPT.FileName; // Gets the image file location/path
                imageENCRYPT.Text = loadedTrueImagePath; // Inputs the image file location into the textbox
                loadedTrueImage = Image.FromFile(loadedTrueImagePath);
                height = loadedTrueImage.Height;
                width = loadedTrueImage.Width;
                loadedTrueBitmap = new Bitmap(loadedTrueImage);

                FileInfo imginf = new FileInfo(loadedTrueImagePath);
                canPaint = true;
                this.Invalidate();
            }
        }


        private void btn_textENCRYPT_Click(object sender, EventArgs e)
        {
            if (dialog_textENCRYPT.ShowDialog() == DialogResult.OK)
            {
                loadedFilePath = dialog_textENCRYPT.FileName; // Gets the text file location/path
                textENCRYPT.Text = loadedFilePath;   // Inputs the text file location into the textbox
                FileInfo finfo = new FileInfo(loadedFilePath);
                fileSize = finfo.Length;
                fileNameSize = justFName(loadedFilePath).Length;
            }
        }

        

        private string justFName(string path)
        {
            string output;
            int i;
            if (path.Length == 3)   // i.e: "C:\\"
                return path.Substring(0, 1);
            for (i = path.Length - 1; i > 0; i--)
                if (path[i] == '\\')
                    break;
            output = path.Substring(i + 1);
            return output;
        }


        private void btnENCRYPT_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Encrypting... Please wait";
            bmp = loadedTrueBitmap;
            String text = textENCRYPT.Text;
            if (savetextENCRYPT.ShowDialog() == DialogResult.OK)
            {
               
                saveToImage = savetextENCRYPT.FileName;
            }
            else
                return;
            if (textENCRYPT.Text == String.Empty || imageENCRYPT.Text == String.Empty)
            {
                MessageBox.Show("Encrypton information is incomplete!\nPlease complete them frist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (8 * ((height * (width / 3) * 3) / 3 - 1) < fileSize + fileNameSize)
            {
                MessageBox.Show("File size is too large!\nPlease use a smaller image to hide this file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            fileContainer = File.ReadAllBytes(loadedFilePath);

            

            //text = Steganography_enc.EncryptStringAES(text, passwordENCRYPT.Text);
            //Steganography_func.embedText(text, bmp);

            toolStripStatusLabel1.Text = "Encrypted image has been successfully saved.";
            EncriptionDone = true;
            bmp.Save(savetextENCRYPT.FileName);
            AfterEncryption = Image.FromFile(saveToImage);
            EncryptLayer();
        }

        private void btn_imageDECRYPT_Click(object sender, EventArgs e)
        {
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                DLoadImagePath = openFileDialog3.FileName; // Gets the file path of the encryted image
                imgDECRYPT.Text = DLoadImagePath; // Inputs the file path into the textbox
                DecryptedImage = Image.FromFile(DLoadImagePath);
                height = DecryptedImage.Height;
                width = DecryptedImage.Width;
                DecryptedBitmap = new Bitmap(DecryptedImage);

                FileInfo imginf = new FileInfo(DLoadImagePath);

                canPaint = true;
                this.Invalidate();
            }
        }

        private void btn_textDECRYPT_Click(object sender, EventArgs e)
        {
            if (savetextDECRYPT.ShowDialog() == DialogResult.OK)
            {
                DSaveFilePath = savetextDECRYPT.SelectedPath;  // Gets the file path to save the decryted file
                textDECRYPT.Text = DSaveFilePath; // Inputs the file path into the textbox
            }
        }

        private void btnDECRYPT_Click(object sender, EventArgs e)
        {
            if (textDECRYPT.Text == String.Empty || imgDECRYPT.Text == String.Empty)
            {
                MessageBox.Show("Text boxes must not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (System.IO.File.Exists(imgDECRYPT.Text) == false)
            {
                MessageBox.Show("Select image file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                imgDECRYPT.Focus();
                return;
            }



            DecryptLayer();
        }

        private void EncryptLayer()
        {
           
            toolStripStatusLabel1.Text = "Encrypting... Please wait";
            Application.DoEvents();
            long FSize = fileSize;
            Bitmap changedBitmap = EncryptLayer(8, loadedTrueBitmap, 0, (height * (width / 3) * 3) / 3 - fileNameSize - 1, true);
            FSize -= (height * (width / 3) * 3) / 3 - fileNameSize - 1;
            if (FSize > 0)
            {
                for (int i = 7; i >= 0 && FSize > 0; i--)
                {
                    changedBitmap = EncryptLayer(i, changedBitmap, (((8 - i) * height * (width / 3) * 3) / 3 - fileNameSize - (8 - i)), (((9 - i) * height * (width / 3) * 3) / 3 - fileNameSize - (9 - i)), false);
                    FSize -= (height * (width / 3) * 3) / 3 - 1;
                }
            }
            //changedBitmap.Save(saveToImage);
            toolStripStatusLabel1.Text = "Encrypted image has been successfully saved.";
            EncriptionDone = true;
            AfterEncryption = Image.FromFile(saveToImage);
            this.Invalidate();
        }

        private Bitmap EncryptLayer(int layer, Bitmap inputBitmap, long startPosition, long endPosition, bool writeFileName)
        {
            Bitmap outputBitmap = inputBitmap;
            layer--;
            int i = 0, j = 0;
            long FNSize = 0;
            bool[] t = new bool[8];
            bool[] rb = new bool[8];
            bool[] gb = new bool[8];
            bool[] bb = new bool[8];
            Color pixel = new Color();
            byte r, g, b;

            if (writeFileName)
            {
                FNSize = fileNameSize;
                string fileName = justFName(loadedFilePath);

                //write fileName:
                for (i = 0; i < height && i * (height / 3) < fileNameSize; i++)
                    for (j = 0; j < (width / 3) * 3 && i * (height / 3) + (j / 3) < fileNameSize; j++)
                    {
                        byte2bool((byte)fileName[i * (height / 3) + j / 3], ref t);
                        pixel = inputBitmap.GetPixel(j, i);
                        r = pixel.R;
                        g = pixel.G;
                        b = pixel.B;
                        byte2bool(r, ref rb);
                        byte2bool(g, ref gb);
                        byte2bool(b, ref bb);
                        if (j % 3 == 0)
                        {
                            rb[7] = t[0];
                            gb[7] = t[1];
                            bb[7] = t[2];
                        }
                        else if (j % 3 == 1)
                        {
                            rb[7] = t[3];
                            gb[7] = t[4];
                            bb[7] = t[5];
                        }
                        else
                        {
                            rb[7] = t[6];
                            gb[7] = t[7];
                        }
                        Color result = Color.FromArgb((int)bool2byte(rb), (int)bool2byte(gb), (int)bool2byte(bb));
                        outputBitmap.SetPixel(j, i, result);
                    }
                i--;
            }
            //write file (after file name):
            int tempj = j;

            for (; i < height && i * (height / 3) < endPosition - startPosition + FNSize && startPosition + i * (height / 3) < fileSize + FNSize; i++)
                for (j = 0; j < (width / 3) * 3 && i * (height / 3) + (j / 3) < endPosition - startPosition + FNSize && startPosition + i * (height / 3) + (j / 3) < fileSize + FNSize; j++)
                {
                    if (tempj != 0)
                    {
                        j = tempj;
                        tempj = 0;
                    }
                    byte2bool((byte)fileContainer[startPosition + i * (height / 3) + j / 3 - FNSize], ref t);
                    pixel = inputBitmap.GetPixel(j, i);
                    r = pixel.R;
                    g = pixel.G;
                    b = pixel.B;
                    byte2bool(r, ref rb);
                    byte2bool(g, ref gb);
                    byte2bool(b, ref bb);
                    if (j % 3 == 0)
                    {
                        rb[layer] = t[0];
                        gb[layer] = t[1];
                        bb[layer] = t[2];
                    }
                    else if (j % 3 == 1)
                    {
                        rb[layer] = t[3];
                        gb[layer] = t[4];
                        bb[layer] = t[5];
                    }
                    else
                    {
                        rb[layer] = t[6];
                        gb[layer] = t[7];
                    }
                    Color result = Color.FromArgb((int)bool2byte(rb), (int)bool2byte(gb), (int)bool2byte(bb));
                    outputBitmap.SetPixel(j, i, result);

                }
            long tempFS = fileSize, tempFNS = fileNameSize;
            r = (byte)(tempFS % 100);
            tempFS /= 100;
            g = (byte)(tempFS % 100);
            tempFS /= 100;
            b = (byte)(tempFS % 100);
            Color flenColor = Color.FromArgb(r, g, b);
            outputBitmap.SetPixel(width - 1, height - 1, flenColor);

            r = (byte)(tempFNS % 100);
            tempFNS /= 100;
            g = (byte)(tempFNS % 100);
            tempFNS /= 100;
            b = (byte)(tempFNS % 100);
            Color fnlenColor = Color.FromArgb(r, g, b);
            outputBitmap.SetPixel(width - 2, height - 1, fnlenColor);

            return outputBitmap;
        }

        private void DecryptLayer()
        {
            toolStripStatusLabel1.Text = "Decrypting... Please wait";
            Application.DoEvents();
            int i, j = 0;
            bool[] t = new bool[8];
            bool[] rb = new bool[8];
            bool[] gb = new bool[8];
            bool[] bb = new bool[8];
            Color pixel = new Color();
            byte r, g, b;
            pixel = DecryptedBitmap.GetPixel(width - 1, height - 1);
            long fSize = pixel.R + pixel.G * 100 + pixel.B * 10000;
            pixel = DecryptedBitmap.GetPixel(width - 2, height - 1);
            long fNameSize = pixel.R + pixel.G * 100 + pixel.B * 10000;
            byte[] res = new byte[fSize];
            string resFName = "";
            byte temp;

            //Read file name:
            for (i = 0; i < height && i * (height / 3) < fNameSize; i++)
                for (j = 0; j < (width / 3) * 3 && i * (height / 3) + (j / 3) < fNameSize; j++)
                {
                    pixel = DecryptedBitmap.GetPixel(j, i);
                    r = pixel.R;
                    g = pixel.G;
                    b = pixel.B;
                    byte2bool(r, ref rb);
                    byte2bool(g, ref gb);
                    byte2bool(b, ref bb);
                    if (j % 3 == 0)
                    {
                        t[0] = rb[7];
                        t[1] = gb[7];
                        t[2] = bb[7];
                    }
                    else if (j % 3 == 1)
                    {
                        t[3] = rb[7];
                        t[4] = gb[7];
                        t[5] = bb[7];
                    }
                    else
                    {
                        t[6] = rb[7];
                        t[7] = gb[7];
                        temp = bool2byte(t);
                        resFName += (char)temp;
                    }
                }

            //Read file on layer 8 (after file name):
            int tempj = j;
            i--;

            for (; i < height && i * (height / 3) < fSize + fNameSize; i++)
                for (j = 0; j < (width / 3) * 3 && i * (height / 3) + (j / 3) < (height * (width / 3) * 3) / 3 - 1 && i * (height / 3) + (j / 3) < fSize + fNameSize; j++)
                {
                    if (tempj != 0)
                    {
                        j = tempj;
                        tempj = 0;
                    }
                    pixel = DecryptedBitmap.GetPixel(j, i);
                    r = pixel.R;
                    g = pixel.G;
                    b = pixel.B;
                    byte2bool(r, ref rb);
                    byte2bool(g, ref gb);
                    byte2bool(b, ref bb);
                    if (j % 3 == 0)
                    {
                        t[0] = rb[7];
                        t[1] = gb[7];
                        t[2] = bb[7];
                    }
                    else if (j % 3 == 1)
                    {
                        t[3] = rb[7];
                        t[4] = gb[7];
                        t[5] = bb[7];
                    }
                    else
                    {
                        t[6] = rb[7];
                        t[7] = gb[7];
                        temp = bool2byte(t);
                        res[i * (height / 3) + j / 3 - fNameSize] = temp;
                    }
                }

            //Read file on other layers:
            long readedOnL8 = (height * (width/3)*3) /3 - fNameSize - 1;

            for (int layer = 6; layer >= 0 && readedOnL8 + (6 - layer) * ((height * (width / 3) * 3) / 3 - 1) < fSize; layer--)
                for (i = 0; i < height && i * (height / 3) + readedOnL8 + (6 - layer) * ((height * (width / 3) * 3) / 3 - 1) < fSize; i++)
                    for (j = 0; j < (width / 3) * 3 && i * (height / 3) + (j / 3) + readedOnL8 + (6 - layer) * ((height * (width / 3) * 3) / 3 - 1) < fSize; j++)
                    {
                        pixel = DecryptedBitmap.GetPixel(j, i);
                        r = pixel.R;
                        g = pixel.G;
                        b = pixel.B;
                        byte2bool(r, ref rb);
                        byte2bool(g, ref gb);
                        byte2bool(b, ref bb);
                        if (j % 3 == 0)
                        {
                            t[0] = rb[layer];
                            t[1] = gb[layer];
                            t[2] = bb[layer];
                        }
                        else if (j % 3 == 1)
                        {
                            t[3] = rb[layer];
                            t[4] = gb[layer];
                            t[5] = bb[layer];
                        }
                        else
                        {
                            t[6] = rb[layer];
                            t[7] = gb[layer];
                            temp = bool2byte(t);
                            res[i * (height / 3) + j / 3 + (6 - layer) * ((height * (width / 3) * 3) / 3 - 1) + readedOnL8] = temp;
                        }
                    }

            if (File.Exists(DSaveFilePath + "\\" + resFName))
            {
                MessageBox.Show("File \"" + resFName + "\" already exist please choose another path to save file", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
                File.WriteAllBytes(DSaveFilePath + "\\" + resFName, res);
            toolStripStatusLabel1.Text = "Decrypted file has been successfully saved.";
            Application.DoEvents();
        }

        private void byte2bool(byte inp, ref bool[] outp)
        {
            if (inp >= 0 && inp <= 255)
                for (short i = 7; i >= 0; i--)
                {
                    if (inp % 2 == 1)
                        outp[i] = true;
                    else
                        outp[i] = false;
                    inp /= 2;
                }
            else
                throw new Exception("Input number is illegal.");
        }

        private byte bool2byte(bool[] inp)
        {
            byte outp = 0;
            for (short i = 7; i >= 0; i--)
            {
                if (inp[i])
                    outp += (byte)Math.Pow(2.0, (double)(7 - i));
            }
            return outp;
        }


        private void btn_clear_Click(object sender, EventArgs e)
        {
            imageENCRYPT.Text = " ";
            textENCRYPT.Text = " ";
            imgDECRYPT.Text = " ";
            textDECRYPT.Text = " ";
            toolStripStatusLabel1.Text = "Okay";
        }



    }
}

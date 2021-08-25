using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Practico1_Ejercicio1_TDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                 string path = openFile.FileName;
                outputTextBox.Text = path;
                if (File.Exists(path))
                {
                    byte[] bytes = new byte[4];
                    FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                    fileStream.Read(bytes, 0, 4);
                    string description = BitConverter.ToString(bytes);
                    string riff = System.Text.Encoding.ASCII.GetString(bytes);
                    MessageBox.Show("Los primeros 4 bytes: "+ riff); 
                    if (riff == "RIFF")
                    {
                        MessageBox.Show("Archivo WAV válido");
                    }
                    else
                    {
                        MessageBox.Show("Archivo WAV inválido");
                    }
                    
                    
                    
                    
                    //fileStream.Seek(16, 0);
                    //fileStream.Read(bytes, 0, 4);
                    //fileStream.Close();
                    //int Subchunk1Size = BitConverter.ToInt32(bytes, 0);

                    //if (Subchunk1Size < 16)
                    //    MessageBox.Show("This is not a valid wav file");
                    //else
                    //    switch (Subchunk1Size)
                    //    {
                    //        case 16:
                    //            MessageBox.Show("44-byte header");
                    //            break;
                    //        case 18:
                    //            MessageBox.Show("46-byte header");
                    //            break;
                    //        default:
                    //            MessageBox.Show("Header contains extra data and is larger than 46 bytes");
                    //            break;
                    //    }


                }
            }
        }

        

      

}
}

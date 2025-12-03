using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace SlotMachineDemo
{
    public partial class Slots : Form
    {
        private List<int> texturiGL;
        private Random rnd = new Random();
        private Timer timer;
        private int cicluriRamase;
        private int credits = 500;
        private bool firstDrawDone = false;

        private int slot1Tex, slot2Tex, slot3Tex, slot4Tex, slot5Tex, slot6Tex, slot7Tex, slot8Tex, slot9Tex;

        public Slots()
        {
            InitializeComponent();

            TbCredits.Text = credits.ToString();

            gl1.Load += GL_Load;
            gl2.Load += GL_Load;
            gl3.Load += GL_Load;
            gl4.Load += GL_Load;
            gl5.Load += GL_Load;
            gl6.Load += GL_Load;
            gl7.Load += GL_Load;
            gl8.Load += GL_Load;
            gl9.Load += GL_Load;

            gl1.Paint += (s, e) => GL_Draw(slot1Tex, gl1);
            gl2.Paint += (s, e) => GL_Draw(slot2Tex, gl2);
            gl3.Paint += (s, e) => GL_Draw(slot3Tex, gl3);
            gl4.Paint += (s, e) => GL_Draw(slot4Tex, gl4);
            gl5.Paint += (s, e) => GL_Draw(slot5Tex, gl5);
            gl6.Paint += (s, e) => GL_Draw(slot6Tex, gl6);
            gl7.Paint += (s, e) => GL_Draw(slot7Tex, gl7);
            gl8.Paint += (s, e) => GL_Draw(slot8Tex, gl8);
            gl9.Paint += (s, e) => GL_Draw(slot9Tex, gl9);

            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;

            BPull.Click += BPull_Click;
        }

        private bool texturesLoaded = false;

        private bool texturesInitialized = false;

        private void GL_Load(object sender, EventArgs e)
        {
            var gl = (OpenTK.GLControl)sender;
            gl.MakeCurrent();

            texturiGL = new List<int>()
    {
        LoadTexture(new Bitmap(Properties.Resources.img1)),
        LoadTexture(new Bitmap(Properties.Resources.img2)),
        LoadTexture(new Bitmap(Properties.Resources.img3)),
        LoadTexture(new Bitmap(Properties.Resources.img4)),
        LoadTexture(new Bitmap(Properties.Resources.img5)),
        LoadTexture(new Bitmap(Properties.Resources.img6))
    };

            GL.ClearColor(Color.Black);
            GL.Enable(EnableCap.Texture2D);
            GL.Viewport(0, 0, gl.Width, gl.Height);

            if (!firstDrawDone)
            {
                Application.Idle += FirstDrawOnce;
            }
        }

        private void DrawTexture(int texID)
        {
            GL.BindTexture(TextureTarget.Texture2D, texID);

            GL.Begin(PrimitiveType.Quads);

            GL.TexCoord2(0, 1); GL.Vertex2(-1, -1);
            GL.TexCoord2(1, 1); GL.Vertex2(1, -1);
            GL.TexCoord2(1, 0); GL.Vertex2(1, 1);
            GL.TexCoord2(0, 0); GL.Vertex2(-1, 1);

            GL.End();
        }

        private void GL_Draw(int texID, OpenTK.GLControl gl)
        {
            gl.MakeCurrent();  

            GL.Clear(ClearBufferMask.ColorBufferBit);
            DrawTexture(texID);
            gl.SwapBuffers();
        }

        private int LoadTexture(Bitmap bmp)
        {
            int texID;
            GL.GenTextures(1, out texID);
            GL.BindTexture(TextureTarget.Texture2D, texID);

            BitmapData data = bmp.LockBits(
                new Rectangle(0, 0, bmp.Width, bmp.Height),
                ImageLockMode.ReadOnly,
                System.Drawing.Imaging.PixelFormat.Format32bppArgb
            );

            GL.TexImage2D(TextureTarget.Texture2D, 0,
                PixelInternalFormat.Rgba, data.Width, data.Height, 0,
                OpenTK.Graphics.OpenGL.PixelFormat.Bgra,
                PixelType.UnsignedByte, data.Scan0);

            bmp.UnlockBits(data);

            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);

            return texID;
        }

        private void BPull_Click(object sender, EventArgs e)
        {
            if (credits < 50)
            {
                MessageBox.Show("Nu mai ai suficient credite!");
                return;
            }

            credits -= 50;
            TbCredits.Text = credits.ToString();

            cicluriRamase = (int)UDCycles.Value;
            timer.Start();
        }

        private void glControl5_Load(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (cicluriRamase > 0)
            {
                cicluriRamase--;

                slot1Tex = texturiGL[rnd.Next(texturiGL.Count)];
                slot2Tex = texturiGL[rnd.Next(texturiGL.Count)];
                slot3Tex = texturiGL[rnd.Next(texturiGL.Count)];
                slot4Tex = texturiGL[rnd.Next(texturiGL.Count)];
                slot5Tex = texturiGL[rnd.Next(texturiGL.Count)];
                slot6Tex = texturiGL[rnd.Next(texturiGL.Count)];
                slot7Tex = texturiGL[rnd.Next(texturiGL.Count)];
                slot8Tex = texturiGL[rnd.Next(texturiGL.Count)];
                slot9Tex = texturiGL[rnd.Next(texturiGL.Count)];

                gl1.Invalidate();
                gl2.Invalidate();
                gl3.Invalidate();
                gl4.Invalidate();
                gl5.Invalidate();
                gl6.Invalidate();
                gl7.Invalidate();
                gl8.Invalidate();
                gl9.Invalidate();
            }
            else
            {
                timer.Stop();
                VerificaRezultat();
            }
        }

        private void VerificaRezultat()
        {
            if (slot1Tex == slot2Tex && slot2Tex == slot3Tex)
            {
                TbMesaj.Text = "✨ Ai câștigat!";
                credits += 75;
            }
            else
            {
                TbMesaj.Text = "Ai pierdut!";
            }

            TbCredits.Text = credits.ToString();
        }

        private void FirstDrawOnce(object sender, EventArgs e)
        {
            gl1.MakeCurrent(); GL_Draw(texturiGL[0], gl1);
            gl2.MakeCurrent(); GL_Draw(texturiGL[0], gl2);
            gl3.MakeCurrent(); GL_Draw(texturiGL[0], gl3);
            gl4.MakeCurrent(); GL_Draw(texturiGL[0], gl4);
            gl5.MakeCurrent(); GL_Draw(texturiGL[0], gl5);
            gl6.MakeCurrent(); GL_Draw(texturiGL[0], gl6);
            gl7.MakeCurrent(); GL_Draw(texturiGL[0], gl7);
            gl8.MakeCurrent(); GL_Draw(texturiGL[0], gl8);
            gl9.MakeCurrent(); GL_Draw(texturiGL[0], gl9);

            Application.Idle -= FirstDrawOnce;
            firstDrawDone = true;
        }
    }
}

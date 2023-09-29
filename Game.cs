using OpenTK.Graphics;
using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using static Tarea_01.Shelf;
using static Tarea_01.Wall;

namespace Tarea_01
{
    public class Game:GameWindow
    {
        private float angle = 0.0f;
        
        
        private List<Wall> paredes;




        public Game(int width, int height) : base(width, height, GraphicsMode.Default, "Pared Vertical 3D")
        {
            paredes = new List<Wall>();
           
            paredes.Add(new Wall(new Vector3(0.0f, 0.0f, 0.0f), 2.0f, 2.0f, 0.3f));
            paredes.Add(new Wall(new Vector3(2.0f, 0.1f, 0.0f), 1.0f, 1.2f, 0.3f));
            paredes.Add(new Wall(new Vector3(-0.0f, 0.4f, -2.0f), 1.0f, 1.0f, 0.3f));
            paredes.Add(new Wall(new Vector3(-2.0f, 0.2f, 0.3f), 1.0f, 1.0f, 0.3f));
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(0.1f, 0.12f, 0.13f, 0.1f);
            GL.Enable(EnableCap.DepthTest);//hace que no se vean los objetos dibujados atras
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(0, 0, Width, Height);
            float aspectRatio = (float)Width / Height;
            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(
                MathHelper.DegreesToRadians(45.0f), aspectRatio, 0.1f, 100.0f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            // Rotación de la pared
            angle += (float)e.Time * 25.0f;
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            Matrix4 modelview = Matrix4.LookAt(
                new Vector3(0.0f, 0.0f, 4.0f), // Posición de la cámara
                new Vector3(0, 0, 0), // Punto de mira
                Vector3.UnitY); // Vector arriba
            GL.LoadMatrix(ref modelview);

            
            GL.Rotate(angle, Vector3.UnitY);

            
            foreach (var pared in paredes)
            {
                pared.Draw();
            }

            SwapBuffers();
        }
    }
}

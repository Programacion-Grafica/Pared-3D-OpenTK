using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Tarea_01
{
    public static class Shelf
    {
        public static void Render()
        {
            // Dimensiones del automóvil
            

            GL.Begin(PrimitiveType.Quads);
            GL.Color4(Color4.Coral);

            // Base del automóvil
            GL.Vertex3(-1.0f, -0.1f, 0.16f);
            GL.Vertex3(1.0f, -0.1f, 0.16f);
            GL.Vertex3(1.0f, 0.0f, 0.16f);
            GL.Vertex3(-1.0f, 0.0f, 0.16f);

            GL.Vertex3(-1.0f, -0.1f, 0.58f);
            GL.Vertex3(1.0f, -0.1f, 0.58f);
            GL.Vertex3(1.0f, 0.0f, 0.58f);
            GL.Vertex3(-1.0f, 0.0f, 0.58f);

            GL.Vertex3(-1.0f, -0.0f, 0.58f);
            GL.Vertex3(1.0f, -0.0f, 0.58f);
            GL.Vertex3(1.0f, -0.01f, 0.16f);
            GL.Vertex3(-1.0f, -0.01f, 0.16f);

            GL.Vertex3(-1.0f, -0.1f, .16f);
            GL.Vertex3(1.0f, -0.1f, .16f);
            GL.Vertex3(1.0f, -0.1f, .58f);
            GL.Vertex3(-1.0f, -0.1f, .58f);

            GL.Vertex3(-1.0f, -0.1f, .0f);
            GL.Vertex3(-1.0f, 0.0f, .0f);
            GL.Vertex3(-1.0f, 0.0f, .58f);
            GL.Vertex3(-1.0f, -0.1f, .58f);

            GL.Vertex3(1.0f, -0.1f, .58f);
            GL.Vertex3(1.0f, 0.0f, .58f);
            GL.Vertex3(1.0f, 0.0f, .16f);
            GL.Vertex3(1.0f, -0.1f, .16f);

            GL.End();
          
        }  
    }
}

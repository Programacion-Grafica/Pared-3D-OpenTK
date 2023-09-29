using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using static Tarea_01.Shelf;

namespace Tarea_01
{
    public  class Wall
    {
        private Vector3 position;
        private float width;
        private float height;
        private float depth;

        public Wall(Vector3 position, float width, float height, float depth)
        {
            this.position = position;
            this.width = width;
            this.height = height;
            this.depth = depth;
        }

        public void Draw()
        {
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.6f, 0.7f); // naranja opaco

            //1: ,2:altura del plano ,3:posicion en z espacio que se aleja del punto de origen

            float x1 = position.X - width / 2;
            float x2 = position.X + width / 2;
            float y1 = position.Y - height / 2;
            float y2 = position.Y + height / 2;
            float z1 = position.Z;
            float z2 = position.Z + depth;

            // Dibuja la pared
            // Cara frontal
            GL.Vertex3(x1, y1, z1);
            GL.Vertex3(x2, y1, z1);
            GL.Vertex3(x2, y2, z1);
            GL.Vertex3(x1, y2, z1);

            // Cara trasera
            GL.Vertex3(x1, y1, z2);
            GL.Vertex3(x2, y1, z2);
            GL.Vertex3(x2, y2, z2);
            GL.Vertex3(x1, y2, z2);

            // Otras caras de la pared
            // Cara superior
            GL.Vertex3(x1, y2, z1);
            GL.Vertex3(x2, y2, z1);
            GL.Vertex3(x2, y2, z2);
            GL.Vertex3(x1, y2, z2);

            // Cara inferior
            GL.Vertex3(x1, y1, z1);
            GL.Vertex3(x2, y1, z1);
            GL.Vertex3(x2, y1, z2);
            GL.Vertex3(x1, y1, z2);

            // Cara izquierda
            GL.Vertex3(x1, y1, z1);
            GL.Vertex3(x1, y2, z1);
            GL.Vertex3(x1, y2, z2);
            GL.Vertex3(x1, y1, z2);

            // Cara derecha
            GL.Vertex3(x2, y1, z1);
            GL.Vertex3(x2, y2, z1);
            GL.Vertex3(x2, y2, z2);
            GL.Vertex3(x2, y1, z2);
            Render();

            GL.End();

           

           // Render();

            
        }
    }
}

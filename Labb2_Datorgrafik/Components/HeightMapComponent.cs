﻿using Microsoft.Xna.Framework.Graphics;

namespace Labb2_Datorgrafik.Components
{
    public class HeightMapComponent : IComponent
    {
        public string HeightMapFilePath;
        public Texture2D HeightMap;
        public int Width;
        public int Height;
        public GraphicsDevice GraphicsDevice;
        public VertexBuffer[] VertexBuffers;
        public IndexBuffer[] IndexBuffers;

        public HeightMapComponent(GraphicsDevice graphicsDevice)
        {
            GraphicsDevice = graphicsDevice;
        }
    }
}
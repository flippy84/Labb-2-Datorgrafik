﻿using Labb2_Datorgrafik.Components;
using Labb2_Datorgrafik.Managers;
using Labb2_Datorgrafik.Tools;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Labb2_Datorgrafik.Systems
{
    class ModelSystem : IRender
    {
        public void Load(ContentManager content)
        {
            ComponentManager cm = ComponentManager.GetInstance();
            foreach (var (_, modelComp) in cm.GetComponentsOfType<ModelComponent>())
            {
                modelComp.Model = content.Load<Model>(modelComp.ModelPath);
            }
        }

        public void Render(GraphicsDevice gd, BasicEffect be)
        {
            ComponentManager cm = ComponentManager.GetInstance();

            foreach (var (_, modelComp, transComp) in cm.GetComponentsOfType<ModelComponent, TransformComponent>())
            {
                ModelHelper.Render(be, modelComp, transComp.World);
            }
        }
    }
}

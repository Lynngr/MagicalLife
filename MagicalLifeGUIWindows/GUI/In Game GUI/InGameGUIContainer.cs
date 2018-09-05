﻿using MagicalLifeGUIWindows.GUI.Reusable;
using Microsoft.Xna.Framework;

namespace MagicalLifeGUIWindows.GUI.In
{
    /// <summary>
    /// The in game GUI container.
    /// </summary>
    public class InGameGUIContainer : GUIContainer
    {
        public MineActionButton MineActionButton { get; set; } = new MineActionButton();

        public InGameGUIContainer(bool visible) : base("MenuBackground", GetDrawingBounds())
        {
            this.Visible = visible;
            this.Controls.Add(this.MineActionButton);
        }

        /// <summary>
        /// Returns the bounds of which this should be rendered at.
        /// </summary>
        /// <returns></returns>
        public static Rectangle GetDrawingBounds()
        {
            int x = InGameGUILayout.ContainerX;
            int y = InGameGUILayout.ContainerY;
            int width = InGameGUILayout.ContainerWidth;
            int height = InGameGUILayout.ContainerHeight;

            return new Rectangle(x, y, width, height);
        }

        public override string GetTextureName()
        {
            return "MenuBackground";
        }
    }
}
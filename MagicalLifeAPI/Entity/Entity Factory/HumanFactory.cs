﻿using MagicalLifeAPI.DataTypes;
using MagicalLifeAPI.Entity.Humanoid;
using MagicalLifeAPI.Util;
using System;

namespace MagicalLifeAPI.Entity.Entity
{
    /// <summary>
    /// Used to initialize a new human properly.
    /// </summary>
    public class HumanFactory
    {
        /// <summary>
        /// The maximum number of hit Point2Ds that a human could get per level.
        /// </summary>
        private readonly int MaxHumanHealthPerLevel = 10;

        /// <summary>
        /// The minimum number of hit Point2Ds that a human could get per level.
        /// </summary>
        private readonly int MinHumanHealthPerLevel = 2;

        /// <summary>
        /// The fastest a human could possibly be without starting down a class path.
        /// </summary>
        private readonly double MaxHumanMovement = .1;

        /// <summary>
        /// The slowest a human could possibly be without some significant injuries.
        /// </summary>
        private readonly double MinHumanMovement = .05;

        /// <summary>
        /// Returns a fully generated human character.
        /// </summary>
        /// <returns></returns>
        public Human GenerateHuman(Point2D location, int dimension, Guid playerID)
        {
            int health = StaticRandom.Rand(this.MinHumanHealthPerLevel, this.MaxHumanHealthPerLevel);
            float movement = (float)StaticRandom.Rand(this.MinHumanMovement, this.MaxHumanMovement);

            return new Human(health, movement, location, dimension, playerID);
        }
    }
}
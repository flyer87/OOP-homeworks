﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class IndestructibleBlock : Block
    {
        public const char Symbol = '|';

        public new const string CollisionGroupString = "indestructibleBlock";

        public IndestructibleBlock(MatrixCoords upperLeft)
            : base(upperLeft)
        {
            this.body[0, 0] = IndestructibleBlock.Symbol;
        }

 
        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = false;
            // pri sblasak ne se unijsiojawa
        }

        public override string GetCollisionGroupString()
        {
            return IndestructibleBlock.CollisionGroupString;
        }



     }
}

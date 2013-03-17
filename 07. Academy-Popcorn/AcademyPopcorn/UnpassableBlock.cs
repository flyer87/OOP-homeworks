using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class UnpassableBlock : Block
    {
        public new const string CollisionGroupString = "unpassableBlock";

        public UnpassableBlock(MatrixCoords topLeft)
            : base(topLeft)
        {
            this.body = new char[,] { {'%'} };
        }


        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = false;
            // pri sblasak NE se unijsiojawa
        }

        public override string GetCollisionGroupString()
        {
            return UnpassableBlock.CollisionGroupString;
        }



    }
}

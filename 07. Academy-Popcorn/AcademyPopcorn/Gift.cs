using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class Gift : MovingObject
    {
        public new const string CollisionGroupString = "gift";

        public Gift(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, new char[,] { { '$' } }, speed)
        {
        }

        //                      canHit
        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "racket";
        }

        public override string GetCollisionGroupString()
        {
            return Gift.CollisionGroupString;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = false;
            if (collisionData.hitObjectsCollisionGroupStrings.IndexOf("racket") > -1)
            {
                this.IsDestroyed = true;
            }
        }


    }
}

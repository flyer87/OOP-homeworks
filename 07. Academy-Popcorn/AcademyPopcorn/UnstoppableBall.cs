using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class UnstoppableBall : Ball
    {
        public new const string CollisionGroupString = "unstoppableBall";

        public UnstoppableBall(MatrixCoords topLeft, MatrixCoords speed) :
            base(topLeft, speed)
        {
            this.body = new char[,] { { 'Q' } };
        }
              

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "racket" || otherCollisionGroupString == "block" || otherCollisionGroupString == "unpassableBlock";
        }

        public override string GetCollisionGroupString()
        {
            return Ball.CollisionGroupString;
        }


        public override void RespondToCollision(CollisionData collisionData)
        {
            if (
                    collisionData.hitObjectsCollisionGroupStrings.IndexOf("unpassableBlock") > -1 ||
                    collisionData.hitObjectsCollisionGroupStrings.IndexOf("indestructibleBlock") > -1 ||
                    collisionData.hitObjectsCollisionGroupStrings.IndexOf("racket") > -1
                )
            {
                if (collisionData.CollisionForceDirection.Row * this.Speed.Row < 0)
                {
                    this.Speed.Row *= -1;
                }
                if (collisionData.CollisionForceDirection.Col * this.Speed.Col < 0)
                {
                    this.Speed.Col *= -1;
                }
            }
        }

    }
}

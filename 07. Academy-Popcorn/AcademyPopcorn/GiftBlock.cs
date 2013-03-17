using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class GiftBlock : Block
    {
        public new const string CollisionGroupString = "giftBlock";

        public GiftBlock(MatrixCoords topLeft)
            : base(topLeft)
        {
            this.body = new char[,] { { '?' } };
        }

        public override void Update()
        {
        }

        //                      canHit
        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "ball";
            // moje da se sblaska s topka 
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
            // pri wseki sblasak se unijsiojawa
        }

        public override string GetCollisionGroupString()
        {
            return GiftBlock.CollisionGroupString;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> producedObjects = new List<GameObject>();
            if (this.IsDestroyed)
            {
                producedObjects.Add(new Gift(this.topLeft, new MatrixCoords(1, 0)));
            }
            return producedObjects;
        }

    }
}

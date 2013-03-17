using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class TrailObject : GameObject
    {
        private uint lifeTime;

        public TrailObject(MatrixCoords topLeft, uint lifeTime) :
            base(topLeft, new char[,] { { '*' } })
        {
            this.lifeTime = lifeTime;
        }

        public override void Update()
        {
            this.lifeTime--;
            if (lifeTime <= 0)
            {
                this.IsDestroyed = true;
            }
        }
    }
}

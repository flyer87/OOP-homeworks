using System;
using System.Collections.Generic;

namespace AcademyPopcorn
{
    class MeteoriteBall : Ball
    {
        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        {
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> producedObjects = new List<GameObject>();
            producedObjects.Add(new TrailObject(base.topLeft, 3));

            return producedObjects;            
        }
    }
}

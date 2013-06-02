using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            // add ceiling Indesctructable blocks
            for (int i = 0; i < WorldCols; i++)
            {
                IndestructibleBlock borderBlock = new IndestructibleBlock(new MatrixCoords(0, i));
                engine.AddObject(borderBlock);
            }

            // add rigth-side Indesctructable blocks
            for (int i = 0; i < WorldRows; i++)
            {
                IndestructibleBlock borderBlock = new IndestructibleBlock(new MatrixCoords(i, WorldCols - 1));
                engine.AddObject(borderBlock);
            }

            // add left-side Indesctructable blocks
            for (int i = 0; i < WorldRows; i++)
            {
                IndestructibleBlock borderBlock = new IndestructibleBlock(new MatrixCoords(i, 0));
                engine.AddObject(borderBlock);
            }


            // add Blocks
            //for (int i = startCol; i < endCol; i++)
            //{
            //    Block currBlock = new Block(new MatrixCoords(startRow, i));
            //    engine.AddObject(currBlock);
            //}

            // add Unpassable Blocks
            //for (int i = startCol; i < endCol; i++)
            //{
            //    UnpassableBlock currBlock = new UnpassableBlock(new MatrixCoords(startRow, i));
            //    engine.AddObject(currBlock);
            //}

            //// add Blocks + Exploding Block
            //for (int i = startCol; i < endCol; i++)
            //{
            //    GameObject currBlock = new UnpassableBlock(new MatrixCoords(startRow, i));
            //    if (i == 7)
            //    {
            //        currBlock = new ExplodingBlock(new MatrixCoords(startRow, i));
            //    }
            //    engine.AddObject(currBlock);
            //}

            // add Blocks + GiftBlock
            for (int i = startCol; i < endCol; i++)
            {
                GameObject currBlock = new Block(new MatrixCoords(startRow, i));
                if (i == 7)
                {
                    currBlock = new GiftBlock(new MatrixCoords(startRow, i));
                }

                engine.AddObject(currBlock);
            }


            // add Gift
            //Gift giftBlock = new Gift(new MatrixCoords(6, 15), new MatrixCoords(1, 0));
            //engine.AddObject(giftBlock);


            // add Trail Object
            //TrailObject trail = new TrailObject(new MatrixCoords(10, 5), 3);
            //engine.AddObject(trail);




            // add normal Ball
            Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1));
            engine.AddObject(theBall);


            // add Meteorite Ball
            //MeteoriteBall theBall = new MeteoriteBall (new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1));
            //engine.AddObject(theBall);

            // add UnstoppableBall Ball
            //UnstoppableBall theBall = new UnstoppableBall(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1));
            //engine.AddObject(theBall);



            // add Racket
            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);
            engine.AddObject(theRacket);
        }

        //  --------============  MAIN  ========-----------
        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();
            int sleepTime = 300;

            Engine gameEngine = new Engine(renderer, keyboard, sleepTime);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };


            Initialize(gameEngine);
            gameEngine.Run();
        }
    }
}

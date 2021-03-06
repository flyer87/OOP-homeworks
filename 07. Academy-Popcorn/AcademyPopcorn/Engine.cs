﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class Engine
    {
        IRenderer renderer;
        IUserInterface userInterface;
        List<GameObject> allObjects;
        List<MovingObject> movingObjects;
        List<GameObject> staticObjects;
        Racket playerRacket;
        int sleepTime;

        public Engine(IRenderer renderer, IUserInterface userInterface, int sleepTime)
        {
            this.renderer = renderer;
            this.userInterface = userInterface;
            this.sleepTime = sleepTime;
            this.allObjects = new List<GameObject>();
            this.movingObjects = new List<MovingObject>();
            this.staticObjects = new List<GameObject>();
        }

        // razgledai
        private void AddStaticObject(GameObject obj)
        {
            this.staticObjects.Add(obj);
            this.allObjects.Add(obj);
        }

        // razgledai 
        private void AddMovingObject(MovingObject obj)
        {
            this.movingObjects.Add(obj);
            this.allObjects.Add(obj);
        }

        public virtual void AddObject(GameObject obj)
        {
            if (obj is MovingObject)
            {
                this.AddMovingObject(obj as MovingObject);
            }
            else
            {
                if (obj is Racket)
                {
                    AddRacket(obj);
                }
                else
                {
                    this.AddStaticObject(obj);
                }
            }
        }

        // razgledai 
        private void AddRacket(GameObject obj)
        {
            //TODO: we should remove the previous racket from this.allObjects
            this.playerRacket = obj as Racket;
            this.AddStaticObject(obj);
        }

        public void RemoveRacket()
        {
            // remove from allObjects
            for (int i = 0; i < allObjects.Count; i++)
            {
                if (allObjects[i] is Racket)
                {
                    allObjects.RemoveAt(i);
                }
            }

            // remove from staticObjects
            for (int i = 0; i < staticObjects.Count; i++)
            {
                if (staticObjects[i] is Racket)
                {
                    staticObjects.RemoveAt(i);
                }
            }
        }

        public virtual void MovePlayerRacketLeft()
        {
            this.playerRacket.MoveLeft();
        }

        public virtual void MovePlayerRacketRight()
        {
            this.playerRacket.MoveRight();
        }

        public virtual void Run()
        {
            while (true)
            {
                this.renderer.RenderAll();

                // w konstruktoa 
                System.Threading.Thread.Sleep(sleepTime);

                this.userInterface.ProcessInput();

                this.renderer.ClearQueue();

                foreach (var obj in this.allObjects)
                {
                    obj.Update();
                    this.renderer.EnqueueForRendering(obj);
                }

                // ne ni interesuwa za momenta
                CollisionDispatcher.HandleCollisions(this.movingObjects, this.staticObjects);
                
                List<GameObject> producedObjects = new List<GameObject>();

                foreach (var obj in this.allObjects)
                {
                    producedObjects.AddRange(obj.ProduceObjects());
                }

                this.allObjects.RemoveAll(obj => obj.IsDestroyed);
                this.movingObjects.RemoveAll(obj => obj.IsDestroyed);
                this.staticObjects.RemoveAll(obj => obj.IsDestroyed);

                foreach (var obj in producedObjects)
                {
                    this.AddObject(obj);
                }
            }
        }
    }
}

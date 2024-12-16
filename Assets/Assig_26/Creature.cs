using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment_26
{
    public class Creature
    {
        public virtual void Speak()
        {
            Debug.Log("A creature makes a sound.");
        }
    }

    interface IRunnable
    {
        void Run();
    }
    interface IJumpable
    {
        void Jump();
    }
    interface ISwimmable
    {
        void Swim();
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment_26
{

    public class CreatureManager : MonoBehaviour
    {
        void Start()
        {
            List<Creature> creatures = new List<Creature>() { new Kangaroo(), new Duck() };

            List<IRunnable> run = new List<IRunnable>();
            List<IJumpable> jump = new List<IJumpable>();
            List<ISwimmable> swim = new List<ISwimmable>();

            Kangaroo kangaroo = new Kangaroo();
            Duck duck = new Duck();

            run.Add(kangaroo);
            run.Add(duck);

            jump.Add(kangaroo);
            swim.Add(duck);

            foreach (var creature in creatures)
            {
                creature.Speak();
            }
            foreach (var runn in run)
            {
                runn.Run();
            }
            foreach (var jumpp in jump)
            {
                jumpp.Jump();
            }
            foreach (var swimm in swim)
            {
                swimm.Swim();
            }
        }
    }
}

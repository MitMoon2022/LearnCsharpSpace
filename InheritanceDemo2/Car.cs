using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    //implementing the interface IDestroyable
    class Car : Vehicle, IDestroyable
    {
        //implementing the interface's property
        public string DestructionSound { get; set; }

        //creating a new property to store the destroyable objects nearby
        //when a car gets destroyed it should also destroy the nearby object
        //this list is of type IDestroyable which means it can store any object
        //that implements this interface and we can only access the properties and
        //methods in this interface
        // public List&lt;IDestroyable &gt;DestoryablesNearby;
        public List<IDestroyable> DestoryablesNearby;
            
    public Car(float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;
            //initialize the interface's property with a value in the constructor
            DestructionSound = "CarExplosionSound.mp3";
            //initialize the list of destroyable objects
            DestoryablesNearby = new List<IDestroyable>();
        }

        //implementing the interface's method
        public void Destroy()
        {
            //when a car gets destroyed we should play the destruction sound
            //and create fire effect
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Create fire");
            //go through each destoryable object nearby and call it's destroy method
            foreach (IDestroyable destroyable in DestoryablesNearby)
            {
                destroyable.Destroy();
            }

        }

    }

}

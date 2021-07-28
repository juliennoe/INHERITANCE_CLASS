using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    void Start()
    {
        Dog myDog = new Dog(); // classic dog

        myDog.MakeSound(); // general behaviour
        myDog.Move(); // general behaviour
        myDog.WaigTail(); // specific behaviour

        Bird theBird = new Bird(); // classic bird

        theBird.MakeSound(); // general behaviour
        theBird.Move(); // general behaviour
        theBird.LayEgg(); // specific behaviour

        Dog hisDog = new Dog("Corgi","Tan"); // custom dog
        hisDog.Move(); // general behaviour
        hisDog.DisplayBreed(); // general behaviour
        hisDog.WaigTail(); // specific behaviour
    } 
}

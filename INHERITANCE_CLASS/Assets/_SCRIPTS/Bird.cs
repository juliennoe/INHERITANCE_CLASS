using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{
    public Bird() // default constructor
    {
        m_sound = "chrip"; // specific behaviour
        m_mouvementType = "flying"; // specific behaviour
        m_animalType = "bird"; // specific behaviour
    }

    public void LayEgg() // specific function for bird
    {
        Debug.Log("the bird layed a egg");
    }
}

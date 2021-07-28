using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal 
{
    public string m_sound;
    public string m_mouvementType;
    public string m_animalType;


    public void Move()
    {
        Debug.Log("The " + m_animalType + " says " + m_mouvementType);
    }

    public void MakeSound()
    {
        Debug.Log("The " + m_animalType + " says " + m_sound);
    }
}

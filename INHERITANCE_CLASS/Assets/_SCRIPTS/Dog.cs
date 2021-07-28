using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    public string m_furColor;

    public Dog() // default constructor
    {
        m_sound = "wouf";
        m_mouvementType = "running";
        m_animalType = "dog";
        m_furColor = "brown";
    }

    public Dog(string _animalType, string _furColor) //custom constructor
    {
        m_sound = "wouf";
        m_mouvementType = "running";
        m_animalType = _animalType;
        m_furColor = _furColor;
    }

    public void WaigTail() // specific function for Dog
    {
        Debug.Log("The Dog is wagging it's tail");
    }

    public void DisplayBreed()
    {
        Debug.Log("The Dog is a" + m_furColor + " " + m_animalType);
    }
}

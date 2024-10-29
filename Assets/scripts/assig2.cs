using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assig2 : MonoBehaviour
{
    void Start()
    {
        string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        int count = 0;
        while (count < 7){
            int randomNum = Random.Range(0, 10);
            Debug.Log(words[randomNum]);
            count++;
        }
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assig1 : MonoBehaviour
{
   void Start()
    {
        int count = 0;   
        while (count < 1)
        {
            int random = Random.Range(1, 21);
            Debug.Log(random);
            if (random == 5){
                continue;
            }
            else if (random == 15){
                break;
            }   
        } 
    }

}

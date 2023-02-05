using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class FoodGetting : MonoBehaviour
{   
    [SerializeField] public FoodNumberMaker FoodNumber;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out SnakeTail snakeTail))
        {
            int sphereNumberText = FoodNumber.FoodNumber;
           
            while (sphereNumberText > 0)
            {
                snakeTail.AddPieceOfTail();
                sphereNumberText--;              
            }
           
            Destroy(gameObject);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class FoodGetting : MonoBehaviour
{
    // [SerializeField] private TextMeshProUGUI _sphereNumberText;
    [SerializeField] public FoodNumberMaker FoodNumber;


    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out SnakeTail snakeTail))
        {
            int sphereNumberText = FoodNumber.FoodNumber;
            //int sphereNumber = int.Parse(sphereNumberText.text);
           
            while (sphereNumberText > 0)
            {
                snakeTail.AddPieceOfTail();
                sphereNumberText--;
                //sphereNumber--;
            }
            /*snakeTail.AddPieceOfTail();
            EventManager.SentGettingFood();*/
            Destroy(gameObject);
            
        }
            

    }
}
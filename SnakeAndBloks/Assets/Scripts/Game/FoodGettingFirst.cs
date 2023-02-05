using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FoodGettingFirst : MonoBehaviour
{

    // [SerializeField] private TextMeshProUGUI _sphereNumberText;
    [SerializeField] private TextMeshProUGUI _sphereNumberText;


    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out SnakeTail snakeTail))
        {
           
            int sphereNumber = int.Parse(_sphereNumberText.text);

            while (sphereNumber > 0)
            {
                snakeTail.AddPieceOfTail();
                sphereNumber--;
                //sphereNumber--;
            }
            /*snakeTail.AddPieceOfTail();
            EventManager.SentGettingFood();*/
            Destroy(gameObject);

        }


    }
    
}

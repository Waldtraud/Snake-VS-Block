using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GatePassage : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI _gateText;


    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out SnakeTail snakeTail))
        {
            int gateNumber = int.Parse(_gateText.text);
            
            Debug.Log("gateNumber"+ gateNumber);

            if (snakeTail.SnakeLength > gateNumber)
            {
                Debug.Log("snakeTail" + snakeTail.SnakeLength);
                snakeTail.RemoveSphere(gateNumber);
            }
            else
            {
                
               EventManager.SentLossPlayer();     
            }                

        }
    }
}

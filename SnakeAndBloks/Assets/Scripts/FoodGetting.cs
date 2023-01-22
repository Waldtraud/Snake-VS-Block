using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class FoodGetting : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _sphereNumberText;

    [SerializeField] private Transform _snakeHead;

    private void Start()
    {

        //TextMeshPro SphereNumberText = GetComponentInChildren<TextMeshPro>();
       
           
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out SnakeTail snakeTail))
        {

           // Debug.Log(_sphereNumberText.text);
            EventManager.SentGettingFood();
            
        }
            

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using TMPro;
using System;
public class GameController : MonoBehaviour
{
    public SnakeTail _snakeTail;
    //private FoodGetting _foodGetting;
    [SerializeField] TextMeshProUGUI _sphereText;

    private void Start()
    {
        EventManager.OnGettingFood.AddListener(GetFood);
        



    }
    
    public void GetFood()
    {
        
        int sphereNumber = int.Parse(_sphereText.text);
        //Debug.Log(sphereNumber);
        while (sphereNumber > 0)
        {
            _snakeTail.AddSphere();
            sphereNumber--;
        }
          
    }
    


   
}

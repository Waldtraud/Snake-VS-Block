using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //public SnakeTail SnakeTail;
    //[SerializeField] public GatePassage GatePassage;
    //private FoodGetting _foodGetting;
    [SerializeField]  Controls Controls;
   


    private void Start()
    {
       // EventManager.OnLossPlayer.AddListener(ShowScreen);
        Controls.enabled = false;
    }

    public void Play()
    {
        Controls.enabled = true;
    }

    
    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

   // public void 


}

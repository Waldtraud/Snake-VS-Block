using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScreen : Screen
{
    [SerializeField] private GameObject _levelCompleted; 


    private void Start()
    {
        //EventManager.OnLossPlayer.AddListener(ShowScreen);

    }
    public override void ShowScreen()
    {
        _levelCompleted.SetActive(true);
        
    }

    public override void HideScreen()
    {
        _levelCompleted.SetActive(false);
        
    }
}

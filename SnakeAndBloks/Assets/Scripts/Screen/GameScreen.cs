using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameScreen : Screen
{
    [SerializeField] private GameObject _slider;   

    
    public override void ShowScreen()
    {
        _slider.SetActive(true);

    } 

    public override void HideScreen()
    {
        _slider.SetActive(false);

    }
}

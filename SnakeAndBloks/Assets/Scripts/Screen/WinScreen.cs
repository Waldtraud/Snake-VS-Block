using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScreen : Screen
{
    [SerializeField] private GameObject _levelCompletedText;
    [SerializeField] private CameraFollow _cameraFollow;
    [SerializeField] private GameObject _resultText;
    [SerializeField] private GameObject _buttonNextLevel;


    private void Start()
    {
        EventManager.OnGettingFinish.AddListener(ShowScreen);

    }
    public override void ShowScreen()
    {
        _levelCompletedText.SetActive(true);      
        _resultText.SetActive(true);
        _buttonNextLevel.SetActive(true); 
        
        _cameraFollow.enabled = false;

    }

    public override void HideScreen()
    {
        _levelCompletedText.SetActive(false);
        _resultText.SetActive(false);
        _buttonNextLevel.SetActive(false);

    }
}

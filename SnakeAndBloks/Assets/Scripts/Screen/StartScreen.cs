using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreen : Screen
{
    //[SerializeField] private GameObject _tapToContinueText;
    [SerializeField] private GameObject _level;
    [SerializeField] private GameObject _button;
    [SerializeField] private GameObject _gameName;
    [SerializeField] private GameObject _panel;


    public override void ShowScreen()
    {
        //_tapToContinueText.SetActive(true);
        _button.SetActive(true);
        _level.SetActive(true);
        _panel.SetActive(true);
        _gameName.SetActive(true);
    }

    public override void HideScreen()
    {
        _button.SetActive(false);
        _level.SetActive(false);
        _panel.SetActive(false);
        _gameName.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LossScreen : Screen
{
    [SerializeField] private GameObject _tapToContinueText;
    [SerializeField] private GameObject _result;
    [SerializeField] private GameObject _button;
    [SerializeField] private GameObject _panel;
    [SerializeField] Controls Controls;
    

    private void Start()
    {
        EventManager.OnLossPlayer.AddListener(ShowScreen);

    }
    public override void ShowScreen()
    {
        _tapToContinueText.SetActive(true);
        _result.SetActive(true);
        _panel.SetActive(true);
        _button.SetActive(true);
        Controls.enabled = false;
        
    }

    public override void HideScreen()
    {
        _tapToContinueText.SetActive(false);
        _result.SetActive(false);
        _panel.SetActive(false);
        Controls.enabled = true;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelTouch : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    [SerializeField] GameController _gameController;

    private void OnMouseDown()
    {
        _gameController.ReloadLevel();
    }
}

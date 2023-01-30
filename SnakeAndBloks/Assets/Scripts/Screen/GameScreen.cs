using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameScreen : Screen
{
    [SerializeField] private GameObject _score;
    [SerializeField] private TextMeshProUGUI _levelText;

    private void Start()
    {
        _levelText.text = "Level"+SceneManager.GetActiveScene().name;
    }
    public override void ShowScreen()
    {
        _score.SetActive(true);

    } 

    public override void HideScreen()
    {
        _score.SetActive(false);

    }
}

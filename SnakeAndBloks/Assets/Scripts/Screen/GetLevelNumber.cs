using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GetLevelNumber : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI _levelText;

    private void Start()
    {
        _levelText.text = SceneManager.GetActiveScene().name;

    }
   
}

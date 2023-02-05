using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetResult : MonoBehaviour
{
    public SnakeTail SnakeTail;
    [SerializeField]  private TextMeshProUGUI _resultText;

    private void Start()
    {
        EventManager.OnLossPlayer.AddListener(PrintResult);

    }
    public void PrintResult()
    {
        int snakeLengh = SnakeTail.GetSnakeLength();
        _resultText.text = "Your Score " + snakeLengh.ToString();
    }
}

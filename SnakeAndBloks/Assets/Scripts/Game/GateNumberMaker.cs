using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Random = System.Random;
 
public class GateNumberMaker : MonoBehaviour
{
    public int GateNumber { get; private set; }

    [SerializeField] private TextMeshProUGUI _gateNumberText;
    [SerializeField] private int _minGateNumber;
    [SerializeField] private int _maxGateNumber;
    private void Start()
    {
        Random random = new Random();
        GateNumber = random.Next(_minGateNumber, _maxGateNumber + 1);
        _gateNumberText.text = GateNumber.ToString();
    }

    
}

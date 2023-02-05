using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowSlider : MonoBehaviour
{
    [SerializeField] public SnakeTail _snakeTail;
    [SerializeField] public Transform Finish;
    [SerializeField] public Slider Slider;
    [SerializeField] public float AccptebleFinishDistance;

    private float _startPosition;
    private float _finishPosition;

    public void Start()
    {
        _startPosition = _snakeTail.transform.position.z;
        _finishPosition = Finish.transform.position.z;
    }

    public void Update()
    {
             
        float result = Mathf.InverseLerp(_startPosition, _finishPosition, _snakeTail.transform.position.z);
        Slider.value = result;
    }
}

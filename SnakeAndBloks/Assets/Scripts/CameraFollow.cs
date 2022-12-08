using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _snakeHead;
    [SerializeField] private Vector3 _cameraPosition;

    [SerializeField] private float _speed;

    private void Start()
    {
        _cameraPosition = _snakeHead.InverseTransformPoint(transform.position);
    }

    void Update()
    {  
        var currentPosition = _snakeHead.TransformPoint(_cameraPosition);
        transform.position = Vector3.Lerp(transform.position, currentPosition, _speed * Time.deltaTime);

        var currentRotation = Quaternion.LookRotation(_snakeHead.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, currentRotation, -_speed * Time.deltaTime);
           
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private void Start()
    {
        transform.parent = null;
    }

    void LateUpdate()
    {
    
        transform.position = _target.position;

    }
}

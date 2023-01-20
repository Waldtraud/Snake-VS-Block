using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour
{
    [SerializeField]  float _speed;
    [SerializeField]  Transform _ground;

    
    void Update()
    {
        _ground.transform.position += new Vector3( 0, 0,-_speed* Time.deltaTime);
    }
}

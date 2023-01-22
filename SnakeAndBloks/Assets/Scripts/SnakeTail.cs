using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeTail : MonoBehaviour
{
    [SerializeField]  Transform _snakeHead;
    [SerializeField]   Transform _snakeBody;
    [SerializeField]  float _shpereDiameter;
    [SerializeField] float _distance;

    private List<Transform> _snakeTail = new List<Transform>();
    private List<Vector3> _positions = new List<Vector3>();
   
    void Start()
    {
       _positions.Add(_snakeHead.position);
    
    }

    
   void Update()
    {
        float distance = (_snakeHead.position - _positions[0]).magnitude;

        if (distance>_shpereDiameter)
        {
            Vector3 direction = (_snakeHead.position - _positions[0]).normalized;
            _positions.Insert(0, _positions[0] + direction * _shpereDiameter);
            _positions.RemoveAt(_positions.Count - 1);
            distance-=_shpereDiameter;
        }

        for (int i=0; i<_snakeTail.Count-1; i++)
        {
            _snakeTail[i].position = Vector3.Lerp(_positions[i + 1], _positions[i], distance/ _shpereDiameter);
        }
    }

    public void AddSphere()
    {       
        
            Transform bodyPrefab = Instantiate(_snakeBody, _positions[_positions.Count-1 ], Quaternion.identity, transform);
            _snakeTail.Add(bodyPrefab);
            _positions.Add(bodyPrefab.position);

    }

    public void RemoveSphere()
    {
        Destroy(_snakeTail[0].gameObject);
        _snakeTail.RemoveAt(0);
        _positions.RemoveAt(1);
    }

}

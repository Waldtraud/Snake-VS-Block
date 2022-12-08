using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeTail : MonoBehaviour
{
    [SerializeField] private Transform _snakeHeat;
    [SerializeField] private Transform _snakeBody;
    [SerializeField] private float _shpereDiameter;

    private List<Transform> _snakeSphere = new List<Transform>();
    private List<Vector3> _positions = new List<Vector3>();
    void Start()
    {
        _positions.Add(_snakeHeat.position);
       AddSphere();
        AddSphere();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = ((Vector3)_snakeHeat.position - _positions[0]).magnitude;

        if (distance>_shpereDiameter)
        {
            Vector3 direction = ((Vector3)_snakeHeat.position - _positions[0]).normalized;
            _positions.Insert(0, _positions[0]+direction* _shpereDiameter);
            _positions.RemoveAt(_positions.Count - 1);
            distance-=_shpereDiameter;
        }

        for (int i=0; i<_snakeSphere.Count-1; i++)
        {
            _snakeSphere[i].position = Vector3.Lerp(_positions[i + 1], _positions[i], distance / _shpereDiameter);
        }
    }

    public void AddSphere()
    {
        Transform bodySphere = Instantiate(_snakeBody, _positions[_positions.Count - 1], Quaternion.identity, transform);
        _snakeSphere.Add(bodySphere);
        _positions.Add(bodySphere.position);
    }

    public void RemoveSphere()
    {
        Destroy(_snakeSphere[0].gameObject);
        _snakeSphere.RemoveAt(0);
        _positions.RemoveAt(1);
    }

}

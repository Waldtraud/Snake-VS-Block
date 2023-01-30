using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpown : MonoBehaviour
{
    [SerializeField] GameObject _food;
    [SerializeField] MeshCollider _ground;
    [SerializeField] Collider[] _otherColliders;
    [SerializeField] float _yPos;
    [SerializeField] int _foodNumberOnLevel;

    private float _xPos, _zPos;

    private Vector3 _spownPos;
    private Vector3 _sizeCol = new Vector3(1f,1f,1f) ;
    private Vector3 _center= new Vector3(0f, 0.5f, 0f);

    private bool _check;

    
    void Start()
    {
        GetSpartPOsition(_foodNumberOnLevel);
    }
    private void GetSpartPOsition(int foodNumber)
    {
        for (int i = 0; i < _foodNumberOnLevel - 1; i++)
        {
            _xPos = Random.Range(_ground.transform.position.x - Random.Range(0, _ground.bounds.extents.x), _ground.transform.position.x
                + Random.Range(0, _ground.bounds.extents.x));
            _zPos = Random.Range(_ground.transform.position.z - Random.Range(0, _ground.bounds.extents.z), _ground.transform.position.z
                + Random.Range(0, _ground.bounds.extents.z));

            _spownPos = new Vector3(_xPos, _yPos, _zPos);

            _check = CheckSpownPoints(_spownPos);
            if (_check)
            {
                GameObject.Instantiate(_food, _spownPos, Quaternion.identity);
            }
        }
    }

    private bool CheckSpownPoints(Vector3 spownPos)
     {
        _otherColliders = Physics.OverlapBox(_spownPos, _sizeCol);
        if (_otherColliders.Length>0)
            return false;
        else
            return true;
    }
}

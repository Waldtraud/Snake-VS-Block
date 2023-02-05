using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _ground;
    public GameController GameController;

    private float _groundBoundXMax;
    private float _groundBoundXMin;

    private float _oldPOsitionX;
    private float _ealerY;

    private void Start()
    {
        var groundRenderer = _ground.GetComponent<Renderer>();
        if (groundRenderer == null)
            return;
        var bounds = groundRenderer.bounds;
        _groundBoundXMax = bounds.max.x;
        _groundBoundXMin =  bounds.min.x;        

    }


    void Update()
    {
        if (GameController.IsPlaying)
        {
            Vector3 newPosition = transform.position + transform.forward * _speed * Time.deltaTime;
            newPosition.x = Mathf.Clamp(newPosition.x, _groundBoundXMin, _groundBoundXMax);
            transform.position = newPosition;

            if (Input.GetMouseButtonDown(0))
            {
                _oldPOsitionX = Input.mousePosition.x;

            }

            if (Input.GetMouseButton(0))
            {


                float deltaZ = Input.mousePosition.x - _oldPOsitionX;
                _oldPOsitionX = Input.mousePosition.x;

                _ealerY += deltaZ;
                _ealerY = Mathf.Clamp(_ealerY, -70, 70);

                transform.eulerAngles = new Vector3(0, _ealerY, 0);
            }
        }
       
    }
  


    }

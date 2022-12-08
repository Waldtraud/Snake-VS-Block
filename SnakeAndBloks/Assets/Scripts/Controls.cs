using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    [SerializeField] private Transform _snakeHead;    
    [SerializeField] private float _rotationSpeed; 
   // private Vector3 _currentRotation;
    //private Vector3 _currentPosition;
    private Vector3 _moveForvard;
     [SerializeField] private Quaternion _rotationLeft;
    [SerializeField] private Quaternion _rotationRight;
    //private float _minimumVert ;
    //[SerializeField] private float _maximumVert;
    private Quaternion _currentPosition;

    [SerializeField] private float _moveSpeed;
    //private float _rotationX;

    private void Start()
    {
        _currentPosition = transform.rotation;
    }

    void Update()
    {
       

        float movement = Input.GetAxis("Horizontal");
        _snakeHead.transform.position += new Vector3(_moveSpeed ,  0, movement* _rotationSpeed) * Time.deltaTime;
       // Vector3 moveForward = _snakeHead.transform.position + new Vector3(movement, 0, 0) * _moveSpeed * Time.deltaTime;
       
           // _snakeHead.transform.Translate(_moveForvard);
        
        

       
   /* if (Input.GetKey(KeyCode.LeftArrow))
        {

            transform.rotation = Quaternion.Lerp(_currentPosition, _rotationLeft, Time.deltaTime * _rotationSpeed);
            
           
            /* _currentRotation = new Vector3(0,0,) Vector3.up * -_rotationSpeed * Time.deltaTime; ;
            transform.rotation = Quaternion.Lerp(transform.rotation, , Time.deltaTime * _rotationSpeed);
            /* _moveDirection = Vector3.up * -turnSpeed * Time.deltaTime;
            GameObject.transform.Rotate(_moveDirection);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Lerp(_currentPosition, _rotationRight, Time.deltaTime * _rotationSpeed);
            return ;
        }*/

        

    }

        private void MoveForward()
        {
        _moveForvard = Vector3.left * _moveSpeed * Time.deltaTime;
        _snakeHead.transform.Translate(_moveForvard);

        }
  


    }

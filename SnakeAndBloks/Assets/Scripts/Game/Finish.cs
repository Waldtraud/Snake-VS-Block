using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{    

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out SnakeTail snakeTail))
        {
            transform.Rotate(90f, 0f, 0f);
            
            EventManager.SentGettingFinish();
        }
    }
}

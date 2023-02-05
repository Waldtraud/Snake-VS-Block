using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    public static UnityEvent OnGettingFood = new UnityEvent();
    public static UnityEvent OnLossPlayer = new UnityEvent();
    public static UnityEvent OnGettingFinish = new UnityEvent();

    public static void SentGettingFood()
    {
        OnGettingFood.Invoke();
    }

    public static void SentLossPlayer()
    {
        OnLossPlayer.Invoke();
    }

    public static void SentGettingFinish()
    {
        OnGettingFinish.Invoke();
    }
}

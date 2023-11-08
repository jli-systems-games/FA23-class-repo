using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class Player : MonoBehaviour
{
    //public UnityEvent onPlayerStep;

    //public delegate void PlayerTakesStep();
    //public static event PlayerTakesStep onPlayerStep;

    public static event Action onPlayerStep;
    public static event Action <int> onPlayerTakeDamage;

    void TakeStep()
    {
        onPlayerStep?.Invoke();
        onPlayerTakeDamage?.Invoke(2);
        //add to score
    }

}

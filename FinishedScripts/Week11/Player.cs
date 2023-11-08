using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class Player : MonoBehaviour
{
    //Say we want several things to happen when the player takes a step:
    //we play a sound & we increase the score

    /*
    public delegate void PlayerTakesStep(); //a delegate is a variable that holds methods
    public static event PlayerTakesStep onPlayerStep; //make an instance that we can use to trigger things
                                                      //by making stuff static, other scripts can now subscribe to it!
                                                      //we can use this without the "event" designation, but then our observers might be able
                                                      //to mess with our delegate!
                                                      //we don't want that! we just want them to listen. saying "event" locks that down
    */

    /*
    public static event Action onPlayerStep;
    public static event Action <int> onPlayerTakeDamage; //actions are a cleaner way of writing this and they also have the benefit of 
                                                         //letting you add required arguements to them
                                                         */

    //finally we can just make an event much like our animation event/ events we are familiar with from buttons
    public UnityEvent onPlayerStep;

    private void Start()
    {
        //we now add functions to our delegate that can be triggered
        //when we call onPlayerSteps, observers will now react
    }

    void TakeStep()
    {
        
        onPlayerStep?.Invoke();
        //onPlayerTakeDamage?.Invoke(2);
    }
}

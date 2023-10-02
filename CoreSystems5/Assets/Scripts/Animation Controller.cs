using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public bool isRed = true;

    private Animator anim;

    public GameObject scriptHolder;
    public PointsManager pointsScript;

    void Start()
    {
        pointsScript = scriptHolder.GetComponent<PointsManager>();
        anim = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            pointsScript.PointsIncreaseBy25();
            if(isRed)
            {
                anim.Play("Base Layer.Flip Paddle", 0, 0f);
                isRed = !isRed;
            }
            else
            {
                anim.Play("Base Layer.Flip Paddle Again", 0, 0f);
                isRed = !isRed;
            }
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(isRed)
                {
                    anim.Play("Base Layer.Tip Paddle", 0, 0f);
                }
            else
                {
                    anim.Play("Base Layer.Tip Paddle 2", 0, 0f);
                }
        }
    }
}
   

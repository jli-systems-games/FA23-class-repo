using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class easyModeScript : MonoBehaviour
{
    public SpriteRenderer SR1;
    public SpriteRenderer SR2;
    public SpriteRenderer SR3;
    public SpriteRenderer SR4;
    public SpriteRenderer SR5;
    public SpriteRenderer SR6;
    public SpriteRenderer SR7;
    public SpriteRenderer SR8;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            SR1.color = new Color (0.7019608f, 0.2745098f, 0.3098039f, 1);
        }
        if(Input.GetKeyUp(KeyCode.A))
        {
            SR1.color = new Color (1, 0.5411765f, 0.5802702f, 1);
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            SR2.color = new Color (0.8301887f, 0.4500594f, 0.3171948f, 1);
        }
        if(Input.GetKeyUp(KeyCode.S))
        {
            SR2.color = new Color (1, 0.6741204f, 0.5415094f, 1);
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            SR3.color = new Color (0.8301887f, 0.6348692f, 0.3093628f, 1);
        }
        if(Input.GetKeyUp(KeyCode.D))
        {
            SR3.color = new Color (1, 0.8492612f, 0.5411765f, 1);
        }

        if(Input.GetKeyDown(KeyCode.F))
        {
            SR4.color = new Color (0.4460687f, 0.754717f, 0.3097188f, 1);
        }
        if(Input.GetKeyUp(KeyCode.F))
        {
            SR4.color = new Color (0.7273757f, 1, 0.5411765f, 1);
        }

        if(Input.GetKeyDown(KeyCode.J))
        {
            SR5.color = new Color (0.3595586f, 0.754717f, 0.6702814f, 1);
        }
        if(Input.GetKeyUp(KeyCode.J))
        {
            SR5.color = new Color (0.5411765f, 1, 0.9017653f, 1);
        }

        if(Input.GetKeyDown(KeyCode.K))
        {
            SR6.color = new Color (0.3158597f, 0.549187f, 0.735849f, 1);
        }
        if(Input.GetKeyUp(KeyCode.K))
        {
            SR6.color = new Color (0.5411765f, 0.7975149f, 1, 1);
        }

        if(Input.GetKeyDown(KeyCode.L))
        {
            SR7.color = new Color (0.4485317f, 0.3208438f, 0.6603774f, 1);
        }
        if(Input.GetKeyUp(KeyCode.L))
        {
            SR7.color = new Color (0.7130384f, 0.5411765f, 1, 1);
        }

        if(Input.GetKeyDown(KeyCode.Semicolon))
        {
            SR8.color = new Color (0.6603774f, 0.3021538f, 0.6389452f, 1);
        }
        if(Input.GetKeyUp(KeyCode.Semicolon))
        {
            SR8.color = new Color (1, 0.5411765f, 0.9720379f, 1);
        }
    }
}

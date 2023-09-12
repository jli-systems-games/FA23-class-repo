using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppingCube : MonoBehaviour
{
    public GameObject spawner;
    public GameObject instructions;
    public float speed;
    public bool movingLeft;
    public GameObject block;
    public CamMovement camMovement;

    public PointsObject pointsObject;

    void Start()
    {
        movingLeft = true;
        CreateCube();
    }
    void Update()
    {
        instructions = GameObject.Find("Instructions");

        if (movingLeft == true)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            if (transform.position.x <= -12) movingLeft = false;
        }
        else
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            if (transform.position.x >= 12) movingLeft = true;
        }
        
       
        if (Input.GetKeyDown("space"))
        {
            if (instructions!=null)
            {
                instructions.SetActive(false);
                return;
            }
            
            GameObject block= spawner.transform.GetChild(0).gameObject;
            var fall= block.GetComponent<Rigidbody>();
            block.transform.SetParent(null);
            fall.useGravity = true;
            block.GetComponent<BoxCollider>().enabled = true;

        }
    }

    //Creates and sets up the next cube
    public void CreateCube()
    {
        GameObject newCube = Instantiate(block, transform.position, Quaternion.identity); //create cube
        newCube.transform.parent = transform; //set the parent
        newCube.GetComponent<Cube>().pointsObject = pointsObject; //tell the cube to have the correct points object
        newCube.GetComponent<Cube>().droppingCube = this; //set the spawner
        newCube.GetComponent<Cube>().camControl = camMovement; //set cam control
        newCube.GetComponent<BoxCollider>().enabled = false;
        newCube.tag = "Untagged";

    }
}

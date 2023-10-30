using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallOff : MonoBehaviour
{
    public SceneController sceneScript;
    // Start is called before the first frame update
    void Start()
    {
        sceneScript = this.GetComponent<SceneController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider collider)
    {
        sceneScript.toEnd();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraSwitcher : MonoBehaviour
{
    public List<CinemachineVirtualCamera> virtualCameras;
    private int currentCameraIndex = 0;
    private bool lastCameraReached = false;


    public GameObject eventTrigger;


    private void Start()
    {

        if (virtualCameras.Count == 0)
        {
            Debug.LogError("No virtual cams");
            enabled = false;
            return;
        }


        for (int i = 1; i < virtualCameras.Count; i++)
        {
            virtualCameras[i].gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !lastCameraReached)
        {

            virtualCameras[currentCameraIndex].gameObject.SetActive(false);

           
            currentCameraIndex++;


            if (currentCameraIndex >= virtualCameras.Count)
            {

                if (eventTrigger != null)
                {
                    eventTrigger.SetActive(true); 
                }
                else
                {
                    Debug.LogWarning("EventTrigger is not assigned.");
                }

                
                lastCameraReached = true;
               
            }
            else
            {
                virtualCameras[currentCameraIndex].gameObject.SetActive(true);
            }
        }
    }
}

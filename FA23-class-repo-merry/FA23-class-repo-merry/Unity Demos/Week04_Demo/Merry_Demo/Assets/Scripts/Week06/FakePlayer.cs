using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakePlayer : MonoBehaviour
{
    public DialogueController testNPC;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            testNPC.Talk();
        }
    }
}

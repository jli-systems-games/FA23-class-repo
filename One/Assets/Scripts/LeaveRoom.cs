using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class LeaveRoom : MonoBehaviour
{
    public DialogueRunner script;
    public Movement moveScript;
    public Rigidbody2D player;
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Interaction.clueCount<7)
        {
            script.StartDialogue("NotYet");
        }
        else
        {
            moveScript.enabled = false;
            player.velocity = new Vector2(0, 0);
            script.StartDialogue("Exit");
        }
    }

    [YarnCommand("resume")]
    public void MoveAgain()
    {
        moveScript.enabled = true;
    }
    [YarnCommand("leave")]
    public void Leave()
    {
        SceneManager.LoadScene("Choice");
    }
}

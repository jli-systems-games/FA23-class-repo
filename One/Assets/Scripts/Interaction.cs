using UnityEngine;
using Yarn.Unity;

public class Interaction : MonoBehaviour
{
    public GameObject text;
    public DialogueRunner script;
    public bool talk = false;
    public bool gotRed = false;
    public bool gotBlue = false;
    public bool gotYellow = false;
    public bool gotGreen = false;
    public bool gotOrange = false;
    public bool gotPurple = false;
    public bool gotPink = false;
    public TalkCount talkCount;

    public static int clueCount = 0;

    public void Start()
    {
        text.SetActive(false);
        clueCount = 0;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (talk)
            {
                text.SetActive(false);
                if (gameObject.name == "RedInteraction")
                {
                    Debug.Log("Red Dialogue");
                    script.StartDialogue("Red");
                    if (!gotRed)
                    {
                        clueCount++;
                        talkCount.CountUpdate(clueCount);
                        gotRed = true;
                    }
                    talk = false;
                }
                if (gameObject.name == "BlueInteraction")
                {
                    Debug.Log("Blue Dialogue");
                    script.StartDialogue("Blue");
                    if (!gotBlue)
                    {
                        clueCount++;
                        talkCount.CountUpdate(clueCount);
                        gotBlue = true;
                    }
                    talk = false;
                }
                if (gameObject.name == "YellowInteraction")
                {
                    Debug.Log("Yellow Dialogue");
                    script.StartDialogue("Yellow");
                    if (!gotYellow)
                    {
                        clueCount++;
                        talkCount.CountUpdate(clueCount);
                        gotYellow = true;
                    }
                    talk = false;
                }
                if (gameObject.name == "GreenInteraction")
                {
                    Debug.Log("Green Dialogue");
                    script.StartDialogue("Green");
                    if (!gotGreen)
                    {
                        clueCount++;
                        talkCount.CountUpdate(clueCount);
                        gotGreen = true;
                    }
                    talk = false;
                }
                if (gameObject.name == "OrangeInteraction")
                {
                    Debug.Log("Orange Dialogue");
                    script.StartDialogue("Orange");
                    if (!gotOrange)
                    {
                        clueCount++;
                        talkCount.CountUpdate(clueCount);
                        gotOrange = true;
                    }
                    talk = false;
                }
                if (gameObject.name == "PurpleInteraction")
                {
                    Debug.Log("Purple Dialogue");
                    script.StartDialogue("Purple");
                    if (!gotPurple)
                    {
                        clueCount++;
                        talkCount.CountUpdate(clueCount);
                        gotPurple = true;
                    }
                    talk = false;
                }
                if (gameObject.name == "PinkInteraction")
                {
                    Debug.Log("Pink Dialogue");
                    script.StartDialogue("Pink");
                    if (!gotPink)
                    {
                        clueCount++;
                        talkCount.CountUpdate(clueCount);
                        gotPink = true;
                    }
                    talk = false;
                }


            }
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            text.SetActive(true);
            talk = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (text != null)
            {
                text.SetActive(false);

            }
            talk = false;
        }
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class Choice : MonoBehaviour
{
    public bool pick = false;
    public GameObject text;
    /*public GameObject redText;
    public GameObject blueText;
    public GameObject yellowText;
    public GameObject greenText;
    public GameObject orangeText;
    public GameObject purpleText;
    public GameObject pinkText;
    public GameObject current;*/

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (pick)
            {
                
                if (gameObject.name == "GreenInteraction")
                {
                    Debug.Log("Win");
                    SceneManager.LoadScene("Win");
                }
                else
                {
                    Debug.Log("Lose");
                    SceneManager.LoadScene("Lose");
                }
            }
        }
    }
        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {

                pick = true;
                text.SetActive(true);
                /*if (gameObject.name == "RedInteraction")
                {
                    redText.SetActive(true);
                    current = redText;
                }
                if (gameObject.name == "BlueInteraction")
                {
                    blueText.SetActive(true);
                    current = blueText;
                }
                if (gameObject.name == "YellowInteraction")
                {
                    yellowText.SetActive(true);
                    current = yellowText;
                }
                if (gameObject.name == "GreenInteraction")
                {
                    greenText.SetActive(true);
                    current = greenText;
                }
                if (gameObject.name == "OrangeInteraction")
                {
                    orangeText.SetActive(true);
                    current = orangeText;
                }
                if (gameObject.name == "PurpleInteraction")
                {
                    purpleText.SetActive(true);
                    current = purpleText;
                }
                if (gameObject.name == "PinkInteraction")
                {
                    pinkText.SetActive(true);
                    current = pinkText;
                }*/

            }
        }

        public void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                text.SetActive(false);
                //current.SetActive(false);
            }
        }
    }

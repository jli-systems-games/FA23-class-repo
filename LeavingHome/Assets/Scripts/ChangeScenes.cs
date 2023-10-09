using UnityEngine;

public class ChangeScenes : MonoBehaviour
{
    public static int sc;
    public GameObject ghost;
    public GameObject window;
    public GameObject cat;
    public GameObject dog;
    public GameObject rod;
    public GameObject hammer;
    public GameObject rat;
    public Animator animator;

    private void Start()
    {
        sc = 1;

        ghost = GameObject.Find("Ghost");
        window = GameObject.Find("Window");
        cat = GameObject.Find("Cat");
        dog = GameObject.Find("Dog");
        rod = GameObject.Find("FishingRod");
        hammer = GameObject.Find("Hammer");
        rat = GameObject.Find("Rat");

        SceneChange();


    }

    public void RightScene()
    {
        if (sc == 2)
        {
            sc = 0;
        }
        else
        {
            sc++;
        }
        Debug.Log(sc);
        animator.SetTrigger("FadeOut");

        animator.SetTrigger("FadeIn");
    }

    public void LeftScene()
    {
        if (sc == 0)
        {
            sc = 2;
        }
        else
        {
            sc--;
        }
        Debug.Log(sc);
        animator.SetTrigger("FadeOut");

        animator.SetTrigger("FadeIn");
    }


    public void SceneChange()
    {

        switch (sc)
        {
            case 2:
                ghost.SetActive(false);
                window.SetActive(true);
                cat.SetActive(true);
                dog.SetActive(false);

                if (ClickSprites.rodPickup == true)
                {
                    rod.SetActive(false);
                }
                else
                {
                    rod.SetActive(true);
                }
                hammer.SetActive(false);
                rat.SetActive(false);
                break;
            case 1:
                ghost.SetActive(true);
                window.SetActive(false);
                cat.SetActive(false);
                dog.SetActive(false);
                rod.SetActive(false);
                hammer.SetActive(false);
                rat.SetActive(false);

                break;
            case 0:
                ghost.SetActive(false);
                window.SetActive(false);
                cat.SetActive(false);
                if (ClickSprites.dogPickup == true)
                {
                    dog.SetActive(false);
                }
                else
                {
                    dog.SetActive(true);
                }
                rod.SetActive(false);
                if (ClickSprites.hammerPickup == true)
                {
                    hammer.SetActive(false);
                }
                else
                {
                    hammer.SetActive(true);
                }
                if (ClickSprites.ratPickup == true)
                {
                    rat.SetActive(false);
                }
                else
                {
                    rat.SetActive(true);
                }

                break;

            default:

                break;
        }


    }
}

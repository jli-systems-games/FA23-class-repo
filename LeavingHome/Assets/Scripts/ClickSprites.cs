using UnityEngine;
using Yarn.Unity;

public class ClickSprites : MonoBehaviour
{

    public DialogueRunner script;
    public Inventory inventory;
    public GameObject dog;
    public GameObject rod;
    public GameObject hammer;
    public GameObject rat;
    public GameObject crack;
    public GameObject broken;
    public static bool rodPickup;
    public static bool hammerPickup;
    public static bool dogPickup;
    public static bool ratPickup;
    public bool fished;

    public void Start()
    {
        rodPickup=false;
        hammerPickup = false;
        dogPickup = false;
        ratPickup = true;
        fished = false;

    }
    public void GhostClick()
    {
        if (InventorySelect.selected == "")
        {
            script.StartDialogue("GhostNone");

        }
        if (InventorySelect.selected == "DogIcon_0")
        {
            script.StartDialogue("GhostDog");
        }
        if (InventorySelect.selected == "RodIcon_0" || InventorySelect.selected == "HammerIcon_0")
        {
            script.StartDialogue("GhostHammerRod");
        }
        if (InventorySelect.selected == "RatIcon_0")
        {
            script.StartDialogue("GhostRat");
        }
        Debug.Log("Ghost");
    }
    public void WindowClick()
    {
        Debug.Log("Window");
        if (crack.activeSelf)
        {
            if (InventorySelect.selected == "HammerIcon_0")
            {
                script.StartDialogue("HammerWindow");
                crack.SetActive(false);
                broken.SetActive(true);
            }
            if (InventorySelect.selected == "RodIcon_0")
            {
                script.StartDialogue("CrackedWindowRod");
            }
        } else if (broken.activeSelf)
        {
            if (InventorySelect.selected == "RodIcon_0")
            {
                if (!fished)
                {
                    script.StartDialogue("BrokenWindowRod");
                    fished = true;
                }
               
                
            }
        }
    }
    public void CatClick()
    {
        Debug.Log("Cat");

        if (InventorySelect.selected == "")
        {
            script.StartDialogue("CatNone");
        }
        else if (InventorySelect.selected == "RatIcon_0")
        {
            script.StartDialogue("CatRat");
        }
        else
        {
            script.StartDialogue("CatItem");
        }

    }
    public void DogClick()
    {
        inventory.Pickup("DogIcon_0");
        script.StartDialogue("DogPickup");
        dog.SetActive(false);
        dogPickup = true;

        Debug.Log("Dog");
    }
    public void FishingRodClick()
    {
        inventory.Pickup("RodIcon_0");
        script.StartDialogue("RodPickup");
        rod.SetActive(false);
        rodPickup = true;

        Debug.Log("Rod");
    }
    public void HammerClick()
    {
        inventory.Pickup("HammerIcon_0");
        script.StartDialogue("HammerPickup");
        hammer.SetActive(false);
        hammerPickup = true;

        Debug.Log("Hammer");
    }
    public void RatClick()
    {
        inventory.Pickup("RatIcon_0");
        script.StartDialogue("RatPickup");
        rat.SetActive(false);
        ratPickup = true;

        Debug.Log("Rat");

    }

    [YarnCommand("show_rat")]
    public void RatVisible()
    {
        ratPickup = false;
        rat.SetActive(true);
    }

}

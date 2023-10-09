using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static List<Sprite> inventory = new List<Sprite>();
    public GameObject[] inventoryBoxes;
    public Sprite[] sprites;
  

    public void InventoryUpdate()
    {
        for (int i = 0; i < inventory.Count; i++)
        {
            var spriteRenderer=inventoryBoxes[i].GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = inventory[i];
        }

    }

    public void Pickup(string item)
    {
        foreach (Sprite sprite in sprites)
        {
            if (sprite.name == item)
            {
                if (!inventory.Contains(sprite))
                {
                    inventory.Add(sprite);
                    InventoryUpdate();
                    break;
                }
                
            }
        }
    }
    public void UseItem(string item)
    {
        foreach (Sprite sprite in inventory)
        {
            if (sprite.name == item)
            {
                inventory.Remove(sprite);
                InventoryUpdate();
                break;
            }
        }
    }



}

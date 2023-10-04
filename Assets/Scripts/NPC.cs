using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Player;

[CreateAssetMenu(fileName = "NPC", menuName = "ScriptableObjects/NPC/NPC", order = 2)]
public class NPC : ScriptableObject
{
    public string npcName = " ";
    public Weapon npcWeapon = null;
    public DialogueObject[] dialogue;

    public Dictionary<Stat, int> npcStats = new Dictionary<Stat, int>();

    public int npcStrength = 10;
    public int npcDexterity = 10;
    public int npcConstitution = 10;
    public int npcIntelligence = 10;
    public int npcWisdom = 10;
    public int npcCharisma = 10;

    public void Awake()
    {
        npcStats.Add(Stat.Strength, npcStrength);
    }
}

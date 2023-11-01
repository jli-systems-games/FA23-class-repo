using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Player;

[CreateAssetMenu(fileName = "NPC", menuName = "ScriptableObjects/NPC/NPC",
    order = 2)]
public class NPC : ScriptableObject
{
    public int npcID;

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
        npcStats.Add(Stat.Dexterity, npcDexterity);
        npcStats.Add(Stat.Constitution, npcConstitution);
        npcStats.Add(Stat.Intelligence, npcIntelligence);
        npcStats.Add(Stat.Wisdom, npcWisdom);
        npcStats.Add(Stat.Charisma, npcCharisma);
    }

    public void UpdateStats()
    {
        npcStats[Stat.Strength] =  npcStrength;
        npcStats[Stat.Dexterity] = npcDexterity;
        npcStats[Stat.Constitution] = npcConstitution;
        npcStats[Stat.Intelligence] = npcIntelligence;
        npcStats[Stat.Wisdom] = npcWisdom;
        npcStats[Stat.Charisma] = npcCharisma;
    }
}

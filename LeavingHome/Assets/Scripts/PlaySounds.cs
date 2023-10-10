using UnityEngine;
using Yarn.Unity;

public class PlaySounds : MonoBehaviour
{
    public AudioSource monster;
    public AudioSource cat;
    public AudioSource rat;
    public AudioSource pickup;
    public AudioSource shatter;
    // Start is called before the first frame update

    [YarnCommand("monster_noise")]
    public void MonsterNoise()
    {
        monster.Play();
    }

    [YarnCommand("cat_noise")]
    public void CatNoise()
    {
        cat.Play();
    }

    [YarnCommand("rat_noise")]
    public void RatNoise()
    {
        rat.Play();
    }
    [YarnCommand("pickup_noise")]
    public void PickupNoise()
    {
        pickup.Play();
    }
    [YarnCommand("shatter_noise")]
    public void ShatterNoise()
    {
        shatter.Play();
    }
}

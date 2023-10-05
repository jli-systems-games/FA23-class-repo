using UnityEngine;

public class Bounce : MonoBehaviour
{
    public Rigidbody rb;

    public float lowForce;
    public float midForce;
    public float highForce;
    public AudioSource jumpSound;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Low")
        {
            rb.AddForce(Vector2.up *lowForce, ForceMode.Impulse);
            jumpSound.Play();
        }
        else if (collision.gameObject.tag == "Mid")
        {
            rb.AddForce(Vector2.up * midForce, ForceMode.Impulse);
            jumpSound.Play();
        }
        else if (collision.gameObject.tag == "High")
        {
            rb.AddForce(Vector2.up * highForce, ForceMode.Impulse);
            jumpSound.Play();
        }
    }
}

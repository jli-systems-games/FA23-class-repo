using EZCameraShake;
using UnityEngine;


public class BoxingTriggerPlayer2 : MonoBehaviour
{
    public float punchForce = 10f;
    private bool canPunch = false;

    public AudioSource ballHit;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player2"))
        {
            canPunch = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player2"))
        {
            canPunch = false;
        }
    }

    private void Update()
    {
        if (canPunch && Input.GetKeyDown(KeyCode.M))
        {
            // Check if Player 2 is pressing the "M" key and can punch
            ApplyPunchForce();
        }
    }

    private void ApplyPunchForce()
    {
        // Get the opponent's rigidbody (assuming it has one)
        Rigidbody opponentRigidbody = GetComponentInParent<Rigidbody>();

        if (opponentRigidbody != null)
        {
            // Calculate the punch direction (forward in this case)
            Vector3 punchDirection = transform.forward;

            // Apply the burst of impulse to the opponent
            opponentRigidbody.AddForce(punchDirection * punchForce, ForceMode.Impulse);

            ballHit.Play();
        }
    }
}

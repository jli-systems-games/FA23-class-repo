using UnityEngine;


public class BoxingTrigger : MonoBehaviour
{
    public float punchForce = 10f;
    private bool canPunch = false;

    public AudioSource ballHit;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canPunch = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canPunch = false;
        }
    }

    private void Update()
    {
        if (canPunch && Input.GetKeyDown(KeyCode.E))
        {
            // Check if the player is pressing the "E" key and can punch
            ApplyPunchForce();
        }
    }

    private void ApplyPunchForce()
    {
        // Get the opponent's rigidbody (assuming it has one)
        Rigidbody opponentRigidbody = GetComponentInParent<Collider>().attachedRigidbody;

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

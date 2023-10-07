using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damageAmount = 10;

    public bool isShooting;

    public ParticleSystem muzzleFlash;

    public AudioSource shot;

    public GameObject muzzle;

    public float maxRaycastDistance = 100f;

    private void Start()
    {
        isShooting = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && isShooting == false)
        {
            Shoot();
            shot.Play();
            StartCoroutine(shootCooldown());
            isShooting = true;
        }
    }

    IEnumerator shootCooldown()
    {
        yield return new WaitForSeconds(3f);
        isShooting = false;
    }

    void Shoot()
    {
        muzzleFlash.Play();
        RaycastHit hit;
        if (Physics.Raycast(muzzle.transform.position, muzzle.transform.forward, out hit, maxRaycastDistance))
        {
            Debug.Log(hit.transform.name);
            //Debug.DrawLine(raycast.origin, hit.point, Color.red, 0.1f);

            Target target = hit.transform.GetComponent<Target>();

            if (target != null)
            {
                target.TakeDamage((int)damageAmount); 
            }
        }
    }
}

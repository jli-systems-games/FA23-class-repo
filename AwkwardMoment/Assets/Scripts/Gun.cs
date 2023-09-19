using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public bool isShooting;

    public Camera fpsCam;

    public ParticleSystem muzzleFlash;

    public AudioSource shot;

    public AudioSource groan;

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
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();

            if (target!=null)
            {
                groan.Play();
                target.TakeDamage(damage);
            }
        }
    }
}

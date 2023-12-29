using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PCollider : MonoBehaviour
{
    public Canvas cone;
    public Canvas car;
    public Canvas ape;
    public Canvas bolt;
    public Canvas win;
    public GameObject player;

    private void Start()
    {
        // Deactivate the canvas at the start
        cone.gameObject.SetActive(false);
        car.gameObject.SetActive(false);
        ape.gameObject.SetActive(false);
        bolt.gameObject.SetActive(false);
        win.gameObject.SetActive(false);
        player.SetActive(true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Cone"))
        {
            // Activate the canvas when a collision with a "Cone" tagged object occurs
            cone.gameObject.SetActive(true);
            player.SetActive(false);
        }
        if (collision.gameObject.CompareTag("Car"))
        {
            // Activate the canvas when a collision with a "Cone" tagged object occurs
            car.gameObject.SetActive(true);
            player.SetActive(false);
        }
        if (collision.gameObject.CompareTag("Ape"))
        {
            // Activate the canvas when a collision with a "Cone" tagged object occurs
            ape.gameObject.SetActive(true);
            player.SetActive(false);
        }
        if (collision.gameObject.CompareTag("Bolt"))
        {
            // Activate the canvas when a collision with a "Cone" tagged object occurs
            bolt.gameObject.SetActive(true);
            player.SetActive(false);
        }
        if (collision.gameObject.CompareTag("Win"))
        {
            // Activate the canvas when a collision with a "Cone" tagged object occurs
            win.gameObject.SetActive(true);
            player.SetActive(false);
        }
    }

}

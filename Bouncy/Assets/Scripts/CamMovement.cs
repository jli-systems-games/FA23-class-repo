using UnityEngine;

public class CamMovement : MonoBehaviour
{
   
    public float speed = 0f;
    //public GameObject cam;
    public GameObject player;


    void Update()
    {
        Vector3 position = transform.position;
        position.y = player.transform.position.y+1.5f;
        transform.position = position;
    }

    /* private void OnTriggerEnter2D(Collider2D collision)
     {
         Debug.Log(collision.gameObject.name);

         if (collision.gameObject.name == "CamMoveUp1")
         {

             Debug.Log("CamMove");

             Vector3 finalPosition = new Vector3 (cam.transform.position.x, 7.8f ,cam.transform.position.z);

             Vector3 lerpPosition = Vector3.Lerp(cam.transform.position, finalPosition, speed);

             cam.transform.position = lerpPosition;

         }
         if (collision.gameObject.name == "CamMoveUp2")
         {

             Debug.Log("CamMove");

             Vector3 finalPosition = new Vector3(cam.transform.position.x, 15.8f, cam.transform.position.z);

             Vector3 lerpPosition = Vector3.Lerp(cam.transform.position, finalPosition, speed);

             cam.transform.position = lerpPosition;

         }
         if (collision.gameObject.name == "CamMoveUp3")
         {

             Debug.Log("CamMove");

             Vector3 finalPosition = new Vector3(cam.transform.position.x, 23.6f, cam.transform.position.z);

             Vector3 lerpPosition = Vector3.Lerp(cam.transform.position, finalPosition, speed);

             cam.transform.position = lerpPosition;

         }
         if (collision.gameObject.name == "CamMoveUp4")
         {


                 Debug.Log("CamMove");

                 Vector3 finalPosition = new Vector3(cam.transform.position.x, 30.6f, cam.transform.position.z);

                 Vector3 lerpPosition = Vector3.Lerp(cam.transform.position, finalPosition, speed);

                 cam.transform.position = lerpPosition;


         }
        /*if (collision.gameObject.name == "CamMoveDown1")
         {
             moving = true;
             Debug.Log("CamMove");
             if (moving == true)
             {
                 cam.transform.Translate(Vector3.down * speed * Time.deltaTime);
                 if (cam.transform.position.y >= 0)
                 {
                     moving = false;
                 }

             }

         }

         if (collision.gameObject.name == "CamMoveDown2")
         {
             moving = true;
             Debug.Log("CamMove");
             if (moving == true)
             {
                 cam.transform.Translate(Vector3.down * speed * Time.deltaTime);
                 if (cam.transform.position.y >= 7.8)
                 {
                     moving = false;
                 }

             }

         }
         if (collision.gameObject.name == "CamMoveDown3")
         {
             moving = true;
             Debug.Log("CamMove");
             if (moving == true)
             {
                 cam.transform.Translate(Vector3.down * speed * Time.deltaTime);
                 if (cam.transform.position.y >= 15.8)
                 {
                     moving = false;
                 }

             }

         }
         if (collision.gameObject.name == "CamMoveDown4")
         {
             moving = true;
             Debug.Log("CamMove");
             if (moving == true)
             {
                 cam.transform.Translate(Vector3.down * speed * Time.deltaTime);
                 if (cam.transform.position.y >= 23.6)
                 {
                     moving = false;
                 }

             }

         }
     }*/
}

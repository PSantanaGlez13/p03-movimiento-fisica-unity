using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio12 : MonoBehaviour
{
    public float speed = 1f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() 
    {
        if (Input.GetKey("space")) {
            GameObject sphere = GameObject.FindWithTag("esfera");
            //Quaternion quat = transform.rotation;
            //quat.SetLookRotation(sphere.transform.position);
            //GetComponent<Rigidbody>().MoveRotation(quat);
            Vector3 direction = (sphere.transform.position - transform.position).normalized;
            // Sin cambios de altura.
            direction.y = 0;
            GetComponent<Rigidbody>().MovePosition(transform.position + direction);
            return;
        }
        float horizontal_movement = Input.GetAxis("Horizontal") * speed;
        float vertical_movement = Input.GetAxis("Vertical") * speed;
        Vector3 force = new Vector3(horizontal_movement, 0, vertical_movement);
        GetComponent<Rigidbody>().AddForce(force);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio10Esfera : MonoBehaviour
{
    public float speed = 1f;
    public string vertical = "";
    public string horizontal = "";
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
        float horizontal_movement = Input.GetAxis(horizontal) * speed;
        float vertical_movement = Input.GetAxis(vertical) * speed;
        Vector3 force = new Vector3(horizontal_movement, vertical_movement, 0f);
        GetComponent<Rigidbody>().AddForce(force);
    }
}

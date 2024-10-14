using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8 : MonoBehaviour
{
    public float speed = 1f;
    public bool debug = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (debug) {
            Debug.DrawRay(gameObject.transform.position, gameObject.transform.forward * 100);
        }
        bool forward = Input.GetKey("up");
        if (forward) {
           // Coordenadas del mundo
           // transform.Translate(gameObject.transform.forward * speed * Time.deltaTime, Space.World);
           // Relativo al sistema de referencia del objeto.
           transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        float rotation = Input.GetAxis("Horizontal");
        // Coordenadas del mundo
        //transform.Rotate(0f, rotation * speed * 5 * Time.deltaTime, 0f, Space.World);
        // Relativo al sistema de referencia del objeto.
        transform.Rotate(0f, rotation * speed * 5 * Time.deltaTime, 0f);
    }
}

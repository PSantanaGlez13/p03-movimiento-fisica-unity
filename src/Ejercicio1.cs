using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    public float velocidad = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movimiento_horizontal = Input.GetAxis("Horizontal");
        if (movimiento_horizontal > 0) {
            Debug.Log("Presionada flecha derecha. Eje Horizontal: " + movimiento_horizontal * velocidad);
        } else if (movimiento_horizontal < 0) {
            Debug.Log("Presionada flecha izquierda. Eje Horizontal: " + movimiento_horizontal * velocidad);
        }

        float movimiento_vertical = Input.GetAxis("Vertical");
        if (movimiento_vertical > 0) {
            Debug.Log("Presionada flecha arriba. Eje Vertical: " + movimiento_vertical * velocidad);
        } else if (movimiento_vertical < 0) {
            Debug.Log("Presionada flecha abajo. Eje Vertical: " + movimiento_vertical * velocidad);
        }

        //movimiento_horizontal *= velocidad; // * Time.deltaTime;
        //movimiento_vertical *= velocidad; // * Time.deltaTime;
        // transform.Translate(movimiento_horizontal, 0, movimiento_vertical);
        //Debug.Log("Velocidad Eje horizontal (X): " + movimiento_horizontal +  "  Velocidad Eje vertical (Z): " + movimiento_vertical);
    }
}

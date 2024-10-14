using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(1, 0, 0);
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            transform.Translate(moveDirection * speed);
        }
    }
}

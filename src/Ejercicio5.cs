using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5 : MonoBehaviour
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
        float horizontal_movement = Input.GetAxis(horizontal);
        float vertical_movement = Input.GetAxis(vertical);

        transform.Translate(horizontal_movement * speed * Time.deltaTime, vertical_movement * speed * Time.deltaTime, 0);
    }
}

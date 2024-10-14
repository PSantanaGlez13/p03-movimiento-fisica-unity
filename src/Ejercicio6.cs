using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6 : MonoBehaviour
{
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        GameObject sphere = GameObject.FindWithTag("esfera");
        Vector3 movement = sphere.transform.position - gameObject.transform.position;
        movement = movement.normalized;
        gameObject.transform.Translate(movement * speed * Time.deltaTime);
    }
}

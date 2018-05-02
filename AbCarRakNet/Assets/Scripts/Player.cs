using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float turnRate;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Move Forward
        if (Input.GetKey(KeyCode.W))
            transform.Translate(speed * Vector3.forward * Time.deltaTime);

        // Move Back
        if (Input.GetKey(KeyCode.S))
            transform.Translate(speed * -Vector3.forward * Time.deltaTime);

        // Turn Right
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(0, turnRate, 0, Space.Self);

        // Turm Left
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(0, -turnRate, 0, Space.Self);

    }
}

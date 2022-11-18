using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    [SerializeField] private float rotspeed = 50.0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Rotate(rotspeed * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.S))
            transform.Rotate(-rotspeed * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(0, rotspeed*  Time.deltaTime, 0);

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(0, -rotspeed * Time.deltaTime, 0);
    }
}

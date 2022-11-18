using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FigRotate : MonoBehaviour
{
    private float rotspeed = 50.0f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Rotate(Vector3.right * rotspeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            transform.Rotate(-1 * Vector3.right * rotspeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up * rotspeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(-1 * Vector3.up * rotspeed * Time.deltaTime);
    }
}

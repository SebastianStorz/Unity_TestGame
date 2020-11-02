using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    void Update()
    {
        float movement = Input.GetAxis("Vertical") * Time.deltaTime * 10;
        float rotation = Input.GetAxis("Horizontal") * Time.deltaTime * 200;

        transform.Translate(0, 0, movement);
        transform.Rotate(0, rotation, 0);
    }
}

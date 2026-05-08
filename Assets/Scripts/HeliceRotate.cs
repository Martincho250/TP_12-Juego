using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliceRotate : MonoBehaviour
{
    public float velocidadRotacion = 200f;

    void Update()
    {
        transform.Rotate(velocidadRotacion * Time.deltaTime, 0, 0);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsControler : MonoBehaviour
{
    void Update()
    {
        transform.position -= transform.up * CarsCreator.velocity * Time.deltaTime;//se mueve hacia atras si se da la condicional anterior

        if (!CarsCreator.inGame)
            Destroy(gameObject);

        if (transform.position.y < -13)
            Destroy(gameObject);

    }
}

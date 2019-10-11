using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControler : MonoBehaviour
{
    public Vector2 posXRight = new Vector2();
    public Vector2 posXLeft = new Vector2();

    void Start()
    {
        posXRight.x = transform.position.x + 2.5f;
        posXLeft.x = transform.position.x - 2.5f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<CarsControler>() != null)
        {
            CarsCreator.inGame = false;
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))//se obtiene la tecla para ir hacia la derecha y se crea una condicional para moverse
        {
            transform.position = new Vector2(posXRight.x,transform.position.y);//se mueve hacia la derecha si se da la condicional anterior
        }
        if (Input.GetKey(KeyCode.A))//se obtiene la tecla para ir hacia la izquierda y se crea una condicional para moverse
        {
            transform.position = new Vector2(posXLeft.x,transform.position.y);//se mueve hacia la izquierda si se da la condicional anterior   
        }
    }
}

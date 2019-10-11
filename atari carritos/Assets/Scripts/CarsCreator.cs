using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsCreator : MonoBehaviour
{
    public GameObject kar;
    public Vector2[] pos = new Vector2[2];
    public static bool inGame = true;
    public static float velocity;

    void Awake()
    {
        pos[0] = new Vector2(2.6f,18f);
        pos[1] = new Vector2(-2.3f,18f);
        velocity = 7;
    }
    void Start()
    {
        StartCoroutine("Sacacarros");
    }

    IEnumerator Sacacarros()
    {
        while (inGame)
        {
            Instantiate(kar, pos[Random.Range(0,2)], Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }

    void Update()
    {
        if (velocity < 40)
        velocity += Time.deltaTime;
    }
}

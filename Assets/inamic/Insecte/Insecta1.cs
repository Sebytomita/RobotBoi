using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Insecta1 : MonoBehaviour
{
    public MovementInsecta1 m;
    public float marire = 0.03f;
    public GameObject purice;
    float urmatoarea_marire = 5f;
    Vector2 scale;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (urmatoarea_marire <= 0)
        {
            scale = transform.localScale;
            scale.x += marire;
            scale.y += marire;
            transform.localScale = scale;
            urmatoarea_marire = 5f;
            Instantiate(purice, transform.position, Quaternion.identity);
            m.hp+=10f;
            m.dmg+=7;
        }
        else
            urmatoarea_marire -=Time.deltaTime;
    }
}
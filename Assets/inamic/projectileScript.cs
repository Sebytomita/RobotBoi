using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileScript : MonoBehaviour
{
    private UnityEngine.Object explosionRef;
    void Start()
    {
        explosionRef = Resources.Load("Explosion2");
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "RobotBoi")
        {
            PlayerMovement p = col.gameObject.GetComponent<PlayerMovement>();
            if (p != null)
                p.Damage(50);
        }
        if (col.gameObject.tag != "Monstru1" && col.gameObject.tag != "Monstru2" && col.gameObject.tag !="Monstru3")
        {
            GameObject explosion = (GameObject)Instantiate(explosionRef);
            explosion.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Destroy(gameObject);
        }
    }
}
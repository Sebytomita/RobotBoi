using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private UnityEngine.Object bulletExplosionRef;

    void Start()
    {
        bulletExplosionRef = Resources.Load("BulletExplosion");
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        EnemyMovement e = collision.gameObject.GetComponent<EnemyMovement>();
        if (e != null)
        {
            e.TakeDamage(10);
        }
        GameObject bulletExplosion = (GameObject)Instantiate(bulletExplosionRef);
        bulletExplosion.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Destroy(gameObject);
        MovementShooting e2 = collision.gameObject.GetComponent<MovementShooting>();
        if (e2 != null)
        {
            e2.TakeDamage(10);
        }
        Instantiate(bulletExplosionRef);
        bulletExplosion.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Destroy(gameObject);
        MovementInsecte mi = collision.gameObject.GetComponent<MovementInsecte>();
        if (mi != null)
        {
            mi.TakeDamage(10);
        }
        Instantiate(bulletExplosionRef);
        bulletExplosion.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Destroy(gameObject);
        MovementInsecta1 mi2 = collision.gameObject.GetComponent<MovementInsecta1>();
        if (mi2 != null)
        {
            mi2.TakeDamage(10);
        }
        Instantiate(bulletExplosionRef);
        bulletExplosion.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Destroy(gameObject);
    }
}
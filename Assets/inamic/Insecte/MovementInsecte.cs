using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class MovementInsecte : MonoBehaviour
{
    public GameObject XPPrefab;
    public GameObject coinPrefab;
    GameObject player;
    private Rigidbody2D rb;
    private Vector2 EnemyMove;
    public float EnemySpeed = 2f;
    public int hp = 90;
    public int dmg = 7;
    Vector2 poz;


    private UnityEngine.Object explosionRef;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("RobotBoi");
        rb = GetComponent<Rigidbody2D>();
        explosionRef = Resources.Load("Explosion");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle - 90f;
        direction.Normalize();
        EnemyMove = direction;
        if (hp <= 0)
            Destroy(this.gameObject);
    }

    void FixedUpdate()
    {
        MoveCharacter(EnemyMove);
    }

    void MoveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + direction * EnemySpeed * Time.deltaTime);
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            poz = transform.position;
            GameObject explosion = (GameObject)Instantiate(explosionRef);
            explosion.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Destroy(gameObject);
            Instantiate(XPPrefab, poz, Quaternion.identity);
            poz.x += 1f;
            Instantiate(XPPrefab, poz, Quaternion.identity);
            player.GetComponent<PlayerMovement>().currentXP += 0.7f;
            poz.x -= 0.5f;
            Instantiate(coinPrefab, poz, Quaternion.identity);
            CoinsScript.coins += 2;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        PlayerMovement p = col.gameObject.GetComponent<PlayerMovement>();
        if (p != null)
            p.Damage(dmg);
    }
}
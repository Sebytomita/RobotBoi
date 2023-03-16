using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class XPFollow : MonoBehaviour
{
    GameObject player;
    private Rigidbody2D rb;
    private Vector2 XPMove;
    public float XPSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("RobotBoi");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        XPMove = direction;
        if (transform.position.x >= player.transform.position.x - 0.16f && transform.position.x <= player.transform.position.x + 0.16f
            && transform.position.y >= player.transform.position.y - 0.15f && transform.position.y <= player.transform.position.y + 0.15f)
        {
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        MoveCharacter(XPMove);
    }

    void MoveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + direction * XPSpeed * Time.deltaTime);
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public XPBar XPbar;
    public float playerSpeed = 5f;
    public Rigidbody2D rb;
    public Camera cam;
    Vector2 movement;
    Vector2 mousePos;
    public static int health = 50;
    public static int maxHealth = 50;
    public float maxXP = 10f;
    public float currentXP = 0f;

    public float InvincibilityLength = 1f;
    private float InvincibilityCounter;

    public HealthBar healthBar;

    private UnityEngine.Object explosionRef;

    Renderer rend;
    Color c;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        c = rend.material.color;
        explosionRef = Resources.Load("Explosion");
        health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        XPbar.SetMaxXP(maxXP);
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        if (InvincibilityCounter > 0)
        {
            InvincibilityCounter -= Time.deltaTime;
        }
        else
        {
            c.a = 1f;
            rend.material.color = c;
        }
        XPbar.SetXP(currentXP);
        if (currentXP >= maxXP)
        {
            currentXP = currentXP - maxXP;
            maxXP += 150f;
            XPbar.SetMaxXP(maxXP);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * playerSpeed * Time.fixedDeltaTime);

        Vector2 direction = mousePos - rb.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

    public void Damage(int damage)
    {
        if (InvincibilityCounter <= 0)
        {
            health -= damage;
            if (health <= 0)
            {
                GameObject explosion = (GameObject)Instantiate(explosionRef);
                explosion.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                Destroy(gameObject);
            }
            healthBar.SetHealth(health);

            InvincibilityCounter = InvincibilityLength;
            c.a = 0.8f;
            rend.material.color = c;
        }
    }
}
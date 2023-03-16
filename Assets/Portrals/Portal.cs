using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    private Transform destination;
    public bool isOrange;
    private float ok=0;
    public float distance=0.3f;
    public Animator transitionAnim;
    public string sceneName;
    void Start()
    {
        if (isOrange == true)
        {
            destination = GameObject.FindGameObjectWithTag("BluePortal").GetComponent<Transform>();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (Vector2.Distance(transform.position, other.transform.position) > 0.3f)
        {
            other.transform.position = new Vector2(destination.position.x, destination.position.y);
            Destroy(GameObject.FindGameObjectWithTag("BluePortal"));
            ok=1;
        }
          
    }
}

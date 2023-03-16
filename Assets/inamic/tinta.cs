using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tinta : MonoBehaviour
{
    float wait = 3f;
    // Start is called before the first frame update
    void Start()
    {
        wait = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        wait -= Time.deltaTime;
        if (wait <= 0.1f)
            Destroy(gameObject);
    }
}
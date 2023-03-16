using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextHealthBar : MonoBehaviour
{
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerMovement.health < 0)
            PlayerMovement.health = 0;
        text.text = (PlayerMovement.health).ToString();
        text.text += '/';
        text.text += (PlayerMovement.maxHealth).ToString();
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextXPBar : MonoBehaviour
{
    public PlayerMovement player;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = (player.currentXP).ToString();
        UnityEngine.Debug.Log(player.currentXP);
        text.text += '/';
        text.text += (player.maxXP).ToString();
    }
}
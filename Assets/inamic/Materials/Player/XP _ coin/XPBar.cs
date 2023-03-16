using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxXP(float XP)
    {
        slider.maxValue = XP;
        slider.value = 0;
    }

    public void SetXP(float XP)
    {
        slider.value = XP;
    }
}
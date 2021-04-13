using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoController : MonoBehaviour
{
    public Slider slider;


    public void setMaxAmmo(int ammo)
    {

        slider.maxValue = ammo;
        slider.value = ammo;

    }

    public void setAmmo(int ammo)
    {
        slider.value = ammo;

    }
}

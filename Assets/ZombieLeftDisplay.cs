using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZombieLeftDisplay : MonoBehaviour
{
    public Text timeText;
    public int zombiesLeft;
    public int zombiesStart = 15;
    private int currentZombiesRemaining;

    void Start()
    {

        zombiesLeft = zombiesStart;
        timeText.text = string.Format("",zombiesLeft);



        
    }

    // Update is called once per frame
    void Update()
    {
        zombiesLeft = GameObject.FindGameObjectsWithTag("Zombie").Length;
        timeText.text = string.Format("{0}/15", zombiesLeft);





    }
}

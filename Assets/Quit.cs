using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Quit : MonoBehaviour
{
    
    public Text timeRemaining;






    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q)) {
            StartCoroutine(Back());
        }
    }




    IEnumerator Back()
    {
        
        timeRemaining.text = string.Format("Quitting");
        yield return new WaitForSeconds(5);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene(0);

    }
}

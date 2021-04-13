using UnityEngine;
using UnityEngine.SceneManagement;

public class AgentAttacking : MonoBehaviour 
{
    private Scene Scene;

    void OnTriggerEnter(Collider other)
	{


        Scene = SceneManager.GetActiveScene();

        if (Scene.buildIndex == 1)
        {
            if (other.tag == "Player")
            {
                other.GetComponent<PlayerHealth>().TakeDamage();


            }
        }
        else
        {
            other.GetComponent<Player2Health>().TakeDamage();

        }
    }
}

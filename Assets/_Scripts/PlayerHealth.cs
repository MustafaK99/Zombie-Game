using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour 
{

    public int healthLevel;
	public AudioClip painSound;
	new private AudioSource audio;
    public HealthBarController healthBar;

	void Awake ()
	{
		audio = GetComponent<AudioSource>();
        healthLevel = 100;
        healthBar.setMaxHealth(healthLevel);
	}

    void Update()
    {
        if(healthLevel <=0)
  
        {
            SceneManager.LoadScene(1);

        }

    }

	public void TakeDamage ()
	{
        
        healthLevel = healthLevel - 10;
		audio.PlayOneShot(painSound);
        healthBar.setHealth(healthLevel);
       
	}


   
}

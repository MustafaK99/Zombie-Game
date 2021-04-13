using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    public ParticleSystem muzzleFlash;
    public int MaxAmmo = 20;
    public AmmoController ammoController;
    private int currentAmmo;
    public float fireRate = 15f;
    public float reloadTime = 1f;
    private bool isReloading = false;
    public AudioClip gunSound;
    new private AudioSource audio;




    private float nextTimeOfFire = 0f;
    

    void Start()
    {
        audio = GetComponent<AudioSource>();
        currentAmmo = MaxAmmo;
        ammoController.setMaxAmmo(currentAmmo);


    }

    void Update()
    {

        if (isReloading)
        {
            return;
        }
        if(currentAmmo <= 0)
        {

            StartCoroutine(reload());
            return;
           
        }
        if (Input.GetMouseButton(0) && Time.time >= nextTimeOfFire)
        {
            nextTimeOfFire = Time.time + 1f / fireRate;
            shoot();
        }
        
    }

    IEnumerator reload()
    {
        isReloading = true;
        yield return new WaitForSeconds(reloadTime);
        currentAmmo = MaxAmmo;
        ammoController.setAmmo(currentAmmo);
        isReloading = false;
    }
    void shoot() {



         
            muzzleFlash.Play();
            audio.PlayOneShot(gunSound);
            PhysicsRaycasts();
            currentAmmo = currentAmmo - 1;
             ammoController.setAmmo(currentAmmo);
         

        


    }
   
    void PhysicsRaycasts()
    {
        Vector3 centreOfScreen = new Vector3(Screen.width * 0.5f, Screen.height * 0.5f, 0);
        float distanceToFireRay = 20;
        Ray centreOfScreenRay =
        Camera.main.ScreenPointToRay(centreOfScreen);
        RaycastHit hit;
        if (Physics.Raycast(centreOfScreenRay, out hit, distanceToFireRay))
        {
              
            if (Input.GetMouseButtonDown(0) && hit.transform.tag == "Zombie")
            {
                
                hit.transform.GetComponent<ZombieHealth>().TakeDamage(30);
              
            }
        }
    }





}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform player;
    public Transform respawnPoint;
    // Start is called before the first frame update
    
    public void playerRespawn()
  
    {
     
        player.transform.position = respawnPoint.transform.position;
    }



}

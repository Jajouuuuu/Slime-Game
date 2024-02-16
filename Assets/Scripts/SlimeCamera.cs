using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeCamera : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(7, 7, 2.5f);
  
    void Start()
    {
     
    }

    void Update()
    {
       
    }

    void SwitchCamera()
    {
     
    }

    void LateUpdate()
    {
        // Offset the camera behind the player by adding to the player's position 
        transform.position = player.transform.position + offset;
    }
}

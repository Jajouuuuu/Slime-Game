using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PNJController : MonoBehaviour
{

    public float detectionRadius = 10.0f;
    public float detectionAngle = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LookForPlayer();
    }

    private PlayerController LookForPlayer()
    {
        if (PlayerController.Instance == null)
        {
            return null;
        }

        Vector3 enemyPosition = transform.position;
        Vector3 toPlayer = PlayerController.Instance.transform.position - enemyPosition;
        toPlayer.y = 0;

        if (toPlayer.magnitude <= detectionRadius)
        {
            if (Vector3.Dot(toPlayer.normalized, transform.forward) >
                Mathf.Cos(detectionAngle * 0.5f * Mathf.Deg2Rad))
            {

                Debug.Log("Player has been detected!");
                return PlayerController.Instance;
            }
        }


        return null;
    }

}

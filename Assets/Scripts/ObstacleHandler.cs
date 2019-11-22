using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleHandler : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider) 
    {
        if (collider.GetComponent<BirdController>() != null)
            GameController.instance.AddScore();
    }
}

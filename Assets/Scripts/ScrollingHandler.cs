using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingHandler : MonoBehaviour
{
    private Rigidbody2D _rigidBody;

    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _rigidBody.velocity = Vector2.right * GameController.instance.scrollSpeed;
    }

    void Update()
    {
        if (GameController.instance.gameOver == true) {
            _rigidBody.velocity = Vector2.zero;
        }
    }
}

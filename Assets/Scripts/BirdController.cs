using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float jumpForce = 300.0f;

    private bool _isDead = false;
    private Rigidbody2D _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!_isDead)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                Debug.Log("Jump");
                _rigidbody.velocity = Vector2.zero;
                _rigidbody.AddForce(Vector2.up * jumpForce);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _isDead = true;
    }
}

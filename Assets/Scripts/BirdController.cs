using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float jumpForce = 300.0f;

    private bool _isDead = false;
    private Rigidbody2D _rigidbody;
    private Animator _animator;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
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
                _animator.SetTrigger("Flap");
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _rigidbody.velocity = Vector2.zero;
        _isDead = true;
        _animator.SetTrigger("Dead");
        GameController.instance.BirdDead();
    }
}

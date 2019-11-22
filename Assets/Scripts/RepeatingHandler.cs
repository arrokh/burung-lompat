using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingHandler : MonoBehaviour
{
    private BoxCollider2D _boxCollider;
    private float _groundHorizontalLength;

    void Start()
    {
        _boxCollider = GetComponent<BoxCollider2D>();
        _groundHorizontalLength = _boxCollider.size.x;
    }

    void Update()
    {
        if (transform.position.x < -_groundHorizontalLength)
        {
            RepositionObject();
        }
    }

    private void RepositionObject()
    {
        Vector2 groundOffset = Vector2.right * _groundHorizontalLength * 2.0f;
        transform.position = (Vector2)transform.position + groundOffset;
    }
}

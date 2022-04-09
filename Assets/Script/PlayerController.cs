using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb;
    private SpriteRenderer _spriteRenderer;

    private float _moveInput;
    private float _moveSpeed = 20;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        GameEvents.gameOver.AddListener(GameOver);
    }

    private void Update()
    {

        if(Application.platform == RuntimePlatform.Android)
        {
            _moveInput = Input.acceleration.x;
        }

        if(Input.acceleration.x < 1)
        {
            _spriteRenderer.flipX = true;
        }

        if (Input.acceleration.x > 1)
        {
            _spriteRenderer.flipX = false;
        }

        _rb.velocity = new Vector2(Input.acceleration.x * _moveSpeed, _rb.velocity.y);
        /* if (_moveInput > 0)
         {
             _spriteRenderer.flipX = false;
         }
         if (_moveInput < 0)
         {
             _spriteRenderer.flipX = true;
         }*/
    }
    private void FixedUpdate()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            _moveInput = Input.acceleration.x;
        }

        if (Input.acceleration.x < 0)
        {
            _spriteRenderer.flipX = true;
        }

        if (Input.acceleration.x > 0)
        {
            _spriteRenderer.flipX = false;
        }

        _rb.velocity = new Vector2(Input.acceleration.x * _moveSpeed, _rb.velocity.y);
        //_moveInput = Input.GetAxis("Horizontal");
        //_rb.velocity = new Vector2(Input.acceleration.x * _moveSpeed, _rb.velocity.y);
    }
    void GameOver()
    {
        GetComponent<BoxCollider2D>().enabled = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    int moveSpeed = 4;
    private Rigidbody2D _rigidbody2D;
    private SpriteRenderer _spriterenderer;
    public GameObject balaza;
    public AudioSource _audio;
    float horizontalInput;
    float verticalInput;
    void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _spriterenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        dispara();
    }
    void FixedUpdate()
    {
        Vector2 movement = new Vector2(horizontalInput, verticalInput) * moveSpeed;
        _rigidbody2D.velocity = movement;

        if (horizontalInput == 1)
        {
            _spriterenderer.flipX = true;
        }
        else if (horizontalInput == -1)
        {
            _spriterenderer.flipX = false;
        }
    }
    void dispara()
    {
        if (Input.GetKeyDown("x") == true)
        {           
            
            Instantiate(balaza, transform.position, balaza.transform.rotation);
            _audio.Play();
        }
    }
}

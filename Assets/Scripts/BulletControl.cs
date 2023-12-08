using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    private float veloY = 1;
    public float speed;
    private Rigidbody2D _rigid2D;
    public GameObject bala;
    private Animator _animator;
    void Awake()
    {
        _rigid2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _rigid2D.velocity = new Vector2(0f, veloY * speed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Enemy"))
        {
            _animator.SetBool("sinoexplotamecuelgo",true);
            Destroy(bala,1.0f);
        }
        else
        {

        }
        if (collision.gameObject.tag == ("Wall"))
        {
            Destroy(this.bala);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public GameObject Enemy;
    public GameControl _gm;
    BoxCollider2D b2d;
    private Rigidbody2D rb;
    private float veloY = 1;
     float speed = -3;

    void Awake()
    {
        b2d = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        rb.velocity = new Vector2(0f, veloY * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Bullet"))
        {
            _gm.puntajeConstante();
            Destroy(Enemy);            
        }
        if(collision.gameObject.tag == ("Wall"))
        {
            Destroy(Enemy);
        }
    }

    public void gameManager(GameControl gm)
    {
        this._gm = gm;
    }
}

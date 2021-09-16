using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocity = 8f;

    private Rigidbody2D rb;
    private Puntaje _game;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _game = FindObjectOfType<Puntaje>();
        Destroy(this.gameObject,3);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(velocity,rb.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="enemigo")
        {
            Destroy(collision.gameObject);
            _game.puntosSuma(10);
            Debug.Log("matar");
        }

        
    }
}

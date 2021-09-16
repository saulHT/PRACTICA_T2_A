using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public GameObject bala;
    public GameObject bala_lef;

    private Puntaje _game;

    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer sr;

    public float jumFor = 30;
    public float velocity = 10;

    private const int Animation_idle = 0;
    private const int Animation_run = 1;
    private const int Animation_saltar = 2;
    private const int Animation_deslizar = 3;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        _game = FindObjectOfType<Puntaje>();
    }

    void Update()
    {
        rb.velocity = new Vector2(0,rb.velocity.y);
        changeAnimation(Animation_idle);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(velocity, rb.velocity.y);
            sr.flipX = false;
          
            changeAnimation(Animation_run);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-velocity, rb.velocity.y);
            sr.flipX = true;
            changeAnimation(Animation_run);
        }
        if (Input.GetKey(KeyCode.X))
        {
            changeAnimation(Animation_deslizar);
        }
        if (Input.GetKeyUp(KeyCode.Space))//apenas plaste&& !estadoSaltando
        {
            rb.AddForce(Vector2.up * jumFor, ForceMode2D.Impulse);
            changeAnimation(Animation_saltar);
            
        }
        if (Input.GetKeyUp(KeyCode.V))
        {
            var bullet = sr.flipX ? bala_lef : bala;

            var position = new Vector2(transform.position.x, transform.position.y);
            var rotacion = bala.transform.rotation;
            Instantiate(bullet, position, rotacion);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       

         if (collision.gameObject.tag == "2")
        {
            Destroy(collision.gameObject);
            _game.puntosMoneda2(1);
            Debug.Log("moneda2");
        }

        else if (collision.gameObject.tag == "3")
        {
            Destroy(collision.gameObject);
            _game.puntosMoneda3(1);
            Debug.Log("moneda3");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "1")
        {

            Destroy(collision.gameObject);
            _game.puntosMoneda1(1);
            Debug.Log("moneda1");
        }


    }
    private void changeAnimation(int animation)
    {
        animator.SetInteger("Estado", animation);
    }
}

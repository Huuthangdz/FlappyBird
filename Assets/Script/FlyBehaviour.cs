using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class FlyBehaviour : MonoBehaviour
{
    [SerializeField] private float rb_velocity = 1.5f ;
    [SerializeField] private float speed_rotation = 10f;


    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
    private void FixedUpdate()
    {
        transform.rotation =  quaternion.Euler(0,0,rb.velocity.y * speed_rotation);
    }
    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, rb_velocity);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Pipe" )
        {
            Console.WriteLine("Dead");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        mainMenu.Ins.GameOver();
    }
}

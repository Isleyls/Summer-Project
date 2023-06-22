using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    private Vector2 movement;
    public int speed = 2;
    public Camera cam;

    public Rigidbody2D rb; 
    public Vector2 aim;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

    }
    
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        aim = cam.ScreenToWorldPoint(Input.mousePosition);

    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
        Vector2 lookDir = aim - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

   
}



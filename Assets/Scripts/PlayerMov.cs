using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public Rigidbody2D playerRB;

    public float forwardForce = 100f;
    public float jumpForce = 5000f;
    public float groundCheckRadius;

    public Transform groundCheck;
    public LayerMask layerGround;

    private bool onGround;
    


    void Start()
    {
        Debug.Log("Game Started...");
        
    }

    void FixedUpdate()
    {
       // playerRB.AddForce(new Vector2(forwardForce * Time.deltaTime, 0));
       playerRB.velocity = new Vector2 (forwardForce * Time.deltaTime, playerRB.velocity.y);
        
    }

    private void Update()
    {
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, layerGround);


        if (Input.anyKey/*Input.GetKey(KeyCode.Space)*/ && onGround)
        {
            playerRB.AddForce(new Vector2(0, jumpForce * Time.deltaTime));
        
        
        }
    }



}

﻿
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 2f;

    private Rigidbody2D playerRigidbody;
    private Animator animator;
    private AudioSource playerAudio;

    private bool isDead = false;


    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
        {
            return;
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            animator.SetTrigger("Run");
            float xInput = Input.GetAxis("Horizontal");

            float xSpeed = xInput * speed;

            Vector2 newVelocity = new Vector2(xSpeed, 0);
            playerRigidbody.velocity = newVelocity;


        }
        else if (Input.GetAxis("Horizontal") == 0)
        {
            animator.SetTrigger("Idle");
            playerRigidbody.velocity = Vector2.zero;
        }



    }

    public void Die()
    {
        animator.SetTrigger("Die");

        playerRigidbody.velocity = Vector2.zero;
        isDead = true;

        GameManager.instance.OnplayerDead();
        
        
    }
}

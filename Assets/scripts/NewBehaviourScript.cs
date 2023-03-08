using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float upForce;
    public Transform groundCheck;
    public LayerMask Ground;
    public float radius;
    



    public Rigidbody2D dinoRb;
    public Animator dinoAnimator;

    void Start()
    {
        dinoRb = GetComponent<Rigidbody2D>();
        dinoAnimator = GetComponent<Animator>();
    }


    void Update()
    {
        bool isGrounded = Physics2D.OverlapCircle(groundCheck.position, radius, Ground);

        dinoAnimator.SetBool("IsGrounded", isGrounded);

        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (isGrounded)
            {
                dinoRb.AddForce(Vector2.up * upForce);
            }


        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            GameManager.Instance.ShowGameOverScreen();
            Time.timeScale = 0f;
        }
    }

    

    


  
}

 












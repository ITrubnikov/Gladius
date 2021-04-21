using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D SelfBody;
    [Range(0, 20)]
    public float JumpForce, MoveSpeed;
    public SpriteRenderer Renderer;
    // Start is called before the first frame update
    void Start()
    {
        SelfBody = GetComponent<Rigidbody2D>();
        Renderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = SelfBody.velocity;
        if (Input.GetKeyDown(KeyCode.W))
        {
            velocity.y = JumpForce;
        }
        if (Input.GetKey(KeyCode.D))
        {
            
            velocity.x = MoveSpeed;
            animator.SetFloat("Speed",MoveSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            velocity.x = -MoveSpeed;
            animator.SetFloat("Speed",MoveSpeed);
        }
        if (Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene("Menu");
        }
        Renderer.flipX = velocity.x < 0;
        
  //      Anim.SetBool("isMove", velocity.x != 0);
      
        SelfBody.velocity = velocity;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    private SpriteRenderer mySpriteRenderer;
    Animator anim;
    float walkSpeed = 13f;
    
    
    //Private void Awake()
    //{
        //mySpriteRenderer = GetComponent<SpriteRenderer>();
    //}
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        {
            float move = Input.GetAxis("Horizontal");
            anim.SetFloat("Speed", move);
        }
    }

    void Movement()
    {
        if(Input.GetKey (KeyCode.W))
        {
            transform.Translate(Vector2.up * walkSpeed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
        }
        if(Input.GetKey (KeyCode.A))
        {
            transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
            if(mySpriteRenderer != null)
            {
                 // flip the sprite
                 mySpriteRenderer.flipX = true;
            }
        }
        if(Input.GetKey (KeyCode.S))
        {
            transform.Translate(Vector2.down * walkSpeed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
        }
        if(Input.GetKey (KeyCode.D))
        {
            transform.Translate(Vector2.right * walkSpeed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
                if(Input.GetKeyDown(KeyCode.D))
                {
                    // flip the sprite
                    mySpriteRenderer.flipX = false;
                }
        }
    }
}

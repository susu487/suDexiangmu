using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer Renderer;
    public float speed = 50f;
    public float jumpspeed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        Renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
    void move()
    {
        float h = Input.GetAxis("Horizontal");
        if (h > 0)
        {
            Renderer.flipX = false;
        }
        else if (h < 0)
        {
            Renderer.flipX = true;
        }
        rb.velocity = new Vector2(h * speed, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpspeed);
        }
    }
}

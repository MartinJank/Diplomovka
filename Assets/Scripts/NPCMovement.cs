using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sprite;
    [SerializeField] private float speed;
    public Vector2 decisionTime = new Vector2(1, 4);
    internal float decisionTimeCount = 0;
    public static List<int> direction = new List<int>();
    private float dirX;

    void Start()
    {
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        decisionTimeCount = Random.Range(decisionTime.x, decisionTime.y);
        direction.Add(-1);
        direction.Add(0);
        direction.Add(1);
        float dirX = direction[Random.Range(0, 3)];
    }

    // Update is called once per frame
    void Update()
    {


        if (decisionTimeCount > 0)
        {
            decisionTimeCount -= Time.deltaTime;
            rb.velocity = new Vector2(dirX * speed, rb.velocity.y);
        }
        else
        {
            decisionTimeCount = Random.Range(decisionTime.x, decisionTime.y);

            // Choose a movement direction, or stay in place

            // Debug.Log(dirX + "  " + speed);
            dirX = direction[Random.Range(0, 3)];


            UpdateAnimation(dirX);
        }
    }


    private void UpdateAnimation(float dirX)
    {
        if (dirX > 0f)
        {
            anim.SetBool("running", true);
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            anim.SetBool("running", true);
            sprite.flipX = true;
        }
        else
        {
            anim.SetBool("running", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D col2d)
    {
        if (col2d.collider.name == "Player" || col2d.collider.tag == "NPC")
        {
            Physics2D.IgnoreCollision(col2d.collider, col2d.otherCollider);
        }
    }
}

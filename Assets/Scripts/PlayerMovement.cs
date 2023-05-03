using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sprite;
    [SerializeField] private float speed;
    [SerializeField] private GameObject uiPanel;
    [SerializeField] private GameObject tiredText;
    private AudioSource walkSound;


    // Start is called before the first frame update
    void Start()
    {
        uiPanel.SetActive(false);
        tiredText.SetActive(false);
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        walkSound = gameObject.GetComponent<AudioSource>();
        InvokeRepeating ("PlaySound", 0.0f, 0.33f); 
    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        
        rb.velocity = new Vector2(dirX * speed, rb.velocity.y);

        UpdateAnimation(dirX);

    }

    void PlaySound () {
        if (Input.GetButton("Horizontal") ){
            walkSound.Play();
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

}

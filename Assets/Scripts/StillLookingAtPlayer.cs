using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StillLookingAtPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    private SpriteRenderer sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (player.position.x > 2f) {
            sprite.flipX = false;
        } else {
            sprite.flipX = true;
        }
    }
}

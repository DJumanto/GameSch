using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightTemplar : MonoBehaviour
{
    [SerializeField] private LayerMask wallLayer;
    [SerializeField] private CrewCard card;
    private Animator animator;
    private BoxCollider2D boxCollider;
    void Awake()
    {
        animator = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }
    
    void Update()
    {
        if(!onWall())
        {
            Move();
        }
    }

    void Move()
    {
        animator.SetBool("Run", true);
        transform.Translate(transform.right * card.moveSpeed * Time.deltaTime);
    }
    
    private bool onWall()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, new Vector2(transform.localScale.x, 0), 0.1f, wallLayer);
        return raycastHit.collider != null;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {  
        if(collision.tag == "EnemyFortress")
        {
            animator.SetBool("Run", false);
        } 
    }    
}

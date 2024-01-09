using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   [SerializeField] private float speed;
   [SerializeField] private float time_life;


    private string enemy; 
    private Vector2 direction;
    private Rigidbody2D rb;
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        Destroy(gameObject,time_life);
    }

    private void FixedUpdate()
    {
        rb.velocity = direction * speed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(enemy))
        {   
            collision.GetComponent<Character>().TakeDamage();
            
        }
        Destroy(gameObject);
        
    }

    public void SetBullet(string enemy,Vector2 direction)
    {
       this.enemy = enemy;
       this.direction = direction;
    }
    
}

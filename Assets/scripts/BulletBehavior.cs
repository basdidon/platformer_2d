using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    // Start is called before the first frame update\
    [SerializeField]
    private float bulletSpeed = 10f;

    [SerializeField]
    private Rigidbody2D bulletRigidbody;

    [SerializeField]
    private int bulletDamage = 1;
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    public void throwDirection(Vector2 direction)
    {
        if(direction == Vector2.right)
        {
            bulletRigidbody.velocity = Vector2.right*bulletSpeed;
            Debug.Log("throwDirection_right");
        }
        else if(direction == Vector2.left)
        {
            bulletRigidbody.velocity = Vector2.left*bulletSpeed;
            Debug.Log("throwDirection_left");

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            Destroy(gameObject, 0.0125f);
            collision.GetComponent<EnemyHealthManager>().damageEnemy(bulletDamage);
        }
        
        if(collision.tag == "Ground")
        {
            Destroy(gameObject, 0.0125f);
        }
    }
}

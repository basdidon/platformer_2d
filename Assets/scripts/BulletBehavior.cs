using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    // Start is called before the first frame update\
    [SerializeField]
    private float bulletSpeed = 5f;

    [SerializeField]
    private Rigidbody2D bulletRigidbody;
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(gameObject.name + " onCollisionEnter2D " + collision.gameObject.name + "  " + collision.gameObject.tag);
        if (collision.gameObject.tag != "Player")
        {
            Destroy(gameObject, 0.025f);
        }
        
        //Destroy(gameObject, 0);
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
}

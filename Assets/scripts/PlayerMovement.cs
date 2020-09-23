using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // serializeField make private variable can edit by unity inspector


    // object variable
    public GameObject bulletPrefab;
    private Rigidbody2D playerRigidbody2d;
    public SpriteRenderer playerSpriteRenderer;
    public Transform aim;

    // facing variable
    private bool facingRight = true;

    // move varible
    [SerializeField]
    private float speed = 8f;
    private float moveHorizontal;

    //jump variable
    public int maxJump = 2;
    public int jumpcount = 0;
    public int jumpForce = 15;

    //fire variable
    private float fireRate = 0.2f;
    private float nextFire = 0.0f;

    void Start()
    {
        playerRigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //jump
        if (Input.GetButtonDown("Jump") && jumpcount < maxJump /*&& nextJump < Time.time*/)
        {
            jump();
        }

        //shoot

        if (Input.GetButtonDown("Fire1") && nextFire < Time.time)
        {
            shoot();
        }
    }

    void FixedUpdate()
    {
        //horizontal move
        moveHorizontal = Input.GetAxis("Horizontal");
        playerRigidbody2d.velocity = new Vector2(moveHorizontal*speed,playerRigidbody2d.velocity.y) ;

        //facing handle
        if (moveHorizontal < 0) {
            transform.localScale = new Vector3(-1, 1, 1);
            facingRight = false;
        } else if (moveHorizontal > 0) {
            transform.localScale = new Vector3(1, 1, 1);
            facingRight = true;
        } else {

        }

        

      
        
        
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //monitor what player hit
        //Debug.Log("onCollisionEnter2D  name : " + collision.gameObject.name + "    tag : " + collision.gameObject.tag);

        //reset jumpcount when player hit the Ground
        if (collision.gameObject.tag == "Ground") {
            jumpcount = 0;
        }
    }

    private void jump()
    {
        playerRigidbody2d.velocity = new Vector2(playerRigidbody2d.velocity.x, jumpForce);
        jumpcount = jumpcount + 1;
        Debug.Log("jump " + jumpcount);
        
    }

    private void shoot(){

        if (facingRight)
        {
            GameObject bulletInstance = (GameObject)Instantiate(bulletPrefab, aim.position, aim.rotation);
            bulletInstance.GetComponent<BulletBehavior>().throwDirection(Vector2.right);
            Debug.Log("shoot_Right");
        }
        else
        {
            GameObject bulletInstance = (GameObject)Instantiate(bulletPrefab, aim.position, aim.rotation);
            bulletInstance.GetComponent<BulletBehavior>().throwDirection(Vector2.left);
            Debug.Log("shoot_Left");
        }
        nextFire = Time.time + fireRate;
    }
}

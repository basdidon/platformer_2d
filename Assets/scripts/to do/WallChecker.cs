using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallChecker : MonoBehaviour
{
    [SerializeField]
    private bool isContactWall = false; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isContactWall = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("sss");
        if(collision.gameObject.tag == "Ground")
        {
            isContactWall = false;
        }
    }

    public bool getIsContactWall()
    {
        return isContactWall;
    } 
}

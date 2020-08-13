using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Transform farBackground;
    public Transform middleBackground;
    public float lastXPos;
    public float amountMove;

    // Start is called before the first frame update
    void Start()
    {
        lastXPos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);

        amountMove = transform.position.x - lastXPos;

        farBackground.position = new Vector3(amountMove,transform.position.y,farBackground.position.z);
        middleBackground.position = new Vector3(amountMove * 0.5f, middleBackground.position.y, middleBackground.position.z);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private static PlayerController playerControllerInstance;

    public int maxHP = 3;
    public int currentHP;
    
    void Awake()
    {
        playerControllerInstance = this;
    }

    void Start()
    {
        currentHP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void dealDamage(int damage)
    {
        currentHP = currentHP - damage;
        if (currentHP <= 0)
        {
            //death
        }
    }
    
}

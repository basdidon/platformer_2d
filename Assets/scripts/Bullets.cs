using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public static Bullets instance;
    public int[] bulletsID;
    public string[] bulletsName;
    public int[] maxBullets;
    public int[] currentBullets;
    public int[] damagePower;
    public string[] description;
    public Sprite[] sprite;
    public GameObject[] bulletPrefab;

    public void Awake()
    {
        instance = this;
    }

    public void Start()
    {
        for (int i = 0; i < bulletsID.Length; i++)
        {
            currentBullets[i] = maxBullets[i];
        }
    }
}

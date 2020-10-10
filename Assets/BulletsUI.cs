using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletsUI : MonoBehaviour
{
    public static BulletsUI instance;

    public Image bulletsImage;
    public Text curruntBulletText, maxBulletText, nameBulletText;

    public Sprite bulletsSprite;

    public int i;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        i = PlayerMovement.instance.currentBulletsID-1;
        //***Update UI***
        //UIsprites
        switch (PlayerMovement.instance.currentBulletsID)
        {
            case 1:
                bulletsImage.sprite = Bullets.instance.sprite[i];
                break;
            case 2:
                bulletsImage.sprite = Bullets.instance.sprite[i];
                break;
            case 3:
                bulletsImage.sprite = Bullets.instance.sprite[i];
                break;
            case 4:
                bulletsImage.sprite = Bullets.instance.sprite[i];
                break;
            case 5:
                bulletsImage.sprite = Bullets.instance.sprite[i];
                break;
        }

        //UITextBullets
        curruntBulletText.text = Bullets.instance.currentBullets[i].ToString();
        maxBulletText.text = Bullets.instance.maxBullets[i].ToString();
        nameBulletText.text = Bullets.instance.bulletsName[i];

    }
}

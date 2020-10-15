using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BulletFactory : MonoBehaviour
{
    [Header("BulletTypes")]
    public GameObject Bullet1;
    public GameObject Bullet2;
    public GameObject Bullet3;

    public BulletManager bulletMgr;

    public GameObject createBullet(BulletType type = BulletType.RANDOM)
    {
        if (type == BulletType.RANDOM)
        {
            var randomBullet = Random.Range(0, 3);
            type = (BulletType) randomBullet;
        }

   
        GameObject tempBullet = null;

        switch (type)
        {
            case BulletType.REGULAR:
                tempBullet = Instantiate(Bullet1);
                tempBullet.GetComponent<BulletController>().damage = 10;
                break;
            case BulletType.FAT:
                tempBullet = Instantiate(Bullet2);
                tempBullet.GetComponent<BulletController>().damage = 15;
                break;
            case BulletType.PULSING:
                tempBullet = Instantiate(Bullet3);
                tempBullet.GetComponent<BulletController>().damage = 20;
                break;
        }
        tempBullet.transform.parent = transform;
        tempBullet.SetActive(false);

        return tempBullet;
    }
}

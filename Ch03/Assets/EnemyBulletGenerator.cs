using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletGenerator : MonoBehaviour
{
    private float time = 0f;
    public GameObject bulletPrefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > 0.5)
        {
            // �������� �̿��ؼ� ������Ʈ ����
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

            //BulletController ���� �Ѿ� �߻� �Լ� ����
            bullet.GetComponent<BulletController>().ShootForEnemy();

            time = 0f;
        }
    }
   
}

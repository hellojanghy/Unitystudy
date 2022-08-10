using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    //������ : ��Ȱ���ϱ� ���� ������Ʈ
    public GameObject bulletPrefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // �������� �̿��ؼ� ������Ʈ ����
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

            //BulletController ���� �Ѿ� �߻� �Լ� ����
            bullet.GetComponent<BulletController>().ShootForPlayer();
        }


    }

    
}

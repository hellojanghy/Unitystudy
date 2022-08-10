using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    
    public float speed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        //bulletRd = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
       // if (Input.GetMouseButtonDown(0))
       // {
       //     Shoot();
       // }
    }

    public void ShootForPlayer()
    {
        GetComponent<Rigidbody>().AddForce(0f, 0f, speed);
    }

    public void ShootForEnemy()
    {
        GetComponent<Rigidbody>().AddForce(0f, 0f, -speed);
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "ENEMY")
        {
            Destroy(gameObject);
        }
    }



}

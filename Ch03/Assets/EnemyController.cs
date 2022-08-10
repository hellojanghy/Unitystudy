using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    float rightMax = 4f;
    float leftMax = -4f;
    float currenPosition = 0f;
    float speed = 3.0f;


    // Start is called before the first frame update
    void Start()
    {
        currenPosition = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        currenPosition += Time.deltaTime * speed;

        if (currenPosition >= rightMax)
        {
            currenPosition = rightMax;
            speed *= -1;
        }
        else if(currenPosition <= leftMax)
        {
            currenPosition = leftMax;
            speed *= -1;
        }

        transform.position = new Vector3(currenPosition, 1f, 4.5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "BULLET")
        {
            Destroy(gameObject, 0.5f);
        }
    }

}

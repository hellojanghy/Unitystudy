using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody ballRd;
    public float speed = 10.0f;
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        ballRd = GetComponent<Rigidbody>();
        ballRd.AddForce(-speed, 0, -speed * 0.7f);

        startPos = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("WALL"))
        {
            Vector3 currPos = collision.transform.position;

            Vector3 incomVec = currPos - startPos;                    //�Ի簢
            Vector3 nomalVec = collision.contacts[0].normal;          //�������� (��������)
            Vector3 reflectVec = Vector3.Reflect(incomVec, nomalVec); //�ݻ簢

            reflectVec = reflectVec.normalized; // �ݻ簢 ����ȭ

            ballRd.AddForce(reflectVec * speed);
        }

        if (collision.gameObject.CompareTag("BLOCK"))
        {
            Vector3 currPos = collision.transform.position;

            Vector3 incomVec = currPos - startPos;                    //�Ի簢
            Vector3 nomalVec = collision.contacts[0].normal;          //�������� (��������)
            Vector3 reflectVec = Vector3.Reflect(incomVec, nomalVec); //�ݻ簢

            reflectVec = reflectVec.normalized; // �ݻ簢 ����ȭ

            ballRd.AddForce(reflectVec * speed);

            // �浹�� �ش� �� ����
            Destroy(collision.gameObject);
        }

        startPos = transform.position;
    }
}

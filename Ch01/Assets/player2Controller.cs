using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2Controller : MonoBehaviour
{
    private Rigidbody playerRd;
    float speed = 10.0f;
    

    // 게임이 처음 실행될때
    void Start()
    {
        playerRd = GetComponent<Rigidbody>();
    }

    // 게임이 실행 될때 각 프레임 별로 호출
    void Update()
    {
        // print("Update!");
        if (Input.GetKey(KeyCode.D) == true)
        {
            playerRd.AddForce(speed,0f,0f); //x,y,z
        }

        if (Input.GetKey(KeyCode.A) == true)
        {
            playerRd.AddForce(-speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.W) == true)
        {
            playerRd.AddForce(0f, 0f, speed);
        }

        if (Input.GetKey(KeyCode.S) == true)
        {
            playerRd.AddForce(0f, 0f,- speed);
        }

        if (Input.GetKey(KeyCode.Space) == true)
        {
            playerRd.AddForce(0f, speed, 0f);
            
        }


    }

}

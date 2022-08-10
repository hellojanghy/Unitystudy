using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxcontroller : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        print("충돌 Enter :" + collision.gameObject.name);
    }
    public void OnCollisionExit(Collision collision)
    {
        print("충돌 Exit :" + collision.gameObject.name);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

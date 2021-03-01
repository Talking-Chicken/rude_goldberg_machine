using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startBall : MonoBehaviour
{
    Rigidbody2D myBody;

    public float power;
    bool key;

    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        key = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && key)
        {
            myBody.AddForce((new Vector3(1, 0, 0) + new Vector3(0, 1, 0)) * power);
            key = false;
        }
    }
}

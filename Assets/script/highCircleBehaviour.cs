using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highCircleBehaviour : MonoBehaviour
{
    public float power;
    Rigidbody2D myBody;
    Rigidbody2D otherBody;

    // Start is called before the first frame update
    void Start()
    {
        myBody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "spring")
        {
            myBody.AddForce(new Vector3(0, 1, 0) * power);
            other.transform.localScale *= 2;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "hammer")
        {
            myBody.AddForce(new Vector3(1, 0, 0) * power);
            myBody.AddForce(new Vector3(0, 0.5f, 0) * power);
            otherBody = other.gameObject.GetComponent<Rigidbody2D>();
            otherBody.AddForce(new Vector3(-1, 0, 0) * power);
        }
    }
}

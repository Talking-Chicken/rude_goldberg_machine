using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallBehaviour : MonoBehaviour
{
    Rigidbody2D myBody;
    Rigidbody2D otherBody;

    public float power;

    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "bullet")
        {
            myBody.AddForce(new Vector3(1, 0, 0) * power);
            
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.name == "bottom")
        {
            otherBody = other.gameObject.GetComponent<Rigidbody2D>();
            otherBody.AddForce(new Vector3(1, 0, 0) * power * 50);
        }
    }
}

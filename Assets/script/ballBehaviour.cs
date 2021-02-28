using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballBehaviour : MonoBehaviour
{

    SpriteRenderer myRender;
    public Color floorColor;
    public Color gateColor;

    Rigidbody2D myBody;

    public float power;

    // Start is called before the first frame update
    void Start()
    {
        myRender = GetComponent<SpriteRenderer>();
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space Down");
            myBody.AddForce((new Vector3(1, 0, 0) + new Vector3(0, 10, 0)) * power);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "floor")
        {
            myRender.color = floorColor;
            Debug.Log("HIT");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "gate")
        {
            myRender.color = gateColor;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fwheelangle : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        { 

            Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();

            /*rigidbody2D.velocity = Vector2.zero;
            Vector2 jumpVelocity = new Vector2(0, jumpSpeed);
            rigidbody2D.AddForce(jumpVelocity, ForceMode2D.Impulse);*/
            rigidbody2D.AddForce(new Vector2(0, 5) * speed, ForceMode2D.Force);

        }
    }
}

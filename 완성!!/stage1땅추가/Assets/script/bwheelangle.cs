using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bwheelangle : MonoBehaviour
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
        { // 위쪽 방향키 눌렀을 때 점프

            Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();

            /*rigidbody2D.velocity = Vector2.zero;
            Vector2 jumpVelocity = new Vector2(0, jumpSpeed);
            rigidbody2D.AddForce(jumpVelocity, ForceMode2D.Impulse);*/
            rigidbody2D.AddRelativeForce(new Vector2(-0.3f, 1.22f) * speed , ForceMode2D.Force);

        }
    }
}

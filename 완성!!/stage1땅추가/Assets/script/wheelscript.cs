using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheelscript : MonoBehaviour
{
    private WheelJoint2D wheel;
    private JointMotor2D motor;
    // Transform tr;
    public float jumpSpeed;
    public bool isGround = false;
    public LayerMask ground;

    public float speed;
    public float power;
    public float forwardspeed;


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Floor")
            isGround = true;  //Ground에 닿으면 isGround는 true
    }



    // Start is called before the first frame update
    void Start()
    {
        wheel = GetComponent<WheelJoint2D>();
        motor = wheel.motor;


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        { // 스페이스 눌렀을 때 점프
            SoundManagerScript.PlaySound("JUMP");

            Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();

            rigidbody2D.AddForce(new Vector2(25, 50), ForceMode2D.Impulse);

            isGround = false;
        }

        if (Input.GetKey(KeyCode.Z))
        {

            Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
            rigidbody2D.AddForce(new Vector2(5, 0) * forwardspeed, ForceMode2D.Force);

            power = 0.9f;// * Time.deltaTime;

            motor.motorSpeed = speed * power;

            wheel.motor = motor;


        }
        else if (motor.motorSpeed != 0)
        {
            power -= 0.1f * Time.deltaTime;

            motor.motorSpeed = 0;

            wheel.motor = motor;
        }

        if (Input.GetKey(KeyCode.R))
        {

            motor.motorSpeed = 0;

            wheel.motor = motor;

            power = 0;

        }


    }
}

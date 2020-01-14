using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bodycheck2 : MonoBehaviour
{

    public bool isGround = false;
    public LayerMask ground;

    public bool isCat = false;
    public LayerMask cat;



    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Floor")
            isGround = true;  //Ground에 닿으면 isGround는 true

        if (col.gameObject.tag == "cat")
            isCat = true;
    }



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (isGround)
        { // 스페이스 눌렀을 때 점프

            SceneManager.LoadScene("GameOver2");
        }

        if (isCat)
        { // 스페이스 눌렀을 때 점프

            SceneManager.LoadScene("Ending");
        }

    }
}

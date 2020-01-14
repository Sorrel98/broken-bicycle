using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WheelClearScript : MonoBehaviour
{

    public bool isClear = false;
    public LayerMask Flag;

    public bool isCat = false;
    public LayerMask cat;


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Flag")
            isClear = true;  //Ground에 닿으면 isGround는 true
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
        if (isClear)
        { // 스페이스 눌렀을 때 점프

            SceneManager.LoadScene("GameClear");
        }

        if (isCat)
        { // 스페이스 눌렀을 때 점프

            SceneManager.LoadScene("Ending");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearScript : MonoBehaviour
{

    public bool isClear = false;
    public LayerMask player;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "player")
            isClear = true;  //Ground에 닿으면 isGround는 true
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
    }
}

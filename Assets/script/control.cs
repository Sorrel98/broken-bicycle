using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    Transform tr;
    public bool isGround = false;
    public LayerMask ground;


    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        tr = GetComponent<Transform>();


        if (tr.position.y < -20.75f) // 떨어질 시 처음 위치로 
        {
            tr.position = new Vector2(-156.6734F, -10.85361F);
        }
    }
}

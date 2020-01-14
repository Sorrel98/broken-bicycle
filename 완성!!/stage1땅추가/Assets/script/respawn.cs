using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{   [SerializeField]Transform spawnpoint;

    Transform tr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tr = GetComponent<Transform>();
        if (Input.GetKeyDown(KeyCode.R)) { 
                tr.position = spawnpoint.position;
            
        }
    }
}

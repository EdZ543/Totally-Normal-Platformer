﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dedanimation : MonoBehaviour
{
    public GameObject player;
    private Rigidbody2D rb;
    public float isded = 0;
    public float dedtimer = 0;
     Vector3 pos;
     Vector3 pos2;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        pos2 = player.transform.position;
        
        if(isded == 1){
            dedtimer += 1;
        }
        if(dedtimer == 1){
        pos.y = pos2.y;
        pos.x = pos2.x;
        rb.velocity = new Vector2(0, 15);
        rb.gravityScale = 5;
        Destroy(player);
        
        }

        gameObject.transform.position = pos;
    
        
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class axehit : MonoBehaviour
{
    public GameObject player;
    public GameObject dedguy;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("Player")){

            dedanimation script = dedguy.GetComponent<dedanimation>();
            script.isded = 1;
            //Destroy(player);
        
        }

    }

    

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nobounce : MonoBehaviour
{
    public GameObject player;
    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("Player")){
            
            rb.velocity = new Vector2(0, 4);
        
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove : MonoBehaviour
{
    private Rigidbody2D rb;
    public float direction = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(direction == 0){
        rb.velocity = new Vector2(-1, 0);
        } 
        if(direction == 1){
        rb.velocity = new Vector2(1, 0);
        }
    }
}

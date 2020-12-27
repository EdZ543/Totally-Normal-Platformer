using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    
    public float time = 0;

    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;

    private SpriteRenderer sprite1;
    private SpriteRenderer sprite2;
    private SpriteRenderer sprite3;
    private SpriteRenderer sprite4;

    public GameObject lolone;
    public GameObject loltwo;
    public GameObject lolthree;
    public GameObject lolfour;

    
    // Start is called before the first frame update
    void Start()
    {
        sprite1 = one.GetComponent<SpriteRenderer>();
        sprite2 = two.GetComponent<SpriteRenderer>();
        sprite3 = three.GetComponent<SpriteRenderer>();
        sprite4 = four.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        
        time += 1;
        
        if(time > 100){
            
            sprite1.sortingOrder = -10;
            sprite1.sortingLayerName = "background";
            sprite2.sortingOrder = -10;
            sprite2.sortingLayerName = "background";
            
            sprite3.sortingOrder = 10;
            sprite3.sortingLayerName = "default";
            sprite4.sortingOrder = 10;
            sprite4.sortingLayerName = "default";
            


            lolone.SetActive (true);
            loltwo.SetActive (true);
            
            lolthree.SetActive (false);
            lolfour.SetActive (false);
            


        } else {
            
            sprite1.sortingOrder = 10;
            sprite1.sortingLayerName = "default";
            sprite2.sortingOrder = 10;
            sprite2.sortingLayerName = "default";
            
            sprite3.sortingOrder = -10;
            sprite3.sortingLayerName = "background";
            sprite4.sortingOrder = -10;
            sprite4.sortingLayerName = "background";
            


            lolone.SetActive (false);
            loltwo.SetActive (false);
            
            lolthree.SetActive (true);
            lolfour.SetActive (true);
            



        }
        
        if(time >= 200){
            time = 0;
        }
        
        
    }


}

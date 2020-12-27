using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer2 : MonoBehaviour
{
    
    public float time = 0;

    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public GameObject six;

    private SpriteRenderer sprite1;
    private SpriteRenderer sprite2;
    private SpriteRenderer sprite3;
    private SpriteRenderer sprite4;
    private SpriteRenderer sprite5;
    private SpriteRenderer sprite6;

    public GameObject lolone;
    public GameObject loltwo;
    public GameObject lolthree;
    public GameObject lolfour;
    public GameObject lolfive;
    public GameObject lolsix;

    
    // Start is called before the first frame update
    void Start()
    {
        sprite1 = one.GetComponent<SpriteRenderer>();
        sprite2 = two.GetComponent<SpriteRenderer>();
        sprite3 = three.GetComponent<SpriteRenderer>();
        sprite4 = four.GetComponent<SpriteRenderer>();
        sprite5 = five.GetComponent<SpriteRenderer>();
        sprite6 = six.GetComponent<SpriteRenderer>();

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
            sprite3.sortingOrder = -10;
            sprite3.sortingLayerName = "background";
            
            sprite4.sortingOrder = 10;
            sprite4.sortingLayerName = "default";
            sprite5.sortingOrder = 10;
            sprite5.sortingLayerName = "default";
            sprite6.sortingOrder = 10;
            sprite6.sortingLayerName = "default";
            


            lolone.SetActive (true);
            loltwo.SetActive (true);
            lolthree.SetActive (true);
            
            lolfour.SetActive (false);
            lolfive.SetActive (false);
            lolsix.SetActive (false);
            


        } else {
            
            sprite1.sortingOrder = 10;
            sprite1.sortingLayerName = "default";
            sprite2.sortingOrder = 10;
            sprite2.sortingLayerName = "default";
            sprite3.sortingOrder = 10;
            sprite3.sortingLayerName = "default";
            
            sprite4.sortingOrder = -10;
            sprite4.sortingLayerName = "background";
            sprite5.sortingOrder = -10;
            sprite5.sortingLayerName = "background";
            sprite6.sortingOrder = -10;
            sprite6.sortingLayerName = "background";
            


            lolone.SetActive (false);
            loltwo.SetActive (false);
            lolthree.SetActive (false);
            
            lolfour.SetActive (true);
            lolfive.SetActive (true);
            lolsix.SetActive (true);
            



        }
        
        if(time >= 200){
            time = 0;
        }
        
        
    }


}

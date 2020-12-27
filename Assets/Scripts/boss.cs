using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class boss : MonoBehaviour
{
    private Rigidbody2D rb;
    Vector3 pos;
    public float randumb;
    public float randumb2;
    public float direction;
    Renderer reeee;
    public float hurting = 0;
    public float health = 50;
    public Image white;
    public Animator anim;
    public float bossisded;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-1, 0);
        reeee = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        gameObject.transform.position = pos;
        randumb = Random.Range(0,10);
        randumb2 = Random.Range(0,10);

        if(health > 0){
        
        if(randumb > 5){
            direction = 4;
        }

        if(randumb <= 5){
            direction = -4;
        }
        
        if(pos.x > 3.4 ){
            rb.velocity = new Vector2(-1, rb.velocity.y);
        }

        if(pos.x < 0 && pos.y < -2.35){
            rb.velocity = new Vector2(1, rb.velocity.y);
        }

        if(pos.x < -8){
            rb.velocity = new Vector2(1, rb.velocity.y);
        }

        if(pos.y < -2.35 && health > 0){
             rb.velocity = new Vector2(rb.velocity.x, 1);
        }

        if(pos.y < -2.35 && randumb2 == 1){
             rb.velocity = new Vector2(rb.velocity.x, 10);
        }

        if(hurting == 0){
            reeee.material.color = Color.white;
        }
        if(hurting >= 1){
            hurting = 0;
            reeee.material.color = Color.red;
        }
        }

        if(health <= 0){
            reeee.material.color = Color.red;
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        if(pos.y < -11){
            StartCoroutine(Fading());
            //Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("Player")){
            
            if(health > 0){
            rb.velocity = new Vector2(direction, 6);
            }
            hurting += 1;
            health -= 10;
        
        }

    }

    IEnumerator Fading(){
    anim.SetBool("fade",true);
    yield return new WaitUntil(()=>white.color.a==1);
    SceneManager.LoadScene("end");
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonEnemy : MonoBehaviour
{   
    public float speed = 50f, maxspeed = 1, jumpPow = 270f;
    public bool grounded = true, doublejump = false;

    public int direction = 0;
   
    public int ourHealth;
    public int maxHealth = 6;
    
    public bool damaged = false;
    public int damagedDelay = 0;

    public Rigidbody2D r2;
    public Animator anim;

    public SkeletonDetPlayer det;
 
    // Use this for initialization
    void Start () {
        r2 = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        
        det = gameObject.GetComponent<SkeletonDetPlayer>();

        ourHealth = maxHealth;

        
    }
   
    // Update is called once per frame
    void Update () {
        anim.SetBool("Grounded", grounded);
        anim.SetFloat("Speed", Mathf.Abs(r2.velocity.x));
 
    }
 
    void FixedUpdate()
    {   
        //int h = 0;
        if (det.approachCountDown == 0) {
            r2.AddForce((Vector2.right) * speed * direction);
 
            if (r2.velocity.x > maxspeed)
                r2.velocity = new Vector2(maxspeed, r2.velocity.y);
            if (r2.velocity.x < -maxspeed)
                r2.velocity = new Vector2(-maxspeed, r2.velocity.y);
        }

        if (grounded) {
            r2.velocity = new Vector2(r2.velocity.x*0.7f, r2.velocity.y);
        }

        if (ourHealth == 0) {
            Death();
        }

        if (damaged) {
            if (damagedDelay == 0) {
                damaged = false;
            }
            else {
                damagedDelay -= 1;
            }
        }
    }
 
    

    public void Death() {
        gameObject.SetActive(false);
    }

    public void Damage(int dmg) {
        if (!damaged) {
            damaged = true;
            damagedDelay = 25;
            ourHealth -= dmg;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonEnemyAttack : MonoBehaviour
{   
    public float nextCountDown = 150;
    public bool nextAttack = false;
    public int attackCountDown = 105;

    public bool causeDamage = false;
    public bool attacking = false;
    public int attackDelay = 20;
    public Animator anim;

    public Collider2D trigger;
    //public Collider2D trigger2;
    private void Awake() {
        anim = gameObject.GetComponent<Animator>();

        //trigger2.enabled = true;
        trigger.enabled = true;

        anim.SetBool("Attacking", attacking);
    }

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        // if (attacking) {
        //     if (attackDelay > 0) {
        //         attackDelay -= Time.deltaTime;
        //     }
        //     else {
        //         attacking = false;
        //         //trigger.enabled = false;   
        //     }
        // }
        
        
        //anim.SetBool("Attacking", true);

        anim.SetBool("Attacking", attacking);
    }

    void FixedUpdate() {
        if (attacking) {
            if (attackCountDown > 0) {
                attackDelay = 10;
                attackCountDown--;
            }
            if (attackCountDown == 0 ) {
                causeDamage = true;
            }
            if (attackDelay > 0) {
                attackDelay--;
            }
            if (attackDelay == 0) {
                //attacking = false;
                causeDamage = false;
            }
            if (nextCountDown > 0) {
                nextCountDown--;
            }
            if (nextCountDown == 0) {
                nextAttack = true;
                attacking = false;
            }
        }

        if (!attacking) {
            attackCountDown = 110;
            nextCountDown = 130;
        }
    }
}

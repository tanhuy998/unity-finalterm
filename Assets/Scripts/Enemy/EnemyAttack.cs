using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float attackDelay = 0.3f;
    public int attackPeriod = 50;
    public bool attacking = false;

    public Animator anim;

    public Collider2D trigger;
    public Collider2D trigger2;
    private void Awake() {
        anim = gameObject.GetComponent<Animator>();

        trigger2.enabled = true;
        trigger.enabled = true;
    }

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (attacking) {
            if (attackDelay > 0) {
                attackDelay -= Time.deltaTime;
            }
            else {
                attacking = false;
                //trigger.enabled = false;   
            }
        }

        //anim.SetBool("Attacking", true);

        anim.SetBool("Attacking", attacking);
    }

    void FixedUpdate() {
        if (attackPeriod != 0 ) {
            attackPeriod--;
        }
    }
}

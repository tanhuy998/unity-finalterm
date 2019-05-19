using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{   
    public float attackDelay = 0.3f;
    public bool attacking = false;

    public Animator anim;

    public Collider2D trigger;
    private void Awake() {
        anim = gameObject.GetComponent<Animator>();
        trigger.enabled = false;
    }

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && !attacking) {
            attacking = true;
            trigger.enabled = true;
            attackDelay = 0.3f;
        }

        if (attacking) {
            if (attackDelay > 0) {
                attackDelay -= Time.deltaTime;
            }
            else {
                attacking = false;
                trigger.enabled = false;
            }
        }

        anim.SetBool("Attacking", attacking);
    }
}

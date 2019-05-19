using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackTrigger : MonoBehaviour
{
    //ublic Enemy parent;
    public EnemyAttack self;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        self = gameObject.transform.parent.GetComponent<EnemyAttack>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            print(gameObject.name);
            

            if (!self.attacking &&self.attackPeriod == 0) {
                other.SendMessageUpwards("Damage", 1);
                self.attacking = true;
                self.attackDelay = 0.3f;
                self.attackPeriod = 100;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            print(gameObject.name);

            if (!self.attacking && self.attackPeriod == 0) {
                other.SendMessageUpwards("Damage", 1);
                self.attacking = true;
                self.attackDelay = 0.3f;
                self.attackPeriod = 100;
            }
        }
    }
}
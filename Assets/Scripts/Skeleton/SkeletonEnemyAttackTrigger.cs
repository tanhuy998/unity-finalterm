using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonEnemyAttackTrigger : MonoBehaviour
{
    //ublic Enemy parent;
    public SkeletonEnemyAttack self;
    public SkeletonEnemy self2;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        self = gameObject.transform.parent.GetComponent<SkeletonEnemyAttack>();
        self2 = gameObject.transform.parent.GetComponent<SkeletonEnemy>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other) {
        
        if (other.CompareTag("Player")) {
            print(gameObject.name);
            self2.direction = 0;
            
            if (!self.attacking) {
                self.attacking = true;
            }

            if (self.causeDamage) {
                other.SendMessageUpwards("Damage", 1);
            }
        }
    }

    private void OnTriggerStay2D(Collider2D other) {
        
        if (other.CompareTag("Player")) {
            print(gameObject.name);
            self2.direction = 0;

            if (!self.attacking) {
                self.attacking = true;
            }

            if (self.causeDamage) {
                other.SendMessageUpwards("Damage", 1);
            }
        }
    }
}
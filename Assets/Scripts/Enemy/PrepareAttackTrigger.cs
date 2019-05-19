using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrepareAttackTrigger : MonoBehaviour
{

    public EnemyAttack self;
    // Start is called before the first frame update
    void Start()
    {
        self = gameObject.transform.parent.GetComponent<EnemyAttack>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            if (!self.attacking &&self.attackPeriod == 0) {
                self.attacking = true;
                self.attackDelay = 0.3f;
                self.attackPeriod = 100;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            if (!self.attacking &&self.attackPeriod == 0) {
                self.attacking = true;
                self.attackDelay = 0.3f;
                self.attackPeriod = 100;
            }
        }
    }
}

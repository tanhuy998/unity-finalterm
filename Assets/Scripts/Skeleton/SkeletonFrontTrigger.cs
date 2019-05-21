using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonFrontTrigger : MonoBehaviour
{
    public SkeletonDetPlayer det;

    public SkeletonEnemy self;

    public SkeletonEnemyAttack self2;
    // Start is called before the first frame update
    void Start()
    {
        det =gameObject.transform.parent.GetComponent<SkeletonDetPlayer>();
        self = gameObject.transform.parent.GetComponent<SkeletonEnemy>();
        self2 = gameObject.transform.parent.GetComponent<SkeletonEnemyAttack>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            if (!self2.attacking) {
                if (det.faceright) {
                    self.direction = 1;
                }
                else {
                    self.direction = -1;
                }
                det.approachCountDown = 50;
                det.detectBehind = false;
            }
            else {
                self.direction = 0;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            if (!self2.attacking) {
                if (det.faceright) {
                    self.direction = 1;
                }
                else {
                    self.direction = -1;
                }
                //det.approachCountDown = 50;
                det.detectBehind = false;
            }
            else {
                self.direction = 0;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        self.direction = 0;
    }
}

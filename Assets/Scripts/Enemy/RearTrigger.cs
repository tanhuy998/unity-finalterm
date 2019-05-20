using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RearTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public DetectPlayer det;
    public Enemy self;
    // Start is called before the first frame update
    void Start()
    {
        det = gameObject.transform.parent.GetComponent<DetectPlayer>();
        self =  gameObject.transform.parent.GetComponent<Enemy>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            
            if (det.faceright) {
                //det.faceright = false;
                det.Flip();
                self.direction = -1;
            }
            det.realizeBehind = 50;
            det.detectBehind = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        self.direction = 0;
    }
}

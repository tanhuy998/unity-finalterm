using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RearTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public DetectPlayer det;
    // Start is called before the first frame update
    void Start()
    {
        det =gameObject.transform.parent.GetComponent<DetectPlayer>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            det.realizeBehind = 50;
            det.detectBehind = true;
        }
    }
}

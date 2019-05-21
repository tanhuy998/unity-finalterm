using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlankSpace : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider2D trigger;

    private void Start() {
        trigger = gameObject.GetComponent<Collider2D>();
        trigger.enabled = true;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            other.SendMessageUpwards("Death");
        }
    }
}

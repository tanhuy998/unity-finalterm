using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    // Start is called before the first frame update
    public int lvl = 1;

    public Collider2D trigger;

    private void Start() {
        trigger = gameObject.GetComponent<Collider2D>();
        
        trigger.enabled = true;
    }
    private void OnTriggerEnter2D(Collider2D other) {
        
    }

    private void OnTriggerStay2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            if (Input.GetKeyDown(KeyCode.X)) {
                //other.SendMessageUpwards("Death");
                SceneManager.LoadScene(lvl);
            }
        }
    }
}

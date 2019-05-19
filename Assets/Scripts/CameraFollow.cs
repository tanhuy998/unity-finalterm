using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float smoothtimeX, smoothtimeY;
    public Vector2 velocity;

    public Vector2 minPos, maxPos;
    public bool bound;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() {

        float posX = Mathf.SmoothDamp(this.transform.position.x, player.transform.position.x, ref velocity.x, smoothtimeX);
        float posY = Mathf.SmoothDamp(this.transform.position.y, player.transform.position.y, ref velocity.y, smoothtimeY);

        transform.position = new Vector3(posX, posY, transform.position.z);

        if (bound) {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, minPos.x, maxPos.x),
                Mathf.Clamp(transform.position.y, minPos.y, maxPos.y),
                Mathf.Clamp(transform.position.z, transform.position.z, transform.position.z)
            );
        }
    }
}

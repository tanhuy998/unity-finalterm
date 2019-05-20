using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    public Enemy self;

    public int realizeBehind = 0;

    public int approachCountDown = 0;

    public bool detectBehind = false;
    public bool faceright = true;
    public Collider2D front;
    public Collider2D rear;

    public int detect = 0;
    // Start is called before the first frame update
    void Start()
    {
        self = gameObject.transform.parent.GetComponent<Enemy>();
        front.enabled = true;
        rear.enabled = true;
    }
    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate() {
        if (realizeBehind != 0 && detectBehind) {
            realizeBehind--;
        }
        if (realizeBehind == 0 && detectBehind) {
            Flip();
            detectBehind = false;
        }

        if (approachCountDown > 0) {
            approachCountDown--;
        }
    }
    
    public void Flip()
    {   
        faceright = !faceright;
        Vector3 Scale;
        Scale = transform.localScale;
        Scale.x *= -1;
        transform.localScale = Scale;
    }
}

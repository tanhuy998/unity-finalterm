using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{   
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    private void FixedUpdate() {
        Vector2 offset = GetComponent<MeshRenderer>().material.mainTextureOffset;

        offset.x = camera.transform.position.x / 7;

        GetComponent<MeshRenderer>().material.mainTextureOffset = offset * Time.deltaTime;
    }
}

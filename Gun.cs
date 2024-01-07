using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject Dan;
    Transform loc;
    // Start is called before the first frame update
    void Start()
    {
        loc = GameObject.Find("Launch Pad").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Object.Instantiate(Dan, loc.position,loc.rotation); 
        }
        
    }
}

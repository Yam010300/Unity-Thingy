using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    int Wait = 1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * 0.01f;
        Wait -= 1;
        if (Wait == 0)
        {
            Destroy(gameObject);
        }
    }


}

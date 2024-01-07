
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face : MonoBehaviour
{
    public Camera cam;
    Vector2 Point;
    private void Start()
    {
        cam = Camera.main;
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 Pos = Input.mousePosition;
        Point = cam.ScreenToWorldPoint(Pos);
        
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, Mathf.Atan2(Point.y, Point.x) * Mathf.Rad2Deg -90);
        Debug.Log(Point.x.ToString());
        Debug.Log(Point.y.ToString());
    }
}

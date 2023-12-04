using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.ReorderableList;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject Speak;
    public TextMessage Tm;
    public float Speed;
    public Rigidbody2D rb;
    Vector2 Move;

    // Start is called before the first frame update
    void Start()
    {
        Speed = 10.0f;
        Tm = Speak.GetComponent<TextMessage>();
    }

    // Update is called once per frame
    void Update()
    {
        Move.x = Input.GetAxisRaw("Horizontal");
        Move.y = Input.GetAxisRaw("Vertical");
        if (Tm.Talking == true)
        {
            Speed = 0f;
        }
        else
        {
            Speed = 10.0f;
        }

    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + Move * Speed * Time.fixedDeltaTime);
    }
}

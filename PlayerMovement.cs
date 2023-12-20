using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting.ReorderableList;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D Plrb;
    Vector2 Move;
    public float PlSpeed;

    public ProjBeh ProjPrefab;
    public Transform Launch;

    // Start is called before the first frame update
    void Start()
    {
        Plrb = GetComponent<Rigidbody2D>();
        PlSpeed = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Move.x = Input.GetAxisRaw("Horizontal");
        Move.y = Input.GetAxisRaw("Vertical");

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(ProjPrefab, Launch.position, transform.rotation);
        }
    }

    private void FixedUpdate()
    {
        Plrb.MovePosition(Plrb.position + Move * PlSpeed * Time.fixedDeltaTime); 
    }
}

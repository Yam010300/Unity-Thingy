using UnityEngine;

public class ProjBeh : MonoBehaviour
{
    float Speed = 50.0f;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * Time.deltaTime * Speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}

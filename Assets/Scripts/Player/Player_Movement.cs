using UnityEngine;
using System.Collections;

public class Player_Movement : MonoBehaviour
{
    new Rigidbody2D rigidbody;

    public float moveSpeed = 10f;
    public float mapWidth = 3f;

    public void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * moveSpeed;

        Vector2 position = rigidbody.position + Vector2.right * moveHorizontal;
        position.x = Mathf.Clamp(position.x, -mapWidth, mapWidth);

        rigidbody.MovePosition(position);
    }
}
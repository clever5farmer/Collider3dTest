using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoDPlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveH, moveV;
    [SerializeField] private float moveSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        moveH = Input.GetAxisRaw("Horizontal") * moveSpeed;// * Time.deltaTime;
        moveV = Input.GetAxisRaw("Vertical") * moveSpeed;

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveH, moveV);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("111111111111");
    }
}
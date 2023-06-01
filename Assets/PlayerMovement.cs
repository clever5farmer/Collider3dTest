using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	private Rigidbody rb;
	private Vector3 movement;
	private float moveH, moveV;
	[SerializeField] private float moveSpeed = 2.0f;

	private void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	private void Update()
	{
		moveH = Input.GetAxisRaw("Horizontal") * moveSpeed;// * Time.deltaTime;
		moveV = Input.GetAxisRaw("Vertical") * moveSpeed;// * Time.deltaTime;
		movement = new Vector3(moveH, 0f, moveV);
	}

	private void FixedUpdate()
	{
		Vector3 currentPosition = transform.position;
		currentPosition.y = 0f;
		rb.velocity = movement;
		//rb.velocity = new Vector2(moveH, moveV);
		//rb.MovePosition(currentPosition + movement);

	}

}

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
		movement = new Vector3(moveH, moveV, 0f);
	}

	private void FixedUpdate()
	{
		rb.velocity = movement;
		//rb.velocity = new Vector2(moveH, moveV);
		//rb.MovePosition(currentPosition + movement);

	}

	private void OnCollisionEnter(Collision collision)
	{
		Debug.Log("111111");
	}

}

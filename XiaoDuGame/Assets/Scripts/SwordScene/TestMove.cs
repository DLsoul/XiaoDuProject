using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMove : MonoBehaviour
{
	private Camera camera;
	private CharacterController cc;
	public float speed;

	void Start()
	{
		camera = Camera.main;
		cc = GetComponent<CharacterController>();
	}

	void Update()
	{
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		Vector3 inputDir = new Vector3(h, 0, v);
		Vector3 moveDir = Quaternion.Euler(0, camera.transform.eulerAngles.y, 0) * inputDir;
		cc.Move(moveDir * Time.deltaTime * speed);
	}
}

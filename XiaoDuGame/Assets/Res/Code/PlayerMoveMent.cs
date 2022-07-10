using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveMent : MonoBehaviour
{
	CharacterController _characterController;
	Vector3 move;
	public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
		_characterController = this.transform.GetComponent<CharacterController>();
	}

    // Update is called once per frame
    void Update()
    {
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");

		move = transform.right * x + transform.forward * z;

		_characterController.Move(move * speed * Time.deltaTime);
    }
}

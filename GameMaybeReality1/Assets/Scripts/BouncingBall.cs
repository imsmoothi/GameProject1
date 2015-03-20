using UnityEngine;
using System.Collections;

public class BouncingBall : MonoBehaviour {
	public float JumpSpeed = 15;
	public  bool grounded = false;
	private bool dblJump = true;
	// Use this for initialization
	void Start () {
	
	}

	// Verifica se Objecto esta a colidir com algo
	void OnCollisionEnter (Collision hit)
	{
		grounded = true;
		dblJump = true;
		// check message upon collition for functionality working of code.
		Debug.Log ("I am colliding with something");
	}

	// Update is called once per frame
	void Update () {

		if ((grounded == true) && (Input.GetButtonDown("Jump")))	//Se estiver no chao e carregar espaço salta
		{
			GetComponent<Rigidbody>().AddForce(Vector3.up* JumpSpeed);
			
			grounded = false;
		} 
		else if (!grounded && dblJump && (Input.GetButtonDown("Jump"))) //Double Jump
		{
			GetComponent<Rigidbody>().AddForce(Vector3.up* JumpSpeed);
			
			dblJump = false;
		}
		if (Input.GetButtonDown ("Fire1")) {	//Se carregar no botao direito do rato
			JumpSpeed = JumpSpeed * 2;
		}
	}
}

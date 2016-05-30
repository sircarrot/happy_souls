using UnityEngine;
using System.Collections;

public class followPlayer : MonoBehaviour {

	public GameObject Player;
	public float z;
	public float x;

	// Update is called once per frame
	void Update () {
		x = Player.transform.position.x;
		z = Player.transform.position.z-1.0f;

		transform.position= new Vector3(x,10.45f,z);
	}
}

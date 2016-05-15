using UnityEngine;
using System.Collections;

public class CameraRunnerScript : MonoBehaviour {

	public Transform player;
	
	// Update is called once per frame
	void Update () 
	{
		if (player == null)
			return;
		transform.position = new Vector3 (player.position.x + 6, 0, -10);	
	}
}

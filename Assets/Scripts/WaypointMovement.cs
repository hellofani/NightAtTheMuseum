using UnityEngine;
using System.Collections;

public class WaypointMovement : MonoBehaviour {
	
	public GameObject player;

	public float height = 2;
	public bool teleport = true;

	public float maxMoveDistance = 10;
	private bool moving = false;
	private bool toggle = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Move(GameObject waypoint) {
		if (!teleport) {
			iTween.MoveTo (player, 
				iTween.Hash (
					"position", new Vector3 (waypoint.transform.position.x, waypoint.transform.position.y + height / 2, waypoint.transform.position.z), 
					"time", .2F, 
					"easetype", "linear"
				)
			);
		} else {
			player.transform.position = new Vector3 (waypoint.transform.position.x, 
                waypoint.transform.position.y + height / 2, 
                waypoint.transform.position.z);
		}
	}
	//toggle visibility of game object with Video playre.
	public void Hide(GameObject vplay) {
		if (toggle = true) {
			vplay.SetActive(!vplay.activeInHierarchy);
          Debug.Log ("toggle");
			//toggle = false;
		}
	}


}


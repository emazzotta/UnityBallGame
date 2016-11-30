using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	
	public GameObject player;
	private Vector3 offset;
	
	void Start () {
		offset = this.transform.position - player.transform.position;
	}
	
	void Update () {
		this.transform.position = player.transform.position + offset;
	}
}

/*using UnityEngine;
using System.Collections;

public class FollowLight : MonoBehaviour {

	Transform target;
	float smoothTime = 0.3f;
	float xOffset = 1.0f;
	float yOffset = 1.0f;

	private Vector2 velocity;
	private Transform transform;

	// Use this for initialization
	void Start () {
		this.transform = transform; 
	}
	
	// Update is called once per frame
	void LateUpdate () {
		this.transform.position = new Vector2 (Mathf.Lerp (this.transform.position.x, target.position.x + xOffset, smoothTime), Mathf.Lerp (this.transform.position.y, target.position.y + yOffset, smoothTime));
		//transform.position.x = Mathf.Lerp (this.transform.position.x, target.position.x + xOffset, smoothTime);
		//transform.position.y = Mathf.Lerp (this.transform.position.y, target.position.y + yOffset, smoothTime);
	}
}
*/

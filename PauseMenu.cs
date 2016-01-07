using UnityEngine;
using System.Collections;


public class PauseMenu : MonoBehaviour {

	Animator anim;
	bool paused = false;
	bool showMenu = false;
	public Canvas ingameMenu;
	
	void Update () {
	if (Input.GetButtonDown ("Cancel"))
						paused = togglePause ();
	}

	void OnGUI()
		{
				if (paused) {
						ingameMenu.enabled = true;
				} 

				else {
						ingameMenu.enabled = false;
				}
		}




	bool togglePause()
	{
				if (Time.timeScale == 0f) {
						Time.timeScale = 1f;
						return(false);
				} else {
						Time.timeScale = 0f;
						return(true);
				}
		}
}

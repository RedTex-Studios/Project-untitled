using UnityEngine;
using System.Collections;

public class ButtonControl : MonoBehaviour {
	public int firstLevelIndex;
	public void Play(){
		Time.timeScale = 1f;
		Application.LoadLevel (firstLevelIndex);
	}
}

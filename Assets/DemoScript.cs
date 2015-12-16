using UnityEngine;
using System.Collections;
using plakcDIGALite;

public class DemoScript : MonoBehaviour {

	public int NextScene;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI()
	{
		if(GUI.Button(new Rect(Screen.width - 100, 0, 100, 100),"NextScene : "+NextScene))
		{
			GameObject go = GameObject.FindGameObjectWithTag("PROPHET");
			go.GetComponent<PROPHET>().ProphetRequest(true,NextScene);
		}
		if(GUI.Button(new Rect(0, 0, 100, 100),"EXIT"))
		{
			GameObject go = GameObject.FindGameObjectWithTag("PROPHET");
			go.GetComponent<PROPHET>().ProphetRequest(true,-1);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldSceneManager : PocketDroidSceneManager {
    public override void droidTapped(GameObject droid)
    {
        
    }

    public override void playerTapped(GameObject player)
    {
        SceneManager.LoadScene(PocketDroidConstants.SCENE_CAPTURE, LoadSceneMode.Additive);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

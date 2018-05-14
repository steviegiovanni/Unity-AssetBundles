using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class LoadBundleFromFile : MonoBehaviour {

	// Use this for initialization
	void Start () {
		AssetBundle myLoadedAssetBundle = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "testscene"));
		if (myLoadedAssetBundle == null) {
			Debug.Log("Failed to load AssetBundle!");
			return;
		}
		SceneManager.LoadScene ("testscene");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

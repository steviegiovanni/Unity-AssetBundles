using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LoadUnitBundle : MonoBehaviour {
	// Use this for initialization
	void Start () {
		AssetBundle assetBundle = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath,"AssetBundles"));
		AssetBundleManifest manifest = assetBundle.LoadAsset<AssetBundleManifest>("AssetBundleManifest");
		string[] dependencies = manifest.GetAllDependencies("units/unit1"); //Pass the name of the bundle you want the dependencies for.
		foreach(string dependency in dependencies)
		{
			AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, dependency));
		}


		AssetBundle unitAssetBundle = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "units/unit1"));
		if (unitAssetBundle == null) {
			Debug.Log ("Failed to load unit bundle!");
			return;
		} else {
			GameObject unit1prefab = unitAssetBundle.LoadAsset<GameObject> ("unit1");
			GameObject unit1 = Instantiate (unit1prefab);
		}
	}

	// Update is called once per frame
	void Update () {

	}
}

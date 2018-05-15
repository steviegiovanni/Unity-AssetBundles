using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LoadUnitBundle : MonoBehaviour {
	// Use this for initialization
	void Start () {
		/*AssetBundle stateMachineBehavioursBundle = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "statemachinebehaviours"));
		if (stateMachineBehavioursBundle == null) {
			Debug.Log ("Failed to load behaviour bundle!");
			return;
		} else {*/
			AssetBundle unitAssetBundle = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "units/unit1"));
			if (unitAssetBundle == null) {
				Debug.Log ("Failed to load unit bundle!");
				return;
			} else {
				GameObject unit1prefab = unitAssetBundle.LoadAsset<GameObject> ("unit1");
				GameObject unit1 = Instantiate (unit1prefab);
			}
		//}
	}

	// Update is called once per frame
	void Update () {

	}
}

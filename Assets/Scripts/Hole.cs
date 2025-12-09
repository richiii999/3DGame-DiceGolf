using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Hole : MonoBehaviour{
    public Button nextHoleButton; // NextHole button (in UI prefab)
    public string nextHole = "MainMenu"; // What is the next hole? 

    void Start(){
        if (SceneUtility.GetBuildIndexByScenePath(nextHole) == -1) {
            Debug.LogWarning("Invalid nextHole, using 'MainMenu' instead");
            nextHole = "MainMenu";
        }

        if (!nextHoleButton) { Debug.LogWarning("nextHoleButton not set!"); }
    }

    public void OnTriggerEnter(Collider other){ if (other.tag == "Golf Ball") HoleComplete(); }

    void HoleComplete() { if (nextHoleButton) nextHoleButton.enabled = true; }
}

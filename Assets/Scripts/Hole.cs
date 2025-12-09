using UnityEngine;
using UnityEngine.SceneManagement;

public class Hole : MonoBehaviour{
    public GameObject nextHoleButton; // NextHole button (in UI prefab)
    public string nextHole = "MainMenu"; // What is the next hole? 

    void Start(){
        if (SceneUtility.GetBuildIndexByScenePath(nextHole) == -1) {
            Debug.LogWarning("Invalid nextHole, using 'MainMenu' instead");
            nextHole = "MainMenu";
        }

        if (!nextHoleButton) { 
            Debug.LogWarning("nextHoleButton not set, attempting search");
            nextHoleButton = GameObject.Find("UI/UI_Canvas/NextHole"); 

            if (!nextHoleButton) { Debug.LogError("nextHoleButton not found!"); }
        }
    }

    public void OnTriggerEnter(Collider other){ if (other.tag == "Golf Ball") HoleComplete(); }

    void HoleComplete() { if (nextHoleButton) nextHoleButton.SetActive(true); }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HabitatMenu : MonoBehaviour {
    public string landLevel;
    public string airLevel;
    public string waterLevel;

	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}


    //Use this for loading land habitat
    public void loadLandHabitat()
    {
        SceneManager.LoadScene(landLevel);
    }

    //Use this for loading Air habitat
    public void loadAirHabitat()
    {
        SceneManager.LoadScene(airLevel);
    }

    //Use this for loading Water habitat
    public void loadWaterHabitat()
    {
        SceneManager.LoadScene(waterLevel);
    }

}

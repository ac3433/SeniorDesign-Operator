using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour {

    private Command buttonH, buttonESC, buttonS, buttonD, buttonTab;
    
	// initalize the preset of button mapping
	void Start ()
    {
        buttonH = new HomeScreenCommand();
        buttonESC = new GameMenuCommand();
	}
	
	// Update is called once per frame
	void Update () {
        // can add a condition to disable handle input in siutation like EMP
        HandleInput();
	}

    private void HandleInput()
    {
        if(Input.GetKeyDown(KeyCode.ESC))
        {
            buttonESC.Execute();
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            buttonH.Execute();
        }
    }

    //to implement rebinding 
}

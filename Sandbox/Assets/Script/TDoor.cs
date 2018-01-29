using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDoor : MonoBehaviour {

    public float timeUntilClose;    // Set to -1 for never close
    private float timer = 0f;
    public bool isLocked;
    private bool isOpen;
    //public Puzzle puzzle;
    Animator animator;

	public void Start () {
        animator = GetComponent<Animator>();
	}
	
	public void Open () {
        if (!isLocked)  // (!isLocked && (puzzle == null || puzzle.isSolved))       Check flags
        {
            isOpen = true;
            if (timeUntilClose != -1)
            {
                timer = timeUntilClose;
            }
            if (animator)
            {
                // TODO: Open animation logic
            }
            else
            {
                // TODO: Handling for null animator
            }
        }
    }

    public void Close()
    {
        isOpen = false;
        if (animator)
        {
            // TODO: Animator closing logic
        }
        else
        {
            // TODO: Handling for null animator
        }
    }

    void Update()
    {
        if (isOpen && timeUntilClose != -1)
        {
            timer -= Time.deltaTime;

            if (timer < 0f)
            {
                Close();
            }
        }
    }

    public void Lock()
    {
        isLocked = true;
    }

    public void Unlock()
    {
        isLocked = false;
    }


}

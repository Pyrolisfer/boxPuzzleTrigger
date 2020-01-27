using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxPuzzleTrigger : MonoBehaviour
{
    public int boxPuzzle = 0;
    
    void OnTriggerEnter(Collider box) //When the box enters the correct space (measured by a trigger box) increase puzzle completion
    {

        if (box.isTrigger == true && box.CompareTag("boxPuzzleTrigger"))
        {
             //test is the name of the object that 'reacts' to the puzzle completion
            GameObject completePuzzle = GameObject.Find("test");
            boxPuzzleFinish testing = completePuzzle.GetComponent<boxPuzzleFinish>();
            testing.puzzleCompletion += 1;
            
        }

    }
    void OnTriggerExit(Collider box) //When box is no loger in position remove 'puzzleCompletion'
    {

        if (box.isTrigger == true && box.CompareTag("boxPuzzleTrigger"))
        {
            
            GameObject completePuzzle = GameObject.Find("test");
           
            boxPuzzleFinish testing = completePuzzle.GetComponent<boxPuzzleFinish>();
            testing.puzzleCompletion -= 1;

        }




    }
}




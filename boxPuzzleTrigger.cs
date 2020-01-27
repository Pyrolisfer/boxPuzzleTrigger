using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxPuzzleTrigger : MonoBehaviour
{
    public int boxPuzzle = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider box)
    {

        if (box.isTrigger == true && box.CompareTag("boxPuzzleTrigger"))
        {
            
            GameObject completePuzzle = GameObject.Find("test");
            boxPuzzleFinish testing = completePuzzle.GetComponent<boxPuzzleFinish>();
            testing.puzzleCompletion += 1;
            
        }




    }
    void OnTriggerExit(Collider box)
    {

        if (box.isTrigger == true && box.CompareTag("boxPuzzleTrigger"))
        {
            
            GameObject completePuzzle = GameObject.Find("test");
            boxPuzzleFinish testing = completePuzzle.GetComponent<boxPuzzleFinish>();
            testing.puzzleCompletion -= 1;

        }




    }
}




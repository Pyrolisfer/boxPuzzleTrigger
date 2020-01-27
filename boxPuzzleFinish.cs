using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxPuzzleFinish : MonoBehaviour
{
    
    public int puzzleCompletion = 0;
 

    
    void Update()
    {
        Debug.Log(puzzleCompletion);

        if(puzzleCompletion == 3)//when all 3 boxes are in position
        {
            Debug.Log("puzzlecomplete");
            //this can trigger the a door opening...
        }
    }
   
}



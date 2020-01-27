using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxPuzzleFinish : MonoBehaviour
{
    // Start is called before the first frame update
    public int puzzleCompletion = 0;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(puzzleCompletion);

        if(puzzleCompletion == 3)
        {
            Debug.Log("puzzlecomplete");
        }
    }
   
}



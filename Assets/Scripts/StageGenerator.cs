using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageGenerator : MonoBehaviour
{
    public int selectedNumber = 0;
    public GameObject[] StageGen;
  
    // Start is called before the first frame update
    void Start()
    {
    selectedNumber= StageController.StageNumber;
        StageGenerate(selectedNumber);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

GameObject SelectPuzzleStage(int selectedNumber){
       return  StageGen[selectedNumber -1];
   
}
    public void StageGenerate(int selectedNumber){
        GameObject Puzzlestage =(GameObject)Instantiate(
            SelectPuzzleStage(selectedNumber),
            new Vector3(0,0,0),
            Quaternion.identity
        ); 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageGenerator : MonoBehaviour
{
    public int selectedNumber = 1;
    public GameObject[] StageGen;

    public Text stageText;

    // Start is called before the first frame update

    void Start()
    {
        selectedNumber = StageController.StageNumber;
        stageText.text = "Stage" + selectedNumber.ToString();
        //StageGenerate(selectedNumber);
    }

    // Update is called once per frame
    void Update()
    {

    }

    GameObject SelectPuzzleStage(int selectedNumber)
    {
        return StageGen[selectedNumber - 1];

    }
    public void StageGenerate(int selectedNumber)
    {
        GameObject Puzzlestage = (GameObject)Instantiate(
            SelectPuzzleStage(selectedNumber),
            new Vector3(0, 0, 0),
            Quaternion.identity
        );
    }
}

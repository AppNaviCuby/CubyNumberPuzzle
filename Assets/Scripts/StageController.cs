using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageController : MonoBehaviour
{
  public static int StageNumber = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void StageSelectButtonClicked(int number)
    {
      StageNumber = number;
      SceneManager.LoadScene("Puzzle");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

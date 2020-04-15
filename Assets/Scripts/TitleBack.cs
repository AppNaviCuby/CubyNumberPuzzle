using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleBack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Onclick()
    {



        SceneManager.LoadScene("GameStart");

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

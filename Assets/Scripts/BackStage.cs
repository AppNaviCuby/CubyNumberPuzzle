﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackStage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public void Onclick()
    {



        SceneManager.LoadScene("StageSelect");

    }
    // Update is called once per frame
    void Update()
    {

    }
}

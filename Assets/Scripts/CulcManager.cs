using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class CulcManager : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> panelList = new List<GameObject>();
    public int listLongth;
    void Start()
    {
        //開始時一番下の段以外はボタンをオフに
        for(int i=0;i<7;i++)
        {
            panelList.Add(GameObject.FindGameObjectsWithTag("Line")[i]);
            for(int j=1;j<4;j++)
            {
                panelList[i].transform.Find("Row" +j).gameObject.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.3f);
                panelList[i].transform.Find("Row" +j).gameObject.GetComponent<Button>().enabled = false;
            }
        }
        listLongth = panelList.Count;
        //Debug.Log(listLongth);
        for(int j=1;j<4;j++)
        {
            panelList[listLongth-1].transform.Find("Row" +j).gameObject.GetComponent<Button>().enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnNumberClick(GameObject thisButton)
    {

        //Debug.Log("計算開始")
        Culclator culclator = new Culclator();
        culclator.Culclate(thisButton);
        //Debug.Log("計算終了");

        //押したButtonの親のLineの数値を取得
        int thisLine = int.Parse(Regex.Replace(thisButton.transform.parent.gameObject.name, @"[^0-9]", ""));

        //押した段のbuttonをオフに次の段のbuttonをオンに
        for(int j=1;j<4;j++)
        {
            panelList[thisLine -1].transform.Find("Row" +j).gameObject.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.3f);
            thisButton.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            panelList[thisLine -1].transform.Find("Row" +j).gameObject.GetComponent<Button>().enabled = false;
        }
        for(int j=1;j<4;j++)
        {
            panelList[thisLine -2].transform.Find("Row" +j).gameObject.GetComponent<Button>().enabled = true;
        }
    }

    public void OnResetClick()
    {
        for(int i=0;i<7;i++)
        {
            for(int j=1;j<4;j++)
            { 
                panelList[i].transform.Find("Row" +j).gameObject.GetComponent<Button>().enabled = true;
                panelList[i].transform.Find("Row" +j).gameObject.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.3f);
                panelList[i].transform.Find("Row" +j).gameObject.GetComponent<Button>().enabled = false;
            }
        }
        for(int j=1;j<4;j++)
        {
            panelList[listLongth-1].transform.Find("Row" +j).gameObject.GetComponent<Button>().enabled = true;
        }
        Text thisResultNumber = GameObject.Find("ResultNumber").GetComponent<Text>();
        Text thisStartNumber = GameObject.Find("StartNumber").GetComponent<Text>();
        thisResultNumber.text =thisStartNumber.text;

        //NumberSelecter numberSelecter = new NumberSelecter();
        //numberSelecter.ColorReset();
    }
}
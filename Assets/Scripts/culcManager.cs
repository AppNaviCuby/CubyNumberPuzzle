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
        for(int i=0;i<7;i++)
        {
            panelList.Add(GameObject.FindGameObjectsWithTag("Line")[i]);
            for(int j=1;j<4;j++)
            {
            panelList[i].transform.Find("Row" +j).gameObject.GetComponent<Button>().enabled = false;
            }
        }
        listLongth = panelList.Count;
        Debug.Log(listLongth);
        for(int j=1;j<4;j++)
        {
        panelList[listLongth-1].transform.Find("Row" +j).gameObject.GetComponent<Button>().enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClick(GameObject thisButton)
    {
        //押したButtonの親のLineの数値を取得
        int thisLine = int.Parse(Regex.Replace(thisButton.transform.parent.gameObject.name, @"[^0-9]", ""));

        //押した段のbuttonをオフに次の段のbuttonをオンに
        for(int j=1;j<4;j++)
        {
        panelList[thisLine -1].transform.Find("Row" +j).gameObject.GetComponent<Button>().enabled = false;
        }
        for(int j=1;j<4;j++)
        {
        panelList[thisLine -2].transform.Find("Row" +j).gameObject.GetComponent<Button>().enabled = true;
        }
    }
}
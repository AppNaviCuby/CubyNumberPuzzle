using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class CulcManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject congra;
    public List<GameObject> panelList = new List<GameObject>();
    public Text resultNumber, startNumber, goalNumber;
    public int listLongth, thisLine;
    public float culcNumber;

    void Start()
    {
        //各Numberのセット
        resultNumber = GameObject.Find("ResultNumber").gameObject.GetComponent<Text>();
        startNumber = GameObject.Find("StartNumber").gameObject.GetComponent<Text>();
        goalNumber = GameObject.Find("GoalNumber").gameObject.GetComponent<Text>();
        resultNumber.text = startNumber.text;

        //すべての段をオフに
        for (int i = 0; i < 7; i++)
        {
            panelList.Add(GameObject.FindGameObjectsWithTag("Line")[i]);
            for (int j = 1; j < 4; j++)
            {
                panelList[i].transform.Find("Row" + j).gameObject.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.3f);
                panelList[i].transform.Find("Row" + j).gameObject.GetComponent<Button>().enabled = false;
            }
        }
        listLongth = panelList.Count;
        thisLine = 7;
        //Debug.Log(listLongth);

        //一番下の段のみonに
        for (int j = 1; j < 4; j++)
        {
            panelList[listLongth - 1].transform.Find("Row" + j).gameObject.GetComponent<Button>().enabled = true;
            panelList[listLongth - 1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            //panelList[listLongth - 1].transform.Find("Now").gameObject.SetActive(true);
        }

        culcNumber = float.Parse(startNumber.text);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnNumberClick(GameObject thisButton)
    {
        if (thisLine > (7 - listLongth) / 2)
        {
            //Debug.Log("計算開始")
            Culclator culclator = new Culclator();
            culcNumber = culclator.Culclate(thisButton, culcNumber);
            //Debug.Log("計算終了");

            //押したButtonの親のLineの数値を取得
            thisLine = int.Parse(Regex.Replace(thisButton.transform.parent.gameObject.name, @"[^0-9]", ""));

            //押した段のbuttonをオフに次の段のbuttonをオンに
            for (int j = 1; j < 4; j++)
            {
                panelList[thisLine - 1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.3f);
                panelList[thisLine - 1].transform.Find("Row" + j).gameObject.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.3f);
                thisButton.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
                panelList[thisLine - 1].transform.Find("Row" + j).gameObject.GetComponent<Button>().enabled = false;
                //panelList[thisLine - 1].transform.Find("Now").gameObject.SetActive(false);
            }
            if (thisLine > (7 - listLongth) / 2 + 1)
            {
                for (int j = 1; j < 4; j++)
                {
                    panelList[thisLine - 2].transform.Find("Row" + j).gameObject.GetComponent<Button>().enabled = true;
                    panelList[thisLine - 2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
                    //panelList[thisLine - 2].transform.Find("Now").gameObject.SetActive(true);
                }
            }
            else
            {
                //最上段を押した時、resultとgoalが一致していたらお祝い
                if (resultNumber.text == goalNumber.text)
                {
                    congra.SetActive(true);
                    Debug.Log("Congratulations!!");
                }
            }
        }
    }

    public void OnResetClick()
    {
        //一番下の段以外はボタンをオフに
        for (int i = 0; i < 7; i++)
        {
            for (int j = 1; j < 4; j++)
            {
                panelList[i].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.3f);
                panelList[i].transform.Find("Row" + j).gameObject.GetComponent<Button>().enabled = true;
                panelList[i].transform.Find("Row" + j).gameObject.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.3f);
                panelList[i].transform.Find("Row" + j).gameObject.GetComponent<Button>().enabled = false;
                panelList[i].transform.Find("Now").gameObject.SetActive(false);
            }
        }
        for (int j = 1; j < 4; j++)
        {
            panelList[listLongth - 1].transform.Find("Row" + j).gameObject.GetComponent<Button>().enabled = true;
            panelList[listLongth - 1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            panelList[listLongth - 1].transform.Find("Now").gameObject.SetActive(true);
        }

        //計算を全てなかったことにしてstartNumberに戻す
        resultNumber.text = startNumber.text;
        culcNumber = float.Parse(startNumber.text);
        thisLine = listLongth;
    }

    public void OnDownButton()
    {
        if (thisLine <= listLongth)
        {
            //今onの段をoffにその一つ下の段をonに
            for (int j = 1; j < 4; j++)
            {
                if(thisLine > 1)
                {
                    panelList[thisLine - 2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.3f);
                    panelList[thisLine - 2].transform.Find("Row" + j).gameObject.GetComponent<Button>().enabled = true;
                    panelList[thisLine - 2].transform.Find("Row" + j).gameObject.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.3f);
                    panelList[thisLine - 2].transform.Find("Row" + j).gameObject.GetComponent<Button>().enabled = false;
                    panelList[thisLine - 2].transform.Find("Now").gameObject.SetActive(false);
                }

                panelList[thisLine - 1].transform.Find("Row" + j).gameObject.GetComponent<Button>().enabled = true;
                panelList[thisLine - 1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
                panelList[thisLine - 1].transform.Find("Now").gameObject.SetActive(true);

                //3つのボタンのうち、選ばれていたもので逆計算する
                float downColorA = panelList[thisLine - 1].transform.Find("Row" + j).gameObject.GetComponent<Image>().color.a;
                if (downColorA == 1.0f)
                {
                    GameObject downNumber = panelList[thisLine - 1].transform.Find("Row" + j).gameObject;
                    Culclator culclator = new Culclator();
                    culcNumber = culclator.DownCulclate(downNumber, culcNumber);
                }

                panelList[thisLine - 1].transform.Find("Row" + j).gameObject.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.3f);
            }
            thisLine++;
        }
    }
}
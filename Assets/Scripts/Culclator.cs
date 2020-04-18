using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Culclator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float Culclate(GameObject symbol, float culcNumber)
    {
        if (symbol.tag == "plus")
        {
            //Debug.Log("足し算開始");
            culcNumber = culcNumber + float.Parse(symbol.transform.Find("Number").gameObject.GetComponent<Text>().text);
            //Debug.Log("足し算終了");
        }
        if (symbol.tag == "minus")
        {
            culcNumber = culcNumber - float.Parse(symbol.transform.Find("Number").gameObject.GetComponent<Text>().text);
            //Debug.Log("引き算");
        }
        if (symbol.tag == "divid")
        {
            culcNumber = culcNumber / float.Parse(symbol.transform.Find("Number").gameObject.GetComponent<Text>().text);
            //Debug.Log("割り算");
        }
        if (symbol.tag == "multipl")
        {
            culcNumber = culcNumber * float.Parse(symbol.transform.Find("Number").gameObject.GetComponent<Text>().text);
            //Debug.Log("掛け算");
        }

        Text thisResultNumber = GameObject.Find("ResultNumber").GetComponent<Text>();
        thisResultNumber.text = "" + (int)culcNumber;

        return culcNumber;
    }

    public float DownCulclate(GameObject symbol, float culcNumber)
    {
        if (symbol.tag == "plus")
        {
            //Debug.Log("足し算開始");
            culcNumber = culcNumber - float.Parse(symbol.transform.Find("Number").gameObject.GetComponent<Text>().text);
            //Debug.Log("足し算終了");
        }
        if (symbol.tag == "minus")
        {
            culcNumber = culcNumber + float.Parse(symbol.transform.Find("Number").gameObject.GetComponent<Text>().text);
            //Debug.Log("引き算");
        }
        if (symbol.tag == "divid")
        {
            culcNumber = culcNumber * float.Parse(symbol.transform.Find("Number").gameObject.GetComponent<Text>().text);
            //Debug.Log("割り算");
        }
        if (symbol.tag == "multipl")
        {
            culcNumber = culcNumber / float.Parse(symbol.transform.Find("Number").gameObject.GetComponent<Text>().text);
            //Debug.Log("掛け算");
        }

        Text thisResultNumber = GameObject.Find("ResultNumber").GetComponent<Text>();
        thisResultNumber.text = "" + (int)culcNumber;

        return culcNumber;
    }
}

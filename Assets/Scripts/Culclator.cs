using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Culclator : MonoBehaviour
{
    public Text resultNumber,startNumber,goalNumber;
    int culcNumber ;

    // Start is called before the first frame update
    void Start()
    {
        resultNumber.text = startNumber.text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Culclate(GameObject symbol)
    {
        //Debug.Log(symbol.transform.Find("Number").gameObject.GetComponent<Text>().text);

        int thisStartNumber = int.Parse(GameObject.Find("StartNumber").gameObject.GetComponent<Text>().text);
        int culcNumber = int.Parse(GameObject.Find("ResultNumber").gameObject.GetComponent<Text>().text);
        //Debug.Log(thisStartNumber);
        //Debug.Log("タグ判別");

        if (symbol.tag == "plus")
        {
            //Debug.Log("足し算開始");
            culcNumber = culcNumber + int.Parse(symbol.transform.Find("Number").gameObject.GetComponent<Text>().text);
            //Debug.Log("足し算終了");
        }
        if (symbol.tag == "minus")
        {
            culcNumber = culcNumber - int.Parse(symbol.transform.Find("Number").gameObject.GetComponent<Text>().text);
            //Debug.Log("引き算");
        }
        if (symbol.tag == "divid")
        {
            culcNumber = culcNumber / int.Parse(symbol.transform.Find("Number").gameObject.GetComponent<Text>().text);
            //Debug.Log("割り算");
        }
        if (symbol.tag == "multipl")
        {
            culcNumber = culcNumber * int.Parse(symbol.transform.Find("Number").gameObject.GetComponent<Text>().text);
            //Debug.Log("掛け算");
        }

        Text thisResultNumber = GameObject.Find("ResultNumber").GetComponent<Text>();
        thisResultNumber.text = "" + culcNumber;
    }
}

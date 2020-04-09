using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class culcManager : MonoBehaviour
{
    public List<GameObject> panelList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {       
        for(int i=0;i<7;i++)
        {
            panelList.Add(GameObject.FindGameObjectsWithTag("Line")[i]);
            panelList[i].transform.Find("Row1").gameObject.GetComponent<Button>().enabled = false;
            panelList[i].transform.Find("Row2").gameObject.GetComponent<Button>().enabled = false;
            panelList[i].transform.Find("Row3").gameObject.GetComponent<Button>().enabled = false;
            //Debug.Log(panelList[i]);
            //Debug.Log(i +"回目");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

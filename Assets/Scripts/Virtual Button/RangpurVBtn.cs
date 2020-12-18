using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class RangpurVBtn : MonoBehaviour
{
    public GameObject RangpurVbtn;
    public GameObject Rangpur;
    public GameObject TouchPad;
    // Start is called before the first frame update
    void Start()
    {
        RangpurVbtn = GameObject.Find("Rangpur");
        RangpurVbtn.GetComponentInChildren<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        RangpurVbtn.GetComponentInChildren<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        Rangpur.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Rangpur.SetActive(true);
        Debug.Log("button pressed");
        TouchPad.SetActive(false);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Rangpur.SetActive(false);
        Debug.Log("button released");
        TouchPad.SetActive(true);
    }
}

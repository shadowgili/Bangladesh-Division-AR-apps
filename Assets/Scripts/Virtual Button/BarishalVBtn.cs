using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class BarishalVBtn : MonoBehaviour
{
    public GameObject BarishalVbtn;
    public GameObject Barishal;
    public GameObject TouchPad;

    // Start is called before the first frame update
    void Start()
    {
        BarishalVbtn = GameObject.Find("Barishal");
        BarishalVbtn.GetComponentInChildren<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        BarishalVbtn.GetComponentInChildren<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        Barishal.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Barishal.SetActive(true);
        Debug.Log("button pressed");
        TouchPad.SetActive(false);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Barishal.SetActive(false);
        Debug.Log("button released");
        TouchPad.SetActive(true);
    }
}

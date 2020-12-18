using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class DhakaVBtn : MonoBehaviour
{
    public GameObject DhakaVbtn;
    public GameObject Dhaka;
    public GameObject TouchPad;

    // Start is called before the first frame update
    void Start()
    {
        DhakaVbtn = GameObject.Find("Dhaka");
        DhakaVbtn.GetComponentInChildren<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        DhakaVbtn.GetComponentInChildren<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        Dhaka.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Dhaka.SetActive(true);
        Debug.Log("button pressed");
        TouchPad.SetActive(false);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Dhaka.SetActive(false);
        Debug.Log("button released");
        TouchPad.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class RajshahiVBtn : MonoBehaviour
{
    public GameObject RajshahiVbtn;
    public GameObject Rajshahi;
    public GameObject TouchPad;

    // Start is called before the first frame update
    void Start()
    {
        RajshahiVbtn = GameObject.Find("Rajshahi");
        RajshahiVbtn.GetComponentInChildren<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        RajshahiVbtn.GetComponentInChildren<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        Rajshahi.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Rajshahi.SetActive(true);
        Debug.Log("button pressed");
        TouchPad.SetActive(false);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Rajshahi.SetActive(false);
        Debug.Log("button released");
        TouchPad.SetActive(true);
    }
}

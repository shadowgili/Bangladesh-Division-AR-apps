using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class KhulnaVBtn : MonoBehaviour
{
    public GameObject KhulnaVbtn;
    public GameObject Khulna;
    public GameObject TouchPad;

    // Start is called before the first frame update
    void Start()
    {
        KhulnaVbtn = GameObject.Find("Khulna");
        KhulnaVbtn.GetComponentInChildren<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        KhulnaVbtn.GetComponentInChildren<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        Khulna.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Khulna.SetActive(true);
        Debug.Log("button pressed");
        TouchPad.SetActive(false);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Khulna.SetActive(false);
        Debug.Log("button released");
        TouchPad.SetActive(true);
    }
}

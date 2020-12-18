using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class MymensinghVBtn : MonoBehaviour
{
    public GameObject MymensinghVbtn;
    public GameObject Mymensingh;
    public GameObject TouchPad;

    // Start is called before the first frame update
    void Start()
    {
        MymensinghVbtn = GameObject.Find("Mymensingh");
        MymensinghVbtn.GetComponentInChildren<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        MymensinghVbtn.GetComponentInChildren<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        Mymensingh.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Mymensingh.SetActive(true);
        Debug.Log("button pressed");
        TouchPad.SetActive(false);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Mymensingh.SetActive(false);
        Debug.Log("button released");
        TouchPad.SetActive(true);
    }
}

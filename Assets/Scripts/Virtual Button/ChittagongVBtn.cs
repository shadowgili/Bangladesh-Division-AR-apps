using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class ChittagongVBtn : MonoBehaviour
{
    public GameObject ChittagongVbtn;
    public GameObject Chittagong;
    public GameObject TouchPad;

    // Start is called before the first frame update
    void Start()
    {
        ChittagongVbtn = GameObject.Find("Chittagong");
        ChittagongVbtn.GetComponentInChildren<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        ChittagongVbtn.GetComponentInChildren<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        Chittagong.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Chittagong.SetActive(true);
        Debug.Log("button pressed");
        TouchPad.SetActive(false);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Chittagong.SetActive(false);
        Debug.Log("button released");
        TouchPad.SetActive(true);
    }
}

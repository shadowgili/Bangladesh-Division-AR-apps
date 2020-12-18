using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SylhetVBtn : MonoBehaviour
{
    public GameObject SylhetVbtn;
    public GameObject Sylhet;
    public GameObject TouchPad;

    // Start is called before the first frame update
    void Start()
    {
        SylhetVbtn = GameObject.Find("Sylhet");
        SylhetVbtn.GetComponentInChildren<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        SylhetVbtn.GetComponentInChildren<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        Sylhet.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Sylhet.SetActive(true);
        Debug.Log("button pressed");
        TouchPad.SetActive(false);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Sylhet.SetActive(false);
        Debug.Log("button released");
        TouchPad.SetActive(true);
    }
}

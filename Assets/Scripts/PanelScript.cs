using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelScript : MonoBehaviour
{
    public Transform ScanPanel;
    public Transform PanelMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenURL()
    {
        Application.OpenURL("https://drive.google.com/file/d/1wv85KYxRAfp3q-P1L1wRCoREVkj7Tt9t/view?usp=sharing");
    }
    public void ExitBtn()
    {
        Application.Quit();
    }
    private void OnTrackingFound()
    {
        ScanPanel.gameObject.SetActive(false);
        PanelMenu.gameObject.SetActive(true);
    }
    private void OnTrackingLost()
    {
        ScanPanel.gameObject.SetActive(true);
        PanelMenu.gameObject.SetActive(false);
    }
}

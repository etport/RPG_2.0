using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSettingsTab : MonoBehaviour
{
    public GameObject GeneralSettings;
    public GameObject HeadSettings;
    public GameObject FaceSettings;
    public GameObject BodySettings;

    List<GameObject> settingsWindows = new List<GameObject>(); 

    void Start()
    {
        settingsWindows.Add(GeneralSettings);
        settingsWindows.Add(HeadSettings);
        settingsWindows.Add(FaceSettings);
        settingsWindows.Add(BodySettings); 
    }

    public void ShowSettingsWindow(GameObject panel)
    {
        if (panel.activeInHierarchy == false)
        {
            panel.SetActive(true);
        }

        foreach (GameObject window in settingsWindows)
        {
            if (window != panel)
            {
                window.SetActive(false);
            }
        }
    }

}

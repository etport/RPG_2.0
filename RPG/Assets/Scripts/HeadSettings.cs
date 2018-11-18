using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI; 

public class HeadSettings : MonoBehaviour {


    public GameObject Hairstyle;
    public GameObject HairColor;
    public GameObject Head;
    public GameObject Neck;
    public GameObject JawHeight;
    public GameObject JawWidth;

    Slider hairStyle;
    Slider hairColor;
    Slider headSize;
    Slider neckSize;
    Slider jawHeight;
    Slider jawWidth;

    AppearanceChangeEvents.ChangeHairStyle changeHairStyle = new AppearanceChangeEvents.ChangeHairStyle();
    AppearanceChangeEvents.ChangeHairColor changeHairColor = new AppearanceChangeEvents.ChangeHairColor();
    AppearanceChangeEvents.ChangeHeadSize changeHeadSize = new AppearanceChangeEvents.ChangeHeadSize();
    AppearanceChangeEvents.ChangeNeckSize changeNeckSize = new AppearanceChangeEvents.ChangeNeckSize();
    AppearanceChangeEvents.ChangeJawHeight changeJawHeight = new AppearanceChangeEvents.ChangeJawHeight();
    AppearanceChangeEvents.ChangeJawWidth changeJawWidth = new AppearanceChangeEvents.ChangeJawWidth(); 

	// Use this for initialization
	void Start ()
    {
        hairStyle = Hairstyle.GetComponentInChildren<Slider>(); 	
        hairColor = HairColor.GetComponentInChildren<Slider>();
        headSize = Head.GetComponentInChildren<Slider>();
        neckSize = Neck.GetComponentInChildren<Slider>();
        jawHeight = JawHeight.GetComponentInChildren<Slider>();
        jawWidth = JawWidth.GetComponentInChildren<Slider>();

        CharacterCreationEventManager.AddHeadInvoker(this); 
    }

    public void ChangeHairStyle()
    {
        changeHairStyle.Invoke(Mathf.RoundToInt(hairStyle.value));
    }

    public void ChangeHairColor()
    {
        changeHairColor.Invoke(Mathf.RoundToInt(hairColor.value)); 
    }

    public void ChangeHeadSize()
    {
        changeHeadSize.Invoke(headSize.value);
    }

    public void ChangeNeckSize()
    {
        changeNeckSize.Invoke(neckSize.value); 
    }

    public void ChangeJawHeight()
    {
        changeJawHeight.Invoke(jawHeight.value);
    }

    public void ChangeJawWidth()
    {
        changeJawWidth.Invoke(jawWidth.value); 
    }
    #region Event Management Methods

    public void AddHairStyleListener (UnityAction<int> handler)
    {
        changeHairStyle.AddListener(handler); 
    }

    public void AddHairColorListener (UnityAction<int> handler)
    {
        changeHairColor.AddListener(handler); 
    }

    public void AddHeadSizeListener (UnityAction<float> handler)
    {
        changeHeadSize.AddListener(handler); 
    }

    public void AddNeckSizeListener (UnityAction<float> handler)
    {
        changeNeckSize.AddListener(handler); 
    }

    public void AddJawHeightListener (UnityAction<float> handler)
    {
        changeJawHeight.AddListener(handler);
    }

    public void AddJawWidthListener (UnityAction<float> handler)
    {
        changeJawWidth.AddListener(handler);
    }
    #endregion 
}

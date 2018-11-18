using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class GeneralSettings : MonoBehaviour {

    public GameObject Name;
    public GameObject Gender;
    public GameObject Height;
    public GameObject SkinColor;

    InputField characterName;
    Dropdown gender;
    Slider height;
    Slider skinColor;

    AppearanceChangeEvents.ChangeName changeName = new AppearanceChangeEvents.ChangeName();
    AppearanceChangeEvents.ChangeGender changeGender = new AppearanceChangeEvents.ChangeGender();
    AppearanceChangeEvents.ChangeHeight changeHeight = new AppearanceChangeEvents.ChangeHeight();
    AppearanceChangeEvents.ChangeSkinColor changeSkinColor = new AppearanceChangeEvents.ChangeSkinColor(); 
    
    // Use this for initialization
	void Start ()
    {
        characterName = Name.GetComponentInChildren<InputField>();
        gender = Gender.GetComponentInChildren<Dropdown>();
        height = Height.GetComponentInChildren<Slider>();
        skinColor = SkinColor.GetComponentInChildren<Slider>();

        CharacterCreationEventManager.AddGeneralInvoker(this); 
     
	}
	
    public void ChangeName()
    {
        
        changeName.Invoke(characterName.text); 
    }

    public void ChangeGender()
    {
        if (gender.value == 0)
        {
            changeGender.Invoke(true); 
        }
        else
        {
            changeGender.Invoke(false); 
        }
    }

    public void ChangeHeight()
    {
        changeHeight.Invoke(height.value); 
    }

    public void ChangeSkinColor()
    {
        int colorIndex  = Mathf.RoundToInt(skinColor.value);
        changeSkinColor.Invoke(colorIndex); 
    }

    #region Event Management Events

    public void AddNameChangeListener(UnityAction<string> handler)
    {
        changeName.AddListener(handler); 
    }
    public void AddGenderChangeListener(UnityAction<bool> handler)
    {
        changeGender.AddListener(handler);
    }
    public void AddHeightChangeListener(UnityAction<float> handler)
    {
        changeHeight.AddListener(handler);
    }
    public void AddSkinColorListener(UnityAction<int> handler)
    {
        changeSkinColor.AddListener(handler);
    }
    #endregion
}

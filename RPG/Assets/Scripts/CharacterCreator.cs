using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UMA;
using UMA.CharacterSystem; 

public class CharacterCreator : MonoBehaviour {

    DynamicCharacterAvatar avatar;
    Dictionary<string, DnaSetter> dna;
    string characterName;
    
    public Color[] skinColors;
    public UMAWardrobeRecipe[] maleHairStyles;
    public UMAWardrobeRecipe[] femaleHairStyles;
    int currentStyle; 


	// Use this for initialization
	void Start ()
    {
        avatar = gameObject.GetComponent<DynamicCharacterAvatar>();
        dna = new Dictionary<string, DnaSetter>();

        CharacterCreationEventManager.AddNameChangeListener(ChangeName);
        CharacterCreationEventManager.AddGenderChangeListener(ChangeGender);
        CharacterCreationEventManager.AddHeightChangeListener(ChangeHeight);
        CharacterCreationEventManager.AddSkinColorChangeListener(ChangeSkinColor);

        CharacterCreationEventManager.AddHairStyleListener(ChangeHairStyle); 

	}
    #region General

    void ChangeName(string name)
    {
        characterName = name;
        gameObject.name = characterName; 
    }

    void ChangeGender(bool male)
    {
        if (male && avatar.activeRace.name != "HumanMaleDCS")
        {
            avatar.ChangeRace("HumanMaleDCS");
            ChangeHairStyle(currentStyle);
        }

        if (!male && avatar.activeRace.name != "HumanFemaleDCS")
        {
            avatar.ChangeRace("HumanFemaleDCS");
            ChangeHairStyle(currentStyle); 
        }

        avatar.BuildCharacter(); 
    }

    void ChangeHeight(float height)
    {
        dna = avatar.GetDNA();
        dna["height"].Set(height);
        avatar.BuildCharacter(); 
    }

    void ChangeSkinColor(int index)
    {
        avatar.SetColor("Skin", skinColors[index]);
        avatar.UpdateColors(true); 
    }

#endregion

    void ChangeHairStyle(int styleIndex)
    {
        currentStyle = styleIndex; 
        if (avatar.activeRace.name == "HumanMaleDCS")
        {
            avatar.SetSlot("Hair", maleHairStyles[styleIndex].name);
        }
        else
        {
            avatar.SetSlot("Hair", femaleHairStyles[styleIndex].name); 
        }

        avatar.BuildCharacter();
    }

    void ChangeHairColor(int colorIndex)
    {

    }
       
}

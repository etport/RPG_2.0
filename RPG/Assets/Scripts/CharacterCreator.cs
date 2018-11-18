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

	// Use this for initialization
	void Start ()
    {
        avatar = gameObject.GetComponent<DynamicCharacterAvatar>();
        dna = new Dictionary<string, DnaSetter>();

        CharacterCreationEventManager.AddNameChangeListener(ChangeName);
        CharacterCreationEventManager.AddGenderChangeListener(ChangeGender);
        CharacterCreationEventManager.AddHeightChangeListener(ChangeHeight);
        CharacterCreationEventManager.AddSkinColorChangeListener(ChangeSkinColor); 
	}
	
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
        }

        if (!male && avatar.activeRace.name != "HumanFemaleDCS")
        {
            avatar.ChangeRace("HumanFemaleDCS"); 
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
}

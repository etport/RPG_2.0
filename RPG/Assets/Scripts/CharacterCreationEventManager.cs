using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class CharacterCreationEventManager
{
    static GeneralSettings generalInvoker;
    static UnityAction<string> nameChangeListener;
    static UnityAction<bool> genderChangeListener;
    static UnityAction<float> heightChangeListener;
    static UnityAction<int> skinColorListener; 

    public static void AddGeneralInvoker(GeneralSettings script)
    {
        generalInvoker = script;
        if (nameChangeListener != null)
        {
            generalInvoker.AddNameChangeListener(nameChangeListener); 
        }
        if (genderChangeListener != null)
        {
            generalInvoker.AddGenderChangeListener(genderChangeListener);
        }
        if (heightChangeListener != null)
        {
            generalInvoker.AddHeightChangeListener(heightChangeListener);
        }
        if (skinColorListener != null)
        {
            generalInvoker.AddSkinColorListener(skinColorListener);
        }
    }

    public static void AddNameChangeListener(UnityAction<string> listener)
    {
        nameChangeListener = listener; 
        if (generalInvoker != null)
        {
            generalInvoker.AddNameChangeListener(nameChangeListener); 
        }
    }

    public static void AddGenderChangeListener(UnityAction<bool> listener)
    {
        genderChangeListener = listener; 
        if  (generalInvoker != null)
        {
            generalInvoker.AddGenderChangeListener(genderChangeListener); 
        }
    }

    public static void AddHeightChangeListener(UnityAction<float> listener)
    {
        heightChangeListener = listener; 
        if (generalInvoker != null)
        {
            generalInvoker.AddHeightChangeListener(heightChangeListener); 
        }
    }

    public static void AddSkinColorChangeListener(UnityAction<int> listener)
    {
        skinColorListener = listener;
        if (generalInvoker != null)
        {
            generalInvoker.AddSkinColorListener(skinColorListener); 
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class CharacterCreationEventManager
{

    #region General Events
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

    #endregion

    #region Head Events

    static HeadSettings headInvoker;
    static UnityAction<int> hairStyleListener;
    static UnityAction<int> hairColorListener;
    static UnityAction<float> headSizeListener;
    static UnityAction<float> neckSizeListener;
    static UnityAction<float> jawHeightListener;
    static UnityAction<float> jawWidthListener; 

    public static void AddHeadInvoker(HeadSettings invoker)
    {
        headInvoker = invoker; 
        if (hairStyleListener != null)
        {
            headInvoker.AddHairStyleListener(hairStyleListener);
        }

        if (hairColorListener != null)
        {
            headInvoker.AddHairColorListener(hairColorListener);
        }

        if (headSizeListener != null)
        {
            headInvoker.AddHeadSizeListener(headSizeListener);
        }

        if (neckSizeListener != null)
        {
            headInvoker.AddNeckSizeListener(neckSizeListener);
        }

        if (jawHeightListener != null)
        {
            headInvoker.AddJawHeightListener(jawHeightListener);
        }

        if (jawWidthListener != null)
        {
            headInvoker.AddJawWidthListener(jawWidthListener); 
        }
    }

    public static void AddHairStyleListener(UnityAction<int> listener)
    {
        hairStyleListener = listener; 
        if (headInvoker != null)
        {
            headInvoker.AddHairStyleListener(hairStyleListener);
        }
    }


    public static void AddHairColorListener(UnityAction<int> listener)
    {
        hairColorListener = listener;
        if (headInvoker != null)
        {
            headInvoker.AddHairColorListener(hairColorListener);
        }
    }

    public static void AddHeadSizeListener(UnityAction<float> listener)
    {
        headSizeListener = listener;
        if (headInvoker != null)
        {
            headInvoker.AddHeadSizeListener(headSizeListener);
        }
    }

    public static void AddNeckSizeListener(UnityAction<float> listener)
    {
        neckSizeListener = listener;
        if (headInvoker != null)
        {
            headInvoker.AddNeckSizeListener(neckSizeListener);
        }
    }

    public static void AddJawHeightListener(UnityAction<float> listener)
    {
        jawHeightListener = listener;
        if (headInvoker != null)
        {
            headInvoker.AddJawHeightListener(jawHeightListener);
        }
    }

    public static void AddJawWidthListener(UnityAction<float> listener)
    {
        jawWidthListener = listener;
        if (headInvoker != null)
        {
            headInvoker.AddJawWidthListener(jawWidthListener);
        }
    }
    #endregion
}

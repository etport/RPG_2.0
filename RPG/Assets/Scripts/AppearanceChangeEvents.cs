using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 

namespace AppearanceChangeEvents
{
    #region General
    public class ChangeName : UnityEvent<string>
    {
    }

    public class ChangeGender : UnityEvent<bool>
    {
    }

    public class ChangeHeight : UnityEvent<float>
    {
    }

    public class ChangeSkinColor : UnityEvent<int>
    {
    }
    #endregion

    #region Head

    public class ChangeHairStyle: UnityEvent<int>
    {
    }

    public class ChangeHairColor: UnityEvent<int>
    {
    }

    public class ChangeHeadSize : UnityEvent<float>
    {
    }

    public class ChangeNeckSize : UnityEvent<float>
    {
    }

    public class ChangeJawHeight : UnityEvent<float>
    {
    }

    public class ChangeJawWidth : UnityEvent<float>
    {
    }

    #endregion

    #region Face

    #endregion

    #region Body

    #endregion

}

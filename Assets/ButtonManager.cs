using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    /**
     * 武器を選んだボタン
     */
    public static bool isButton_1;
    public static bool isButton_2;
    public static bool isButton_3;

    public bool isButtonProperty_1
    {
        set
        {
            isButton_1 = value;
        }

        get
        {
            return isButton_1;
        }
    }

    public bool isButtonProperty_2
    {
        set
        {
            isButton_2 = value;
        }

        get
        {
            return isButton_2;
        }
    }

    public bool isButtonProperty_3
    {
        set
        {
            isButton_3 = value;
        }

        get
        {
            return isButton_3;
        }
    }

}

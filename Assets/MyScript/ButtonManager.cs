using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * ボタンが押されたかどうかを他のクラスから参照するためのデータセット
 * 外部クラスから参照するときは，Propertyを用いること．
 *
 * isButton_1のProperty: isButtonProperty_1
 * isButton_2のProperty: isButtonProperty_2
 * isButton_3のProperty: isButtonProperty_3
 *
 * #武器を追加するときはpublic staticで変数を宣言し，Propertyを作成してください．
 * 
 */

public class ButtonManager : MonoBehaviour
{
    /**
     * 武器を選ぶためのボタン
     * 
     * isButton_1: 武器１
     * isButton_2: 武器２
     * isButton_3: 武器３
     * 
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

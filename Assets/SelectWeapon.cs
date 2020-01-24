using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectWeapon : MonoBehaviour
{
    /**
     * 武器を選ぶためのボタン
     */
    Button button_1;
    Button button_2;
    Button button_3;

    /**
     * 武器を選んだボタン
     */

    public bool isButton_1 = false;
    public bool isButton_2 = false;
    public bool isButton_3 = false;

    // Start is called before the first frame update
    void Start()
    {
        // ボタンのコンポーネントを取得
        button_1 = GameObject.Find("/Canvas/Button_1").GetComponent<Button>();
        button_2 = GameObject.Find("/Canvas/Button_2").GetComponent<Button>();
        button_3 = GameObject.Find("/Canvas/Button_3").GetComponent<Button>();

        // 最初にButtan_1を選択状態にする．
        //button_1.Select();

    }

    // Update is called once per frame
    void Update()
    {
        if (isButton_1)
		{

		}

        if (isButton_2)
		{

		}

        if (isButton_3)
		{

		}
        
    }
}

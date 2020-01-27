using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeEquip : MonoBehaviour
{
    ButtonManager buttonManager = new ButtonManager();

    [SerializeField]
    private GameObject[] weapons;

    /**
     * 配列weaponsに武器を格納する．
     * 
     * 0: Cube
     * 1: Sphere
     * 2: Cylinder
     * 
     * #現在セットされているオブジェクト
     *
     * #.SetActiveは
     * 
     * false: 武器を持たない
     * true: 武器を持たせる
     * 
     */
    void Start()
    {
        weapons[0].SetActive(false);
        weapons[1].SetActive(false);
        weapons[2].SetActive(false);
    }

    void Update()
    {
        if (buttonManager.isButtonProperty_1)
		{
            weapons[0].SetActive(true);
            weapons[1].SetActive(false);
            weapons[2].SetActive(false);
        }

        if (buttonManager.isButtonProperty_2)
		{
            weapons[0].SetActive(false);
            weapons[1].SetActive(true);
            weapons[2].SetActive(false);
        }

        if (buttonManager.isButtonProperty_3)
		{
            weapons[0].SetActive(false);
            weapons[1].SetActive(false);
            weapons[2].SetActive(true);
        }
    }
}

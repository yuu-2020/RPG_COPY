using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeEquip : MonoBehaviour
{

    /**
     * 武器を選んだボタン
     */
    public bool isButton_1 = false;
    public bool isButton_2 = false;
    public bool isButton_3 = false;

    [SerializeField]
    private GameObject[] weapons;

    ChangeButton button = new ChangeButton();


    // Start is called before the first frame update
    void Start()
    {
        weapons[0].SetActive(false);
        weapons[0].SetActive(false);
        weapons[0].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        Debug.Log("1" + isButton_1);
        Debug.Log("2" + isButton_2);
        Debug.Log("3" + isButton_3);
        */

        Debug.Log("debug:" + button.debug);

        if (isButton_1)
		{
            weapons[0].SetActive(true);
            weapons[0].SetActive(false);
            weapons[0].SetActive(false);
        }

        if (isButton_2)
		{
            weapons[0].SetActive(false);
            weapons[0].SetActive(true);
            weapons[0].SetActive(false);
        }

        if (isButton_3)
		{
            weapons[0].SetActive(false);
            weapons[0].SetActive(false);
            weapons[0].SetActive(true);
        }
    }
}

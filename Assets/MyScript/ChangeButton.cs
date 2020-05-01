using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeButton : MonoBehaviour
{
  ButtonManager buttonManager = new ButtonManager();

  void Start()
  {
    buttonManager.isButtonProperty_1 = true;
    buttonManager.isButtonProperty_2 = false;
    buttonManager.isButtonProperty_3 = false;
  }

  /**
   * ボタンがクリックされたときに呼び出されるメソッド
   *
   * num: 押されたボタンを判別する．
   * 0: 武器１
   * 1: 武器２
   * 2: 武器３
   *
   */
  public void OnClick(int num)
  {
    switch (num)
    {
      case 0:
        buttonManager.isButtonProperty_1 = true;
        buttonManager.isButtonProperty_2 = false;
        buttonManager.isButtonProperty_3 = false;
        break;
      case 1:
        buttonManager.isButtonProperty_1 = false;
        buttonManager.isButtonProperty_2 = true;
        buttonManager.isButtonProperty_3 = false;
        break;
      case 2:
        buttonManager.isButtonProperty_1 = false;
        buttonManager.isButtonProperty_2 = false;
        buttonManager.isButtonProperty_3 = true;
        break;
      default:
        break;
    }
    Debug.Log("Debug");
  }
}

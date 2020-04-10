using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //定義欄位(Field 宣告變數)
    //修飾詞 類型 名稱;
    //public 公開 : 顯示在屬性面板
    //GameObject 遊戲物件 : 儲存階層面板內的物件
    /// <summary>
    /// 燈光群組
    /// </summary>
    [Header("燈光群組")]
    public GameObject GroupLight;
    [Header("磁力衣櫃xD")]
    public Transform Wardrobe;


    //定義方法(Method) : 有特定內容的功能
    //修飾詞 傳回類型 方法名稱(){敘述}
    //void 無傳回 : 使用此方法不會得到任何資料
    /// <summary>
    /// 燈光閃爍效果
    /// </summary>
    public IEnumerator LightEffect()
    //IEnumerator 延遲傳回 
    //協同程序 : 多線程程式處理方式
    {
        GroupLight.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        GroupLight.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        GroupLight.SetActive(false);
        yield return new WaitForSeconds(0.4f);
        GroupLight.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        GroupLight.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        GroupLight.SetActive(true);
    }
    private void Start() 
    {
        LightEffect();
        StartCoroutine(LightEffect());
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListController : MonoBehaviour
{
    public List<int> numList = new List<int>();

    void Start()
    {
        // ListSizeConf();
        // ListIndex2Conf();
        // ListAllDataConf();
        // ItemAdd();
        // ItemRemoveAt();
        
    }
    
    /// <summary>
    /// Listのサイズ確認
    /// </summary>
    void ListSizeConf() {
        Debug.Log(numList.Count);
    }

    /// <summary>
    /// Listの要素3番目の中身を確認
    /// </summary>
    void ListIndex2Conf() {
        Debug.Log(numList[2]);
    }

    /// <summary>
    /// Listの中身すべて確認
    /// </summary>
    void ListAllDataConf() {
        for(int i = 0; i < numList.Count; i++) {
            Debug.Log(numList[i]);
        }
    }

    /// <summary>
    /// Listの最後に値を追加
    /// </summary>
    void ItemAdd() {
        numList.Add(100);
        //listの最後に新しく箱を作りつつその中身を100にする
    }
    
    /// <summary>
    /// リストの要素を削除
    /// </summary>
    void ItemRemoveAt() {
        numList.RemoveAt(2);
        //RemoveAtの括弧の中に削除した箱の番号指定するとその箱が削除される
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

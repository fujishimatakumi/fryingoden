using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class OderCreatoer : MonoBehaviour
{
    [SerializeField] int _maxOder;
    [SerializeField] Image[] _imageIcons;
    OdenData[] _datas;
   

    public void CreateOder(int oderNum)
    {
        _datas = new OdenData[oderNum];
        //OdenType列挙型を取得
        var types = Enum.GetValues(typeof(OdenType));
        for (int i = 0; i < oderNum; i++)
        {
            int typeIndex = UnityEngine.Random.Range(0, (int)OdenType.max);
            _datas[i] = new OdenData((OdenType)types.GetValue(typeIndex));
        }
        //imageの更新処理
        for (int i = 0; i < _datas.Length; i++)
        {
            _imageIcons[i].sprite = _datas[i].ImageIcon;
        }
    }

    

}

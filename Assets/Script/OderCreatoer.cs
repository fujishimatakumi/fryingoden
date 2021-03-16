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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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

    public bool CheckOder(OdenData[] datas)
    {
        for (int i = 0; i < datas.Length; i++)
        {
            if (_datas[i].Type != datas[i].Type)
            {
                return false;
            }
        }
        return true;
    }

}

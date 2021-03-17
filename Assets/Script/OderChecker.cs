using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OderChecker : MonoBehaviour
{

    OdenData[] _datas;

    public void SetDatas(OdenData[] datas)
    {
        _datas = new OdenData[datas.Length];
        for (int i = 0; i < datas.Length; i++)
        {
            _datas[i] = datas[i];
        }
    }

    public bool IsOderSucces(OdenData[] datas)
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

    public void CheckOder(OdenData[] oder)
    {
        if (IsOderSucces(oder))
        {
            GetComponent<GameManager>().AddScore(100);
        }
        else
        {
            GetComponent<GameManager>().AddScore(-100);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OdenData
{
    const string spritePass = "flyingOden_gu";
    OdenType _type;
    Sprite _imageIcon;

    public OdenData(OdenType type)
    {
        _type = type;
        Sprite[] sprites = Resources.LoadAll<Sprite>(spritePass);
        foreach (var item in sprites)
        {
            if (item.name == spritePass)
            {
                _imageIcon = item;
                break;
            }
        }
    }

    public OdenType Type => _type;

    public Sprite ImageIcon => _imageIcon;
}

public enum OdenType
{ 
    konnyaku,
    daikon,
    hanpen,
    max
}

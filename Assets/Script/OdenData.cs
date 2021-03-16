using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OdenData
{
    OdenType _type;
    Sprite _imageIcon;

    public OdenData(OdenType type)
    {
        _type = type;
        _imageIcon = Resources.Load<Sprite>(type.ToString());
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

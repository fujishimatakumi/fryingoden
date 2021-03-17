using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaController : MonoBehaviour
{
    Vector3 _zRivision;
    CursorStatus _status;
    List<OdenData> _odenDatas;

    public List<OdenData> OdenDatas => _odenDatas;
    // Start is called before the first frame update
    void Start()
    {
        _odenDatas = new List<OdenData>();
        DisableCursor();
        _zRivision = new Vector3(0, 0, 10);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CursorChange();
    }

    private void Move()
    {
        this.gameObject.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + _zRivision;
    }

    private void CursorChange()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && _status is CursorStatus.diseable)
        {
            EnubleCursor();
        }
        if (Input.GetButtonDown("Fire1") && _status is CursorStatus.enuble)
        {
            DisableCursor();
        }
    }

    private void EnubleCursor()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        _status = CursorStatus.enuble;
    }

    private void DisableCursor()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
        _status = CursorStatus.diseable;
    }

    public OdenData[] ToArry()
    {
        OdenData[] odenDataArry = _odenDatas.ToArray();
        _odenDatas.Clear();
        return odenDataArry;
    }
}

public enum CursorStatus
{ 
    enuble,
    diseable
}
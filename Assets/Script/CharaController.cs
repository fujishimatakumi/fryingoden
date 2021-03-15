using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaController : MonoBehaviour
{
    Vector3 zRivision;
    CursorStatus status;
    // Start is called before the first frame update
    void Start()
    {
        DisableCursor();
        zRivision = new Vector3(0, 0, 10);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CursorChange();
    }

    private void Move()
    {
        this.gameObject.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + zRivision;
    }

    private void CursorChange()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && status is CursorStatus.diseable)
        {
            EnubleCursor();
        }
        if (Input.GetButtonDown("Fire1") && status is CursorStatus.enuble)
        {
            DisableCursor();
        }
    }

    private void EnubleCursor()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        status = CursorStatus.enuble;
    }

    private void DisableCursor()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
        status = CursorStatus.diseable;
    }
}

public enum CursorStatus
{ 
    enuble,
    diseable
}
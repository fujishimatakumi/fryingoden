using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(SpriteRenderer))]
public class OdenObjectController : MonoBehaviour
{
    OdenData data;
    // Start is called before the first frame update
    void Start()
    {
        var types = Enum.GetValues(typeof(OdenType));
        int index =  UnityEngine.Random.Range(0, (int)OdenType.max);
        data = new OdenData((OdenType)types.GetValue(index));
        gameObject.GetComponent<SpriteRenderer>().sprite = data.ImageIcon;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CharaController controller;
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.gameObject.TryGetComponent(out controller))
            {
                //プレイヤーに接触した場合の処理を書く
            }
        }
    }
}

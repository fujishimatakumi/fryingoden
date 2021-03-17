using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(SpriteRenderer))]
public class OdenObjectController : MonoBehaviour
{
    [SerializeField] bool _reverceMoveDirecthon;
    [SerializeField] float _moveSpeed;
    OdenData _data;
    // Start is called before the first frame update
    void Start()
    {
        var types = Enum.GetValues(typeof(OdenType));
        int index =  UnityEngine.Random.Range(0, (int)OdenType.max);
        _data = new OdenData((OdenType)types.GetValue(index));
        gameObject.GetComponent<SpriteRenderer>().sprite = _data.ImageIcon;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (!_reverceMoveDirecthon)
        {
            gameObject.transform.Translate(Vector3.down * _moveSpeed);
        }
        else
        {
            gameObject.transform.Translate(Vector3.up * _moveSpeed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CharaController controller;
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.gameObject.TryGetComponent(out controller))
            {
                //プレイヤーに接触した場合の処理を書く
                controller.OdenDatas.Add(_data);
                Destroy(gameObject);
            }
        }
        else if (collision.gameObject.CompareTag("Destroyer"))
        {
            Destroy(gameObject);
        }
    }
}

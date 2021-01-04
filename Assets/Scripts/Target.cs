using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;
    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(Vector3.up * Random.Range(12, 16), ForceMode.Impulse);//給予物品隨機向上的力量
        targetRb.AddTorque(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10), ForceMode.Impulse);//增加物品旋轉的扭力
        transform.position = new Vector3(Random.Range(-4, 4), -6);//隨機選擇位置(對x軸)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

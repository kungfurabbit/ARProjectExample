using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosiv : MonoBehaviour {
    public GameObject exp;
    public GameObject destObj;
    private void OnTriggerEnter(Collider other)
    {
        print("exp");
        exp.gameObject.SetActive(true);
        Destroy(destObj);
    }
}

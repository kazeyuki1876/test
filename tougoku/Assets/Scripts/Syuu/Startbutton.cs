using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startbutton : MonoBehaviour
{
    void Start() {
        this.GetComponent<Button>().onClick.Addlistener(Clickme);
    }
    void Clickme()
    {
        Debug.Log("開始ボタン");
    }
}

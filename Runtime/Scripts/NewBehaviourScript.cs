using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CSharpTest;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    void Start()
    {
        Class1 test = new Class1();
        test.showText(text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

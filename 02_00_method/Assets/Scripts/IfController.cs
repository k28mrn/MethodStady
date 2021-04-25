using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IfController : MonoBehaviour
{
    // Inputフィールドを制御するための変数を準備
    public InputField inputA;
    public InputField inputB;

    public GameObject sphere;

    float scale = 1;
    // Start is called before the first frame update
    void Start()
    {
        //SetScale();
    }

    // Update is called once per frame
    void Update()
    {
        if (inputA.text == "" || inputB.text == "") {
            sphere.SetActive(false);
        } else if (inputA.text != "" && inputB.text != "") {
            sphere.SetActive(true);
            int a = 0;
            int b = 0;
            if (int.TryParse(inputA.text, out a) && int.TryParse(inputB.text, out b)) {
                Material material = sphere.GetComponent<Renderer>().material;
                material.color = Color.blue;
                if ((a+b) >= 10) {
                    // sphere.transform.localScale = new Vector3(5, 5, 5);
                    scale = 5;
                } else {
                    // sphere.transform.localScale = new Vector3(1, 1, 1);
                    scale = 1;
                }
                float currentScale = sphere.transform.localScale.x;
                float setScale = currentScale + ((scale - currentScale) * 0.125f);
                Debug.Log(setScale);
                sphere.transform.localScale = new Vector3(setScale, setScale, setScale);
            }
        }
    }

    void SetScale() {
        transform.localScale = new Vector3(2f, 2f, 3f);
    }
}

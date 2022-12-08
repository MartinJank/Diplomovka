using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomButtonNumbers : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI btn1;
    [SerializeField] private TextMeshProUGUI btn2;
    [SerializeField] private TextMeshProUGUI btn3;
    [SerializeField] private TextMeshProUGUI payed;
    [SerializeField] private TextMeshProUGUI price;

    // Start is called before the first frame update
    void Start()
    {
        btn1.text = "" + Random.Range(0, int.Parse(payed.text));
        btn2.text = "" + Random.Range(0, int.Parse(payed.text));
        btn3.text = "" + Random.Range(0, int.Parse(payed.text));

        int randomIndex = Random.Range(0, 2);
        if (randomIndex == 0)
        {
            btn1.text = "" + (int.Parse(payed.text) - int.Parse(price.text));
        }
        if (randomIndex == 1)
        {
            btn2.text = "" + (int.Parse(payed.text) - int.Parse(price.text));
        }
        if (randomIndex == 2)
        {
            btn3.text = "" + (int.Parse(payed.text) - int.Parse(price.text));
        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomizeAmounts : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI payed;
    [SerializeField] private TextMeshProUGUI price;
    [SerializeField] private TMP_InputField result;
    // Start is called before the first frame update
    private int[] numbers = { 20, 50, 100, 200, 500 };

    private void Start()
    {
        int randomIndex = Random.Range(0, 4);

        int payed_amount = numbers[randomIndex];
        int price_amount = Random.Range(0, payed_amount);

        payed.text = "" + payed_amount;
        price.text = "" + price_amount;
    }
    public void Check()
    {

        int randomIndex = Random.Range(0, 4);

        int payed_amount = numbers[randomIndex];
        int price_amount = Random.Range(0, payed_amount);

        Debug.Log(int.Parse(result.text));

        if (int.Parse(payed.text) - int.Parse(price.text) == int.Parse(result.text))
        {
            payed.text = "" + payed_amount;
            price.text = "" + price_amount;
            ++GameControl.control.money;
        }

    }
}

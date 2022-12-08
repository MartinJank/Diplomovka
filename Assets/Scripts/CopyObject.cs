using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CopyObject : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI original;
    [SerializeField] private TextMeshProUGUI copy;

    void Update()
    {
        copy.text = original.text;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveButton : MonoBehaviour
{
    [SerializeField] private Button studyButton;

    public void move()
    {
        float x = Random.Range(-340.0f, 340.0f);
        float y = Random.Range(-175.0f, 150.0f);
        RectTransform picture = studyButton.GetComponent<RectTransform>();
        picture.anchoredPosition = new Vector2(x, y);
    }
}

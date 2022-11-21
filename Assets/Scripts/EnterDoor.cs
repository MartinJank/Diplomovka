using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EnterDoor : MonoBehaviour
{
    [SerializeField] private string playerTag;
    [SerializeField] private string scene;
    // [SerializeField] private TextMeshProUGUI displayExp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D otherObject) {
        if (otherObject.gameObject.tag == playerTag)
        {
            Debug.Log("colison");
            SceneManager.LoadScene(scene);
            // displayExp.text = "Experience: " + GameControl.control.exp;
        }
    }


}

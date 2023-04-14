using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectsInsideMinigame : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Vector3 minPosition;
    public Vector3 maxPosition;
    public float interval = 2;
    float timer;
    // void Start() 
    // { 
    //     // Creates an object with a random rotation
    //     Instantiate(objectToSpawn, transform.position, Quaternion.identity); 
    // }
    // // Update is called once per frame
    void Update()
    {

        // if (Input.GetMouseButtonDown(0)) {

        //     // Debug.Log("Cube");
        //     Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //     RaycastHit hit;

        //     if(Physics.Raycast(ray, out hit, 100.0f) && hit.transform.gameObject != null) {
        //         Debug.DrawRay (ray.origin, hit.point);
        //         Debug.Log(hit.transform.name);

        //         Destroy(GameObject.Find("Square(Clone)"));
        //     }

        // }

        timer += Time.deltaTime;
        if (timer >= interval)
        {
            Vector3 randomPosition = new Vector3(
                Random.Range(minPosition.x, maxPosition.x),
                Random.Range(minPosition.y, maxPosition.y),
                Random.Range(minPosition.z, maxPosition.z)
            );
            GameObject go = Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
            Vector3 euler = go.transform.eulerAngles;
            euler.z = Random.Range(0f, 360f);
            go.transform.eulerAngles = euler;
            Destroy(go, 3);
            timer -= interval;
        }
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}

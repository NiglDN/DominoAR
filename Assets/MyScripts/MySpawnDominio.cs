using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySpawnDominio : MonoBehaviour
{
    public GameObject[] dominos;
    private int currentDominoIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        currentDominoIndex = Random.Range(0, dominos.Length - 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnObject();
        }
    }

    // spawns a domino at the position of the current Gameobject
    void SpawnObject()
    {
        shuffleDomino();
        // TODO: fix rotation
        Instantiate(dominos[currentDominoIndex], new Vector3(transform.position.x, 0, transform.position.z), new Quaternion(90, transform.rotation.y, 0, -90));
    }

    // change current selected Domino
    private void shuffleDomino()
    {
        currentDominoIndex++;
        if (currentDominoIndex >= dominos.Length )
        {
            currentDominoIndex = 0;
        }
    }
}

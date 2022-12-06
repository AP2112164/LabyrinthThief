using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public GameObject prefab;
    public int howMany;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject tmpBlueGem;
        //Gems am;

        //for (int i = 0; i < howMany; i++) 
        //{
        //    tmpBlueGem = Instantiate(
        //        prefab, new Vector3(Random.Range(-4, 4), 0), Quaternion.identity
        //        );

        //    am = tmpBlueGem.GetComponent<Gems>();

        //    am.mx = Random.Range(-5, 5);
        //    am.my = Random.Range(5, -5);
        //   // am.rotz = Random.Range(-5, 5);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(this.gameObject);

        if (FindObjectsOfType(this.GetType()).Length > 1)
        {
            Destroy(this.gameObject);
        }
    }
}

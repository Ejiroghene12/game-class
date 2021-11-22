using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicCheckPopulated : MonoBehaviour
{
    public GameObject Tile1;
    public GameObject Tile2;
    public GameObject Tile3;
    public GameObject Tile4;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement playerStats = player.GetComponent<Movement>();
        IsPopulatedScript tile1Logic = Tile1.GetComponent<IsPopulatedScript>();
        IsPopulatedScript tile2Logic = Tile2.GetComponent<IsPopulatedScript>();
        IsPopulatedScript tile3Logic = Tile3.GetComponent<IsPopulatedScript>();
        IsPopulatedScript tile4Logic = Tile4.GetComponent<IsPopulatedScript>();
        if (tile1Logic.isPopulated == true && tile2Logic.isPopulated == true && tile3Logic.isPopulated == true && tile4Logic.isPopulated == true)
        {
            playerStats.contro = true;
        }
        else
        {
            playerStats.contro = false;
        }

    }
}

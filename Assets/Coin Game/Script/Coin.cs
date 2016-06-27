using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

    public static int CoinCount = 0; //Total # of Coins in Scene
    public static GameObject[] Coins;

    void Start() {

        //Debug.Log("Object Created");
        Coins = GameObject.FindGameObjectsWithTag("Coin");
        CoinCount = Coins.Length;

    }

    void Update() {

        Coins = GameObject.FindGameObjectsWithTag("Coin");
        CoinCount = Coins.Length;
        Collection();
    }

    void Collection() {

        if(CoinCount <= 0) {
            Debug.Log("You Won!!");
        }
    }

}

using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

    [SerializeField]
    private float CountDown = 0;

    public float MaxTime = 60f;
	// Use this for initialization
	void Start () {

        CountDown = MaxTime;
	
	}
	
	// Update is called once per frame
	void Update () {

        CountDown -= Time.deltaTime;

        if(CountDown <= 0) {

            Coin.CoinCount = 0;
            Application.LoadLevel(Application.loadedLevel);
        }
	
	}
}

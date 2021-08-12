using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public Player player;
    public GameObject playerPrefab;
    public GameObject playerObject;
    void Start()
    {
        playerObject = Instantiate (playerPrefab, new Vector3(0,0.2f,0), new Quaternion(0,0,0,0));
        player = playerObject.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.isDead == true){
            //Debug.Log("Game over player is dead");
            Destroy(playerObject);

        }
    }
}

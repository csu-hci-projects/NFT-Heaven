using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] Text deathText;
    int deathCount = 0;
    MeshRenderer meshRenderer;
    Vector3 startingPosition;
    bool dead = false;
    // Start is called before the first frame update
    void Start()
    {
       startingPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        meshRenderer = gameObject.GetComponent<MeshRenderer>();
        if(!dead && transform.position.y < -2f){
            death();
            death();
        }
        
    }
    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "Obstacle"){
            death();
        }
        
    }

    void death(){
        meshRenderer.enabled = false;
        GetComponent<PlayerMovement>().enabled = false;
        Debug.Log(startingPosition);
        dead = true;
        deathCount += 1;
        deathText.text = "Deaths: " + deathCount / 2;
        Invoke(nameof(respawn), 1f);
    }
    void respawn(){
        meshRenderer.enabled = true;
        GetComponent<PlayerMovement>().enabled = true;
        GetComponent<Transform>().position = startingPosition;
        dead = false;
    }
}

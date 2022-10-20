using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentCoin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var sr = GetComponent<SpriteRenderer>();
        sr.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key was pressed.");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Space key was released.");
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            transform.Translate(1,1,0);
        }

        if (Input.GetKeyUp(KeyCode.N))
        {
            var clone = Instantiate(this);
            clone.transform.position = new Vector3(Random.Range(-2,2),Random.Range(-2,2),0);
        }
    }
}

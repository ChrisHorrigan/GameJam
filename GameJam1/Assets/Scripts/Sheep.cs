using UnityEngine;
using System.Collections;

public class Sheep : MonoBehaviour {
    NavMeshAgent agent;
	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        StartCoroutine(RandomMovement());
	}
    IEnumerator RandomMovement()
    {
        Vector3 toMove;
        yield return new WaitForSeconds(Random.Range(1f, 3f));
        toMove.y = 0;
        toMove.x = Random.Range(-1f, 1f);
        toMove.z = Random.Range(-1f, 1f);
        agent.SetDestination(transform.position + toMove);
       
        StartCoroutine(RandomMovement());

    }
    public void GetWhistled()
    {
        StopCoroutine(RandomMovement());
    }
	// Update is called once per frame
	void Update () {
	
	}
}

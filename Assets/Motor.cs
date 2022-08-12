using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor : MonoBehaviour
{

    [SerializeField] private Brain aiBrain;
    [SerializeField] private float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        aiBrain = GetComponent<Brain>();
    }

    // Update is called once per frame
    public void MoveTowardsPlayerCharacter()
    {
        transform.position = Vector3.MoveTowards(transform.position, aiBrain.playerCharacter.transform.position, moveSpeed * Time.deltaTime);
    }

    public void MoveAwayFromPlayerCharacter()
    {
        transform.position = Vector3.MoveTowards(transform.position, aiBrain.playerCharacter.transform.position, -moveSpeed * Time.deltaTime);
    }
}

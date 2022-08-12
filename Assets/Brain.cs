using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brain : MonoBehaviour
{
    public GameObject playerCharacter;
    public enum AIState {
    /// <summary>
    /// Nothing Just yet. Not even default.
    /// </summary>
        Undefined, 
    /// <summary>
    /// Not Moving
    /// </summary>
        Idle, 
    /// <summary>
    /// Running after the player
    /// </summary>
        Chasing, 
    /// <summary>
    /// Running away from the player
    /// </summary>
        Fleeing}
    [SerializeField] private AIState state = AIState.Undefined;
    [SerializeField] private Motor motor;
    // Start is called before the first frame update
    void Start()
    {
        state = AIState.Idle;
        motor = GetComponent<Motor>();

    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case AIState.Undefined:
                break;
            case AIState.Idle:
                break;
            case AIState.Chasing:
                //wanna move towards
                motor.MoveTowardsPlayerCharacter();
                break;
            case AIState.Fleeing:
                //wanna move away
                motor.MoveAwayFromPlayerCharacter();
                break;
            default:
                break;
        }


    }
}

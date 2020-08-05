using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    //Distance between player and camera horizontally
    public float xOffset = 0f;
    //Distance between player and camera vertically
    public float yOffset = 0f;

    public Transform player;

    private void LateUpdate()
    {
        this.transform.position = new Vector3(player.transform.position.x + xOffset, this.transform.position.y + yOffset, -10);
    }
}

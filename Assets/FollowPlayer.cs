using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 trailingCamera;
    public Vector3 facing;

    Vector3 CalculateTrailingCamera(Vector3 target, Vector3 rotation)
    {
        Vector3 maxDrag = 2, 0, 8;
        Vector3 cameraPosition;

        cameraPosition.x = 

        return cameraPosition;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = CalculateTrailingCamera(player.position, facing);
    }
}

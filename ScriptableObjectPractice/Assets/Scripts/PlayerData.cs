using UnityEngine;
[CreateAssetMenu]
public class PlayerData : ScriptableObject
{
    public string playerName;

    public int jumpCount = 0,
        jumpCountMax = 1;

    public float moveSpeed = 10f,
        gravity = 3f,
        jumpSpeed = 30f;
}


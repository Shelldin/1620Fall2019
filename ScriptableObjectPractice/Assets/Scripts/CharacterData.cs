using UnityEngine;
[CreateAssetMenu]
public class CharacterData : ScriptableObject
{
    public string characterName;

    public int jumpCount = 0,
        jumpCountMax = 1;

    public float moveSpeed = 10f;

    public float gravity = 3f,
        jumpSpeed = 30f;

    public void UpdateJumpMax(int amount)
    {
        jumpCountMax += amount;
    }

    public void UpdateMoveSpeed(float amount)
    {
        moveSpeed += amount;
    }

    public void UpdateGravity(float amount)
    {
        gravity += amount;
    }

    public void UpdateJumpSpeed(float amount)
    {
        jumpSpeed += amount;
    }
}


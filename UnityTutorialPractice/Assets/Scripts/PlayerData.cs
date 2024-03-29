﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class PlayerData : GameArtData
{
    public int jumpCount = 0,
        jumpCountMax = 2;

    public float moveSpeed = 10f,
        jumpSpeed = 25f,
        gravity = 3f;

    public void InstancePlayer()
    {
        var newPlayer = Instantiate(prefab);
        var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
        newSprite.sprite = sprite;
        newSprite.color = color;
    }

    public void UpdateJumpMax(int amount)
    {
        jumpCountMax += amount;
    }

    public void UpdateMoveSpeed(float amount)
    {
        moveSpeed += amount;
    }

    public void UpdateJumpSpeed(float amount)
    {
        jumpSpeed += amount;
    }
}

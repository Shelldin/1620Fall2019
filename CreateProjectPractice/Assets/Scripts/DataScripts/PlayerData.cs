﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class PlayerData : GameArtData
{
    public List<WeaponData> weapons;
    public FloatData health;
    public ClothesData shirt;
    public ClothesData pants;

    public void InstancePlayer()
    {
        var newPlayer = Instantiate(prefab);
        var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
        //giving me a error but not sure what is wrong will investigate 
        //newSprite.sprite = sprite;
        //newSprite.color = color;
    }
}

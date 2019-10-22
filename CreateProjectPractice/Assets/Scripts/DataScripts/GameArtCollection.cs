using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]

public class GameArtCollection : ScriptableObject

{
    public List<GameArtData> collectionList;

    public void AddData(GameArtData obj)
    {
        if(!obj.collected)
        {
            collectionList.Add(obj);
            obj.collected = true;
        }
    }
}

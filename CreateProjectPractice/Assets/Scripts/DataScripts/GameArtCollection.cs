using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]

public class GameArtCollection : ScriptableObject

{
    public List<GameArtData> collectionList;

    public void AddData(GameArtData obj)
    {
        if (!collectionList.Contains(obj))
        {
            collectionList.Add(obj);
        }
        
        //foreach (var gameArt in collectionList)
        {
            //  Debug.Log(gameArt);   
        }
        
        //  for (var i = 0; i < collectionList.Count; i++)
        {
          //  if (collectionList[i] == obj)
          {
              //    collectionList.Add(obj);
          }
        }
        
        
    }
}

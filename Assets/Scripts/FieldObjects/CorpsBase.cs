using UnityEngine;
using System.Collections.Generic;
using SpiritsAlternative;

public abstract class CorpsBase<T> : MovableObject where T : PieceBase
{
    [SerializeField] private GameObject piecePrefab;

    protected List<T> pieces = new List<T>();

    public virtual T[] Appear(int appearCount = 1)
    {
        List<T> appearPieces = new List<T>();
        for(int i = 0;i < appearCount; ++i)
        {
            T piece = Util.InstantiateTo<T>(this.gameObject, piecePrefab);
            appearPieces.Add(piece);
        }
        pieces.AddRange(appearPieces);
        return appearPieces.ToArray();
    }
}

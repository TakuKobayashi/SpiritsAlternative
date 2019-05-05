using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPiece : PieceBase
{
    public EnemyPieceModel DataModel { private set; get; }

    public void Init(EnemyPieceModel pieceModel)
    {
        DataModel = pieceModel;
    }
}

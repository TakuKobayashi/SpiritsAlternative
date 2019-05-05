using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPiece : PieceBase
{
    public PlayerPieceModel DataModel { private set; get; }

    public void Init(PlayerPieceModel pieceModel)
    {
        DataModel = pieceModel;
    }
}

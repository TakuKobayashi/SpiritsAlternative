using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCorps : CorpsBase<PlayerPiece>
{
    public void Init(params PlayerPieceModel[] models)
    {
        PlayerPiece[] players = this.Appear(models.Length);
        for (int i = 0; i < players.Length; ++i)
        {
            players[i].Init(models[i]);
        }
    }
}

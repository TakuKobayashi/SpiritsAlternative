using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCorps : CorpsBase<EnemyPiece>
{
    public void Init(params EnemyPieceModel[] models)
    {
        EnemyPiece[] enemies = this.Appear(models.Length);
        for(int i = 0;i < enemies.Length; ++i)
        {
            enemies[i].Init(models[i]);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

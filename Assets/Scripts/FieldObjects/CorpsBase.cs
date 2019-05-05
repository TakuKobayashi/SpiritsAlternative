using UnityEngine;
using System.Collections.Generic;

public abstract class CorpsBase<T> : FieldObject where T : PieceBase
{
    protected List<T> pieces = new List<T>();
}

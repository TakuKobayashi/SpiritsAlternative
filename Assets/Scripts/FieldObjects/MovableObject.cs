using UnityEngine;
using System.Collections;

public abstract class MovableObject : FieldObject
{
    protected Vector3 targetPosition = Vector3.zero;

    public void TargetTo(Vector3 targetTo)
    {
        targetPosition = targetTo;
    }

    protected virtual IEnumerator MoveTo(float reachedTime)
    {
        Vector3 beforePosition = this.transform.position;
        float second = 0;
        while (second < reachedTime)
        {
            this.transform.position = Vector3.Lerp(beforePosition, targetPosition, second / reachedTime);
            second += Time.deltaTime;
            yield return null;
        }
    }
}

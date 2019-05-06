using UnityEngine;
using System.Collections;

public abstract class MovableObject : FieldObject
{
    protected Vector3 targetPosition = Vector3.zero;
    protected ActionState State = ActionState.Idle;
    [SerializeField] protected float Speed = 1f;

    public virtual void TargetTo(Vector3 targetTo)
    {
        targetPosition = targetTo;
        this.transform.LookAt(targetPosition);
        State = ActionState.Targeting;
    }

    protected virtual IEnumerator MoveRoutine()
    {
        Vector3 beforePosition = this.transform.position;
        float reachedTime = CalcReachedSecond();
        float second = 0;
        while (true)
        {
            if(State == ActionState.Targeting)
            {
                beforePosition = this.transform.position;
                reachedTime = CalcReachedSecond();
                second = 0f;
                State = ActionState.Moving;
            }
            if(State == ActionState.Moving)
            {
                this.transform.position = Vector3.Lerp(beforePosition, targetPosition, second / reachedTime);
                second += Time.deltaTime;
                if(second >= reachedTime)
                {
                    this.transform.position = targetPosition;
                    second = reachedTime;
                    State = ActionState.Idle;
                }
            }
            yield return null;
        }
    }

    protected virtual float CalcReachedSecond()
    {
        Vector3 diff = this.transform.position - targetPosition;
        if(Speed == 0f)
        {
            return 0f;
        }
        else
        {
            return diff.sqrMagnitude / Speed;
        }
    }
}

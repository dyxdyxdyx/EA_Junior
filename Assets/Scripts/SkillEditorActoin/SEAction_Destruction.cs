using UnityEngine;

public class SEAction_Destruction : SEAction_BaseAction
{
    public override void TrigAction()
    {
        base.TrigAction();
        Destroy(gameObject);
    }
}

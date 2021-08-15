using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace AttTypeDefine{
    public delegate void NotifySkill();

    public enum eTrigType
    {
        eAuto = 0,
        eCondition,
    };
    public enum eTrigSkillState
    {
        eTrigBegin,
        eTrigEnd,
    };
    
    public enum eSkillType
    {
        eAttack = 0,
        eSkill1
    };

    public class GameEvent : UnityEvent { };
    public class GameBtnEvent : UnityEvent<PointerEventData> { };
}
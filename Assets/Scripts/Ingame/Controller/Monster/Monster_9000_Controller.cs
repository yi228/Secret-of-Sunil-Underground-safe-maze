using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_9000_Controller : MonsterController
{
    GameObject portal;
    protected override void Init()
    {
        base.Init();
        _monsterType = Define.MonsterType.Rush;
        portal = GameObject.FindWithTag("Portal");
        portal.SetActive(false);

        Gold = 100;
    }
    void Start()
    {
        Init();
    }
    void Update()
    {
        base.UpdateController();
    }
    // TODO
    protected override void UpdateMoving()
    {
        SetDir();
        switch (Dir)
        {
            case Define.MoveDir.Left:
                transform.rotation = Quaternion.Euler(0, 0, 0);
                tr_HpSlider.rotation = Quaternion.Euler(0, 0, 0);
                anim.Play($"MONSTER_{Id}_IDLE_MOVE");
                break;
            case Define.MoveDir.Right:
                transform.rotation = Quaternion.Euler(0, 180, 0);
                tr_HpSlider.rotation = Quaternion.Euler(0, 0, 0);
                anim.Play($"MONSTER_{Id}_IDLE_MOVE");
                break;
        }
    }
    protected override void OnDead(float time = 0f)
    {
        // TODO - 다음 레벨 디자인 해야 함
        //Managers.Room.StageLevel++;
        portal.SetActive(true);
        base.OnDead(time);
    }
    protected override void OnCollisionStay2D(Collision2D collision)
    {
        base.OnCollisionStay2D(collision);
    }
}

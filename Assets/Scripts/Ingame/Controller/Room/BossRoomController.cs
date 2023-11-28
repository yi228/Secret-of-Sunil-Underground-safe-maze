using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossRoomController : RoomController
{
    public MonsterController Boss;
    void Start()
    {
        Init();
    }
    public override void Init()
    {
        base.Init();
        RoomType = Define.RoomType.Boss;
        InitBossMonster();
    }
    void InitBossMonster()
    {
        Boss = Managers.Spawn.SpawnBossMonster(this, MiddlePoint, Define.MonsterType.Rush);
    }
    public override void StageClear()
    {
        base.StageClear();
    }
}

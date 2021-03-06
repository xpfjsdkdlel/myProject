using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameData
{
    // 인게임
    public static GameObject selectBlock; // 선택된 블록
    public static bool isClear = false; // 스테이지를 클리어 한 상태 여부

    // 게임 데이터
    public static int selectStage = 1; // 현재 선택한 스테이지
    public static int clearStage = 1; // 클리어한 스테이지 수 
    public static int totalStage = 10; // 최대 스테이지수
    public static int money; // 게임내 재화
    public static void Reset()
    {
        isClear = false;
    }
}

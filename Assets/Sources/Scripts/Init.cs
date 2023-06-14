using UnityEngine;

public class Init : MonoBehaviour
{
    public PlayerData playerData;
}

[System.Serializable]
public class PlayerData
{
    public int CoinsValue = 1000;
    public int Level;
    public float MaxHealthCount = 10;
    public float UpLevelBonusCoinsValue = 200;
    public float LastExperienceCount =0;
}

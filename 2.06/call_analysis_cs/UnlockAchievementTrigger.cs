using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UnlockAchievementTrigger : MonoBehaviour
{
	private Achievement m_Achievement;

	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "IsUnlocked")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public UnlockAchievementTrigger()
	{
	}
}

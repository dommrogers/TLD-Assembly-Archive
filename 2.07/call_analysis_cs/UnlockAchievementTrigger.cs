using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UnlockAchievementTrigger : MonoBehaviour
{
	private Achievement m_Achievement;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "IsUnlocked")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UnlockAchievementTrigger()
	{
	}
}

using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UnlockAchievementTrigger : MonoBehaviour
{
	private Achievement m_Achievement;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "IsUnlocked")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UnlockAchievementTrigger()
	{
	}
}

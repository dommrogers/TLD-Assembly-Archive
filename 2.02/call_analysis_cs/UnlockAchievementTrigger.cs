using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UnlockAchievementTrigger : MonoBehaviour
{
	private Achievement m_Achievement;

	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "IsUnlocked")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public UnlockAchievementTrigger()
	{
	}
}

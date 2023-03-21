using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;
using UnityPlugin;

namespace DataPlatform;

public class AchievementsManagerPlugin
{
	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool AchievementsManager_QueryAchievementsForTitleIdAsync(uint titleId, string strXboxUserId, ObjectResultCallback callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool AchievementsManager_GetAchievementsForTitleIdAsync(int userId, string strXboxUserId, uint titleId, AchievementType type, bool unlockedOnly, AchievementOrderBy orderBy, uint skipItems, uint maxItems, ObjectResultCallback callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool AchievementsManager_GetAchievementAsync(int userId, string xboxUserId, string serviceConfigurationId, string achievementId, ObjectResultCallback callback, IntPtr userData);

	[PreserveSig]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static extern bool AchievementsManager_LaunchAchievementsUIAsync(uint userId, uint titleId, GenericActionCallback callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern void AchievementsManager_RegisterForUnlockNotifications(ObjectResultCallback callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void AchievementsManager_UnRegisterForUnlockNotifications();

	[PreserveSig]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static extern bool AchievementsManager_UpdateAchievementAsync(int userId, string xboxUserId, string achievementId, uint percentComplete, GenericActionCallback callback, IntPtr userData);

	[PreserveSig]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static extern bool AchievementsManager_UpdateAchievementFullAsync(int userId, string xboxUserId, uint titleId, string serviceConfigurationId, string achievementId, uint percentComplete, GenericActionCallback callback, IntPtr userData);

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public AchievementsManagerPlugin()
	{
	}
}

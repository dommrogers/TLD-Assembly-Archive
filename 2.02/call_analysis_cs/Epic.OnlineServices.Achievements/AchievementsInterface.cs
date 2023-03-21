using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

public sealed class AchievementsInterface : Handle
{
	public const int AchievementUnlocktimeUndefined = -1;

	public const int AddnotifyachievementsunlockedApiLatest = 1;

	public const int Addnotifyachievementsunlockedv2ApiLatest = 2;

	public const int Copyachievementdefinitionv2ByachievementidApiLatest = 2;

	public const int Copyachievementdefinitionv2ByindexApiLatest = 2;

	public const int CopydefinitionbyachievementidApiLatest = 1;

	public const int CopydefinitionbyindexApiLatest = 1;

	public const int Copydefinitionv2ByachievementidApiLatest = 2;

	public const int Copydefinitionv2ByindexApiLatest = 2;

	public const int CopyplayerachievementbyachievementidApiLatest = 1;

	public const int CopyplayerachievementbyindexApiLatest = 1;

	public const int CopyunlockedachievementbyachievementidApiLatest = 1;

	public const int CopyunlockedachievementbyindexApiLatest = 1;

	public const int DefinitionApiLatest = 1;

	public const int Definitionv2ApiLatest = 2;

	public const int GetachievementdefinitioncountApiLatest = 1;

	public const int GetplayerachievementcountApiLatest = 1;

	public const int GetunlockedachievementcountApiLatest = 1;

	public const int PlayerachievementApiLatest = 2;

	public const int PlayerstatinfoApiLatest = 1;

	public const int QuerydefinitionsApiLatest = 2;

	public const int QueryplayerachievementsApiLatest = 1;

	public const int StatthresholdApiLatest = 1;

	public const int StatthresholdsApiLatest = 1;

	public const int UnlockachievementsApiLatest = 1;

	public const int UnlockedachievementApiLatest = 1;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public AchievementsInterface()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AchievementsInterface(IntPtr innerHandle)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AddNotifyAchievementsUnlockedOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryAssignNotificationIdToCallback")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public ulong AddNotifyAchievementsUnlocked(AddNotifyAchievementsUnlockedOptions options, object clientData, OnAchievementsUnlockedCallback notificationFn)
	{
		return 0uL;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AddNotifyAchievementsUnlockedV2OptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryAssignNotificationIdToCallback")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public ulong AddNotifyAchievementsUnlockedV2(AddNotifyAchievementsUnlockedV2Options options, object clientData, OnAchievementsUnlockedCallbackV2 notificationFn)
	{
		return 0uL;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyAchievementDefinitionByAchievementIdOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(AchievementsInterface), Member = "EOS_Achievements_Definition_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyAchievementDefinitionByAchievementId(CopyAchievementDefinitionByAchievementIdOptions options, out Definition outDefinition)
	{
		outDefinition = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyAchievementDefinitionByIndexOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(AchievementsInterface), Member = "EOS_Achievements_Definition_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyAchievementDefinitionByIndex(CopyAchievementDefinitionByIndexOptions options, out Definition outDefinition)
	{
		outDefinition = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyAchievementDefinitionV2ByAchievementIdOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(AchievementsInterface), Member = "EOS_Achievements_DefinitionV2_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyAchievementDefinitionV2ByAchievementId(CopyAchievementDefinitionV2ByAchievementIdOptions options, out DefinitionV2 outDefinition)
	{
		outDefinition = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyAchievementDefinitionV2ByIndexOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(AchievementsInterface), Member = "EOS_Achievements_DefinitionV2_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyAchievementDefinitionV2ByIndex(CopyAchievementDefinitionV2ByIndexOptions options, out DefinitionV2 outDefinition)
	{
		outDefinition = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyPlayerAchievementByAchievementIdOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(AchievementsInterface), Member = "EOS_Achievements_PlayerAchievement_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyPlayerAchievementByAchievementId(CopyPlayerAchievementByAchievementIdOptions options, out PlayerAchievement outAchievement)
	{
		outAchievement = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyPlayerAchievementByIndexOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(AchievementsInterface), Member = "EOS_Achievements_PlayerAchievement_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyPlayerAchievementByIndex(CopyPlayerAchievementByIndexOptions options, out PlayerAchievement outAchievement)
	{
		outAchievement = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyUnlockedAchievementByAchievementIdOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(AchievementsInterface), Member = "EOS_Achievements_UnlockedAchievement_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyUnlockedAchievementByAchievementId(CopyUnlockedAchievementByAchievementIdOptions options, out UnlockedAchievement outAchievement)
	{
		outAchievement = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyUnlockedAchievementByIndexOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(AchievementsInterface), Member = "EOS_Achievements_UnlockedAchievement_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyUnlockedAchievementByIndex(CopyUnlockedAchievementByIndexOptions options, out UnlockedAchievement outAchievement)
	{
		outAchievement = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetAchievementDefinitionCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public uint GetAchievementDefinitionCount(GetAchievementDefinitionCountOptions options)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetPlayerAchievementCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public uint GetPlayerAchievementCount(GetPlayerAchievementCountOptions options)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetUnlockedAchievementCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public uint GetUnlockedAchievementCount(GetUnlockedAchievementCountOptions options)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryDefinitionsOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public void QueryDefinitions(QueryDefinitionsOptions options, object clientData, OnQueryDefinitionsCompleteCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryPlayerAchievementsOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public void QueryPlayerAchievements(QueryPlayerAchievementsOptions options, object clientData, OnQueryPlayerAchievementsCompleteCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryRemoveCallbackByNotificationId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveNotifyAchievementsUnlocked(ulong inId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnlockAchievementsOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public void UnlockAchievements(UnlockAchievementsOptions options, object clientData, OnUnlockAchievementsCompleteCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnAchievementsUnlockedCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnAchievementsUnlockedCallbackV2InternalImplementation(IntPtr data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnQueryDefinitionsCompleteCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnQueryPlayerAchievementsCompleteCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnUnlockAchievementsCompleteCallbackInternalImplementation(IntPtr data)
	{
	}

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern ulong EOS_Achievements_AddNotifyAchievementsUnlocked(IntPtr handle, IntPtr options, IntPtr clientData, OnAchievementsUnlockedCallbackInternal notificationFn);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern ulong EOS_Achievements_AddNotifyAchievementsUnlockedV2(IntPtr handle, IntPtr options, IntPtr clientData, OnAchievementsUnlockedCallbackV2Internal notificationFn);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Achievements_CopyAchievementDefinitionByAchievementId(IntPtr handle, IntPtr options, ref IntPtr outDefinition);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Achievements_CopyAchievementDefinitionByIndex(IntPtr handle, IntPtr options, ref IntPtr outDefinition);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Achievements_CopyAchievementDefinitionV2ByAchievementId(IntPtr handle, IntPtr options, ref IntPtr outDefinition);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Achievements_CopyAchievementDefinitionV2ByIndex(IntPtr handle, IntPtr options, ref IntPtr outDefinition);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Achievements_CopyPlayerAchievementByAchievementId(IntPtr handle, IntPtr options, ref IntPtr outAchievement);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Achievements_CopyPlayerAchievementByIndex(IntPtr handle, IntPtr options, ref IntPtr outAchievement);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Achievements_CopyUnlockedAchievementByAchievementId(IntPtr handle, IntPtr options, ref IntPtr outAchievement);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Achievements_CopyUnlockedAchievementByIndex(IntPtr handle, IntPtr options, ref IntPtr outAchievement);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern uint EOS_Achievements_GetAchievementDefinitionCount(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern uint EOS_Achievements_GetPlayerAchievementCount(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern uint EOS_Achievements_GetUnlockedAchievementCount(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Achievements_QueryDefinitions(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryDefinitionsCompleteCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Achievements_QueryPlayerAchievements(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryPlayerAchievementsCompleteCallbackInternal completionDelegate);

	[PreserveSig]
	[CalledBy(Type = typeof(AchievementsInterface), Member = "CopyAchievementDefinitionV2ByAchievementId")]
	[CalledBy(Type = typeof(AchievementsInterface), Member = "CopyAchievementDefinitionV2ByIndex")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Achievements_DefinitionV2_Release(IntPtr achievementDefinition);

	[PreserveSig]
	[CalledBy(Type = typeof(AchievementsInterface), Member = "CopyPlayerAchievementByAchievementId")]
	[CalledBy(Type = typeof(AchievementsInterface), Member = "CopyPlayerAchievementByIndex")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Achievements_PlayerAchievement_Release(IntPtr achievement);

	[PreserveSig]
	[CalledBy(Type = typeof(AchievementsInterface), Member = "CopyAchievementDefinitionByAchievementId")]
	[CalledBy(Type = typeof(AchievementsInterface), Member = "CopyAchievementDefinitionByIndex")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Achievements_Definition_Release(IntPtr achievementDefinition);

	[PreserveSig]
	[CalledBy(Type = typeof(AchievementsInterface), Member = "CopyUnlockedAchievementByAchievementId")]
	[CalledBy(Type = typeof(AchievementsInterface), Member = "CopyUnlockedAchievementByIndex")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Achievements_UnlockedAchievement_Release(IntPtr achievement);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Achievements_RemoveNotifyAchievementsUnlocked(IntPtr handle, ulong inId);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Achievements_UnlockAchievements(IntPtr handle, IntPtr options, IntPtr clientData, OnUnlockAchievementsCompleteCallbackInternal completionDelegate);
}

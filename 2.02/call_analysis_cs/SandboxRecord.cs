using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.SceneManagement;

[Serializable]
public class SandboxRecord
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<CairnInfo> _003C_003E9__22_0;

		public static Comparison<AuroraScreenInfo> _003C_003E9__23_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal int _003CStoreCairnCollectibles_003Eb__22_0(CairnInfo x, CairnInfo y)
		{
			return default(int);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "CompareTo")]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CStoreAuroraScreenCollectibles_003Eb__23_0(AuroraScreenInfo x, AuroraScreenInfo y)
		{
			return default(int);
		}
	}

	public string m_SandboxName;

	public float m_ElapsedHours;

	public DateTime m_EndDate;

	public GameRegion m_StartRegion;

	public string m_EndRegion;

	public ExperienceModeType m_ExperienceModeType;

	public VoicePersona m_VoicePersona;

	public string m_CauseOfDeathLocId;

	public string m_GeneralNotes;

	public List<LogDayInfo> m_LogDayInfoList;

	public List<LogListItem> m_CollectibleList;

	public List<string> m_CollectibleNotesList;

	public List<CairnInfo> m_CollectibleCairnInfoList;

	public List<AuroraScreenInfo> m_CollectibleAuroraScreenInfoList;

	public StatContainer m_Stats;

	[Calls(Type = typeof(SandboxRecord), Member = "StoreNoteCollectibles")]
	[Calls(Type = typeof(SandboxRecord), Member = "StoreCairnCollectibles")]
	[CallsUnknownMethods(Count = 53)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableDeathView")]
	[Calls(Type = typeof(Condition), Member = "GetCauseOfDeathStringUntranslated")]
	[Calls(Type = typeof(SandboxRecord), Member = "StoreAuroraScreenCollectibles")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[Calls(Type = typeof(StatContainer), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Utils), Member = "GetHardcodedRegionForLocation")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUserDefinedSlotName")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	public static SandboxRecord CreateFromSandbox(List<LogListItem> collectibleList)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTOCSelection")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "GetTimeSurvivedString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetLocalizedExperienceMode")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetLocalizedRegion")]
	[Calls(Type = typeof(Utils), Member = "ColorToHex")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Replace")]
	public string GetSurvivalRecordSummaryText(Color boldColor)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetRegionSpriteNameFromSaveSlotInfo")]
	[CallsUnknownMethods(Count = 1)]
	public string GetStartRegionSpriteName()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetSurvivorSpriteName()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string GetExperienceModeSpriteName()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = "ToString")]
	[CallerCount(Count = 0)]
	public string GetEndDate()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SandboxRecord), Member = "CreateFromSandbox")]
	[CallsUnknownMethods(Count = 15)]
	private static void StoreNoteCollectibles(SandboxRecord record)
	{
	}

	[CalledBy(Type = typeof(SandboxRecord), Member = "CreateFromSandbox")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[CallsUnknownMethods(Count = 32)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	private static void StoreCairnCollectibles(SandboxRecord record)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[CalledBy(Type = typeof(SandboxRecord), Member = "CreateFromSandbox")]
	[CallsUnknownMethods(Count = 31)]
	private static void StoreAuroraScreenCollectibles(SandboxRecord record)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public SandboxRecord()
	{
	}
}

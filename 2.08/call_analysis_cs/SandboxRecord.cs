using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
using TLD.Scenes;
using TLD.Stats;
using UnityEngine;

[Serializable]
public class SandboxRecord
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<CairnInfo> _003C_003E9__27_0;

		public static Comparison<AuroraScreenInfo> _003C_003E9__28_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal int _003CStoreCairnCollectibles_003Eb__27_0(CairnInfo x, CairnInfo y)
		{
			return default(int);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CStoreAuroraScreenCollectibles_003Eb__28_0(AuroraScreenInfo x, AuroraScreenInfo y)
		{
			return default(int);
		}
	}

	public string m_SandboxName;

	public float m_ElapsedHours;

	public DateTime m_EndDate;

	public string m_StartRegion;

	public string m_EndRegion;

	public string m_ExperienceModeType;

	public VoicePersona m_VoicePersona;

	public string m_CauseOfDeathLocId;

	public string m_GeneralNotes;

	public List<LogDayInfo> m_LogDayInfoList;

	public List<LogListItem> m_CollectibleList;

	public List<string> m_CollectibleNotesList;

	public List<CairnInfo> m_CollectibleCairnInfoList;

	public List<AuroraScreenInfo> m_CollectibleAuroraScreenInfoList;

	public StatContainer m_Stats;

	[NonSerialized]
	private RegionSpecification m_StartRegionSpecification;

	public GameModeConfig GameMode
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(SandboxRecord), Member = "GetSurvivalRecordSummaryText")]
		[CalledBy(Type = typeof(SandboxRecord), Member = "GetExperienceModeSpriteName")]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public RegionSpecification StartRegion
	{
		[CalledBy(Type = typeof(SandboxRecord), Member = "GetSurvivalRecordSummaryText")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CalledBy(Type = typeof(SandboxRecord), Member = "GetSurvivalRecordSummaryText")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(StatContainer), Member = ".ctor")]
	[Calls(Type = typeof(SandboxRecord), Member = "StoreAuroraScreenCollectibles")]
	[Calls(Type = typeof(SandboxRecord), Member = "StoreCairnCollectibles")]
	[Calls(Type = typeof(SandboxRecord), Member = "StoreNoteCollectibles")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Condition), Member = "GetCauseOfDeathStringUntranslated")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUserDefinedSlotName")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static SandboxRecord CreateFromSandbox(List<LogListItem> collectibleList)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Utils), Member = "GetTimeSurvivedString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SandboxRecord), Member = "get_GameMode")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ZoneSpecification), Member = "get_ZoneName")]
	[Calls(Type = typeof(SandboxRecord), Member = "get_StartRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SandboxRecord), Member = "get_StartRegion")]
	[Calls(Type = typeof(Utils), Member = "ColorToHex")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetSurvivalRecordSummaryText(Color boldColor)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SandboxRecord), Member = "get_GameMode")]
	[CallerCount(Count = 0)]
	public string GetExperienceModeSpriteName()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.DateTimeFormat), Member = "Format")]
	public string GetEndDate()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SandboxRecord), Member = "CreateFromSandbox")]
	[CallsUnknownMethods(Count = 3)]
	private static void StoreNoteCollectibles(SandboxRecord record)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(SandboxRecord), Member = "CreateFromSandbox")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	private static void StoreCairnCollectibles(SandboxRecord record)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[CalledBy(Type = typeof(SandboxRecord), Member = "CreateFromSandbox")]
	private static void StoreAuroraScreenCollectibles(SandboxRecord record)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public SandboxRecord()
	{
	}
}

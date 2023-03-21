using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
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

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CStoreCairnCollectibles_003Eb__27_0(CairnInfo x, CairnInfo y)
		{
			return 0;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CStoreAuroraScreenCollectibles_003Eb__28_0(AuroraScreenInfo x, AuroraScreenInfo y)
		{
			return 0;
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
		[CalledBy(Type = typeof(SandboxRecord), Member = "GetSurvivalRecordSummaryText")]
		[CalledBy(Type = typeof(SandboxRecord), Member = "GetExperienceModeSpriteName")]
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

	public RegionSpecification StartRegion
	{
		[CalledBy(Type = typeof(SandboxRecord), Member = "GetSurvivalRecordSummaryText")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(AssetHelper), Member = "TryLoadAsset")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUserDefinedSlotName")]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Condition), Member = "GetCauseOfDeathStringUntranslated")]
	[Calls(Type = typeof(SandboxRecord), Member = "StoreNoteCollectibles")]
	[Calls(Type = typeof(SandboxRecord), Member = "StoreCairnCollectibles")]
	[Calls(Type = typeof(SandboxRecord), Member = "StoreAuroraScreenCollectibles")]
	[Calls(Type = typeof(StatContainer), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public static SandboxRecord CreateFromSandbox(List<LogListItem> collectibleList)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "ColorToHex")]
	[Calls(Type = typeof(SandboxRecord), Member = "get_StartRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ZoneSpecification), Member = "get_ZoneName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(SandboxRecord), Member = "get_GameMode")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Utils), Member = "GetTimeSurvivedString")]
	[CallsUnknownMethods(Count = 1)]
	public string GetSurvivalRecordSummaryText(Color boldColor)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SandboxRecord), Member = "get_GameMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public string GetExperienceModeSpriteName()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.DateTimeFormat", Member = "Format")]
	public string GetEndDate()
	{
		return null;
	}

	[CalledBy(Type = typeof(SandboxRecord), Member = "CreateFromSandbox")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static void StoreNoteCollectibles(SandboxRecord record)
	{
	}

	[CalledBy(Type = typeof(SandboxRecord), Member = "CreateFromSandbox")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentNullException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 12)]
	private static void StoreCairnCollectibles(SandboxRecord record)
	{
	}

	[CalledBy(Type = typeof(SandboxRecord), Member = "CreateFromSandbox")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HashSet<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentNullException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private static void StoreAuroraScreenCollectibles(SandboxRecord record)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public SandboxRecord()
	{
	}
}

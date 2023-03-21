using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
using UnityEngine;

public class ExperienceModeManagerSaveDataProxy
{
	public string m_CurrentModeType;

	public string m_CustomModeString;

	public string m_PreviousModeType;

	public GameModeConfig CurrentMode
	{
		[CalledBy(Type = typeof(ExperienceModeManager), Member = "Deserialize")]
		[CalledBy(Type = typeof(JumpData), Member = "LoadFromFile")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		set
		{
		}
	}

	public ExperienceModeType PreviousModeType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExperienceModeManagerSaveDataProxy), Member = "StringToExperienceModeType")]
		get
		{
			return default(ExperienceModeType);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enum), Member = "ToString")]
		set
		{
		}
	}

	public ExperienceModeType CurrentModeType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExperienceModeManagerSaveDataProxy), Member = "StringToExperienceModeType")]
		get
		{
			return default(ExperienceModeType);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enum), Member = "ToString")]
		set
		{
		}
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "UpdateSlotGameMode")]
	[CalledBy(Type = typeof(ExperienceModeManagerSaveDataProxy), Member = "get_CurrentModeType")]
	[CalledBy(Type = typeof(ExperienceModeManagerSaveDataProxy), Member = "get_PreviousModeType")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	private static ExperienceModeType StringToExperienceModeType(string xpMode)
	{
		return default(ExperienceModeType);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public ExperienceModeManagerSaveDataProxy()
	{
	}
}

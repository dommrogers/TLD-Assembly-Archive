using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.Gameplay;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

public class ExperienceModeManagerSaveDataProxy
{
	public string m_CurrentModeType;

	public string m_CustomModeString;

	public string m_PreviousModeType;

	public GameModeConfig CurrentMode
	{
		[CalledBy(Type = typeof(JumpData), Member = "LoadFromFile")]
		[CalledBy(Type = typeof(ExperienceModeManager), Member = "Deserialize")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetAsync")]
		[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
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

	[CalledBy(Type = typeof(ExperienceModeManagerSaveDataProxy), Member = "get_PreviousModeType")]
	[CalledBy(Type = typeof(ExperienceModeManagerSaveDataProxy), Member = "get_CurrentModeType")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "UpdateSlotGameMode")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
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

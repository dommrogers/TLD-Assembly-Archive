using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gameplay;

public class SandboxConfig : SandboxBaseConfig
{
	public class SandboxSaveGameFormat
	{
		public const int CURRENT_VERSION = 1;

		public int m_Version;

		public List<BunkerLocationSaveData> m_BunkerSetup;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public SandboxSaveGameFormat()
		{
		}
	}

	public const string SANDBOX_GLOBAL_SAVE_KEY = "sandbox_global";

	public int m_NumFeats;

	private BunkerDistributor m_BunkerSetup;

	private readonly SandboxSaveGameFormat m_SaveData;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameModeConfig), Member = "CreateMissionServicesManager")]
	[Calls(Type = typeof(BunkerDistributor), Member = "DistributeBunkerInteriors")]
	[CallsUnknownMethods(Count = 1)]
	public override void StartGame()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BunkerDistributor), Member = "Serialize")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SaveDataToSlot")]
	[CallsUnknownMethods(Count = 1)]
	public override void SaveGame(SlotData slotData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BunkerDistributor), Member = "Deserialize")]
	[Calls(Type = typeof(BunkerDistributor), Member = "DistributeBunkerInteriors")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void LoadGame(string slotName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SandboxBaseConfig), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public SandboxConfig()
	{
	}
}

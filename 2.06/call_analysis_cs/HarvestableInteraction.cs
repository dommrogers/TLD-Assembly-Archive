using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using UnityEngine;

public class HarvestableInteraction : TimedHoldInteraction
{
	private Harvestable m_Harvestable;

	private uint m_HarvestAudioId;

	public override bool CanInteract
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseHoldInteraction), Member = "get_CanInteract")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "PerformHold")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Harvestable), Member = "GetRequiredTool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public override bool PerformHold()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Harvestable), Member = "Harvest")]
	[CallsUnknownMethods(Count = 1)]
	public override bool PerformInteraction()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "SetCuttingToolSwitch")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Harvestable), Member = "GetRequiredTool")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "BeginHold")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	protected override void BeginHold()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "EndHold")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	protected override void EndHold()
	{
	}

	[Calls(Type = typeof(BaseInteraction), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public HarvestableInteraction()
	{
	}
}

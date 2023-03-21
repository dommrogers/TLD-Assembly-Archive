using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using UnityEngine;

public class HarvestableInteraction : TimedHoldInteraction
{
	private Harvestable m_Harvestable;

	private uint m_HarvestAudioId;

	public override bool CanInteract
	{
		[Calls(Type = typeof(BaseHoldInteraction), Member = "get_CanInteract")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Harvestable), Member = "GetRequiredTool")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "PerformHold")]
	[CallsUnknownMethods(Count = 1)]
	public override bool PerformHold()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[Calls(Type = typeof(Harvestable), Member = "Harvest")]
	[CallerCount(Count = 0)]
	public override bool PerformInteraction()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "BeginHold")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Harvestable), Member = "GetRequiredTool")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetCuttingToolSwitch")]
	protected override void BeginHold()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "EndHold")]
	protected override void EndHold()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public HarvestableInteraction()
	{
	}
}

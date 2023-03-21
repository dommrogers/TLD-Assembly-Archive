using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using UnityEngine;

public class HarvestableInteraction : TimedHoldInteraction
{
	private Harvestable m_Harvestable;

	private uint m_HarvestAudioId;

	public override bool CanInteract
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseHoldInteraction), Member = "get_CanInteract")]
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

	[Calls(Type = typeof(TimedHoldInteraction), Member = "PerformHold")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Harvestable), Member = "GetRequiredTool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
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
	[Calls(Type = typeof(GameAudioManager), Member = "SetCuttingToolSwitch")]
	[CallsUnknownMethods(Count = 1)]
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

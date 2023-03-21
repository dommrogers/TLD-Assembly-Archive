using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;

public class RadioTower : TimedHoldInteraction
{
	public LocalizedString m_LocalizedDisplayName;

	public LocalizedString m_ProgressDisplayName;

	public string m_InteractAudio;

	private bool m_IsBeingInteractedWith;

	private float m_InteractTimer;

	private PlayerControlMode m_RestoreControlMode;

	private uint m_InteractAudioID;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "InitializeInteraction")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public override void InitializeInteraction()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "BeginHold")]
	[CallerCount(Count = 0)]
	protected override void BeginHold()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[CallsUnknownMethods(Count = 1)]
	public override bool PerformInteraction()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void CancelHold()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	private void PlayAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void StopAudio()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public RadioTower()
	{
	}
}

using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using UnityEngine;

public class WoodStove : FireplaceInteraction
{
	public string m_StoveOpenSound;

	public string m_StoveCloseSound;

	private bool m_Open;

	private bool m_ClosePending;

	private ObjectAnim m_ObjectAnim;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(FireplaceInteraction), Member = "Awake")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsUnknownMethods(Count = 3)]
	protected override void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WoodStove), Member = "Close")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuOpen")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectAnim), Member = "Play")]
	public bool Open()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(WoodStove), Member = "PerformFireplaceInteraction")]
	[CalledBy(Type = typeof(WoodStove), Member = "Update")]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuClose")]
	[Calls(Type = typeof(ObjectAnim), Member = "Play")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	public void Close()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(FireplaceInteraction), Member = "AttemptToFeedFire")]
	[Calls(Type = typeof(FireplaceInteraction), Member = "AttemptToStartFire")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuOpen")]
	[Calls(Type = typeof(WoodStove), Member = "Close")]
	[Calls(Type = typeof(ObjectAnim), Member = "Play")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	public override void PerformFireplaceInteraction()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public override bool TooWindyToStart()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = ".ctor")]
	public WoodStove()
	{
	}
}

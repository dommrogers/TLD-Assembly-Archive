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

	[Calls(Type = typeof(WoodStove), Member = "Close")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ObjectAnim), Member = "Play")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuOpen")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public bool Open()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(WoodStove), Member = "Update")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[CalledBy(Type = typeof(WoodStove), Member = "PerformFireplaceInteraction")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(ObjectAnim), Member = "Play")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuClose")]
	public void Close()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(WoodStove), Member = "Close")]
	[Calls(Type = typeof(FireplaceInteraction), Member = "AttemptToFeedFire")]
	[Calls(Type = typeof(FireplaceInteraction), Member = "AttemptToStartFire")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuOpen")]
	[Calls(Type = typeof(ObjectAnim), Member = "Play")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	public override void PerformFireplaceInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override bool TooWindyToStart()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseInteraction), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public WoodStove()
	{
	}
}

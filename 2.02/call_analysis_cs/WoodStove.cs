using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WoodStove : MonoBehaviour
{
	public LocalizedString m_LocalizedDisplayName;

	public string m_StoveOpenSound;

	public string m_StoveCloseSound;

	private bool m_Open;

	private bool m_ClosePending;

	private Fire m_Fire;

	private ObjectAnim m_ObjectAnim;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsUnknownMethods(Count = 3)]
	public void Awake()
	{
	}

	[Calls(Type = typeof(WoodStove), Member = "Close")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsOpen()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ObjectAnim), Member = "Play")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuOpen")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessWoodStoveInteraction")]
	[CallsUnknownMethods(Count = 4)]
	public bool Open()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "MaybeCloseFireContainer")]
	[CalledBy(Type = typeof(WoodStove), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessWoodStoveInteraction")]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[Calls(Type = typeof(ObjectAnim), Member = "Play")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuClose")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	public void Close()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessWoodStoveInteraction")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateWoodStove")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(WoodStove), Member = "GetHoverText")]
	public bool FireBurningInside()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Fire), Member = "GetRemainingLifeTimeSeconds")]
	[CallsUnknownMethods(Count = 2)]
	public float GetMinutesLeftToBurn()
	{
		return default(float);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 29)]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[Calls(Type = typeof(Fire), Member = "GetHeatIncreaseText")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Fire), Member = "GetHeatIncreaseText")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Fire), Member = "GetRemainingLifeTimeSeconds")]
	[Calls(Type = typeof(WoodStove), Member = "FireBurningInside")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public string GetHoverText()
	{
		return null;
	}

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public Fire GetFire()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public bool HasAnimation()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public WoodStove()
	{
	}
}

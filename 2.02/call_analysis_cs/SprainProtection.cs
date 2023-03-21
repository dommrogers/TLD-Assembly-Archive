using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SprainProtection : MonoBehaviour
{
	private bool m_HasSprainProtection;

	private bool m_UpdateBuffNotification;

	private bool m_ShownSprainProtectionState;

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCramponsState")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TakeOffClothingItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PutOnClothingItem")]
	[CallsUnknownMethods(Count = 4)]
	public void UpdateSprainProtection()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasSprainProtection()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffLossNotification")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffNotification")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool ShouldUpdateBuffNotification()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SprainProtection()
	{
	}
}

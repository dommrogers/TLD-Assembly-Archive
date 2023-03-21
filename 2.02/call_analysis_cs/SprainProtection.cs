using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SprainProtection : MonoBehaviour
{
	private bool m_HasSprainProtection;

	private bool m_UpdateBuffNotification;

	private bool m_ShownSprainProtectionState;

	[CalledBy(Type = typeof(PlayerManager), Member = "TakeOffClothingItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PutOnClothingItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCramponsState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void UpdateSprainProtection()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasSprainProtection()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffLossNotification")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffNotification")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldUpdateBuffNotification()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SprainProtection()
	{
	}
}

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
	[CallsUnknownMethods(Count = 1)]
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
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffLossNotification")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffNotification")]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldUpdateBuffNotification()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SprainProtection()
	{
	}
}

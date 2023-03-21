using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SprainProtection : MonoBehaviour
{
	private bool m_HasSprainProtection;

	private bool m_UpdateBuffNotification;

	private bool m_ShownSprainProtectionState;

	[CalledBy(Type = typeof(PlayerManager), Member = "PutOnClothingItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCramponsState")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TakeOffClothingItem")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateSprainProtection()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool HasSprainProtection()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public SprainProtection()
	{
	}
}

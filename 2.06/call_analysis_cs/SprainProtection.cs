using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SprainProtection : MonoBehaviour
{
	private bool m_HasSprainProtection;

	private bool m_UpdateBuffNotification;

	private bool m_ShownSprainProtectionState;

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCramponsState")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TakeOffClothingItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PutOnClothingItem")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateSprainProtection()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasSprainProtection()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffNotification")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffLossNotification")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldUpdateBuffNotification()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public SprainProtection()
	{
	}
}

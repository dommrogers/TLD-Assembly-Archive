using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AfflictionCoverflow : MonoBehaviour
{
	public UISprite m_SpriteEffect;

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Affliction), Member = "SpriteNameFromAfflictionType")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "SetupScrollList")]
	[CallsUnknownMethods(Count = 1)]
	public void SetAffliction(Affliction affliction)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "SetupScrollList")]
	[CallsUnknownMethods(Count = 1)]
	public void SetEmptySlot()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public AfflictionCoverflow()
	{
	}
}

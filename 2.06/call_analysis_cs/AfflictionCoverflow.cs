using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AfflictionCoverflow : MonoBehaviour
{
	public UISprite m_SpriteEffect;

	[CalledBy(Type = typeof(Panel_Affliction), Member = "SetupScrollList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Affliction), Member = "SpriteNameFromAfflictionType")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsUnknownMethods(Count = 1)]
	public void SetAffliction(Affliction affliction)
	{
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "SetupScrollList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsUnknownMethods(Count = 1)]
	public void SetEmptySlot()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public AfflictionCoverflow()
	{
	}
}

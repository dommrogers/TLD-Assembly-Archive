using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AfflictionCoverflow : MonoBehaviour
{
	public UISprite m_SpriteEffect;

	[CalledBy(Type = typeof(Panel_Affliction), Member = "SetupScrollList")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Affliction), Member = "SpriteNameFromAfflictionType")]
	public void SetAffliction(Affliction affliction)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "SetupScrollList")]
	public void SetEmptySlot()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public AfflictionCoverflow()
	{
	}
}

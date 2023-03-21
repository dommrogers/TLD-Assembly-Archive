using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AfflictionCoverflow : MonoBehaviour
{
	public UISprite m_SpriteEffect;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Affliction), Member = "SpriteNameFromAfflictionType")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "SetupScrollList")]
	[CallsUnknownMethods(Count = 1)]
	public void SetAffliction(Affliction affliction)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "SetupScrollList")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void SetEmptySlot()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public AfflictionCoverflow()
	{
	}
}

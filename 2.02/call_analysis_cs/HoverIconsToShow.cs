using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HoverIconsToShow : MonoBehaviour
{
	public enum HoverIcons
	{
		Firestarting,
		Food,
		RawMaterial,
		Tool,
		Clothing,
		FirstAid,
		Locked
	}

	public HoverIcons[] m_HoverIcons;

	[CalledBy(Type = typeof(Panel_HUD), Member = "SetHoverText")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string GetSpriteNameForHoverIcon(HoverIcons hoverIcon)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public HoverIconsToShow()
	{
	}
}

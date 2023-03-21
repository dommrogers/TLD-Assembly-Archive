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

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_HUD), Member = "SetHoverText")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CallerCount(Count = 2)]
	public static string GetSpriteNameForHoverIcon(HoverIcons hoverIcon)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public HoverIconsToShow()
	{
	}
}

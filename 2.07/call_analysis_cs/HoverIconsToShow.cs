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

	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "SetHoverText")]
	[CallAnalysisFailed]
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

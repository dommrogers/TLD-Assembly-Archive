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
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "SetHoverText")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	public static string GetSpriteNameForHoverIcon(HoverIcons hoverIcon)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public HoverIconsToShow()
	{
	}
}

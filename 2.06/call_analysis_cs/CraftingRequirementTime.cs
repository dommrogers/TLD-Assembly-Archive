using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CraftingRequirementTime : MonoBehaviour
{
	public UILabel m_Display;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	public void Disable()
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "FormatDisplayTimeMinutes")]
	public void Enable(int craftingTimeMinutes)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public CraftingRequirementTime()
	{
	}
}

using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CraftingRequirementTime : MonoBehaviour
{
	public UILabel m_Display;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Disable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "FormatDisplayTimeMinutes")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Enable(int craftingTimeMinutes)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public CraftingRequirementTime()
	{
	}
}

using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MiddleOutProgressBar : MonoBehaviour
{
	public UISprite m_LeftSlider;

	public UISprite m_RightSlider;

	public float m_Value;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetValue(float newValue)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void IncrementValue(float increment)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MiddleOutProgressBar()
	{
	}
}

using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MiddleOutProgressBar : MonoBehaviour
{
	public UISprite m_LeftSlider;

	public UISprite m_RightSlider;

	public float m_Value;

	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SetValue(float newValue)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
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

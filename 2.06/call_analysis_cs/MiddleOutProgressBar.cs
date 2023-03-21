using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MiddleOutProgressBar : MonoBehaviour
{
	public UISprite m_LeftSlider;

	public UISprite m_RightSlider;

	public float m_Value;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void SetValue(float newValue)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void IncrementValue(float increment)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public MiddleOutProgressBar()
	{
	}
}

using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ScrollbarThumbResizer : MonoBehaviour
{
	public bool m_AlwaysSmoothScroll;

	private UISlider m_Slider;

	private UISprite m_ThumbSprite;

	private UIWidget m_SliderFGWidget;

	private UIWidget m_SliderBGWidget;

	private int m_NumStepsVisible;

	private int m_NumStepsTotal;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollbarThumbResizer), Member = "CalculateAndSetThumbSize")]
	[Calls(Type = typeof(ScrollbarThumbResizer), Member = "SetThumbPositionFromValue")]
	[CallsUnknownMethods(Count = 2)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDragFinished()
	{
	}

	[CalledBy(Type = typeof(ScrollbarThumbResizer), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[CallsUnknownMethods(Count = 3)]
	private void CalculateAndSetThumbSize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private float CalculateThumbValue()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(ScrollbarThumbResizer), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIProgressBar), Member = "SetThumbPosition")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void SetThumbPositionFromValue(float val)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private Vector3 LerpWithoutClamp(Vector3 A, Vector3 B, float t)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	public void SetNumSteps(int visibleSteps, int totalSteps)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ScrollbarThumbResizer()
	{
	}
}

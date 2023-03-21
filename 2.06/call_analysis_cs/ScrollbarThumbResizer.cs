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
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 8)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ScrollbarThumbResizer), Member = "SetThumbPositionFromValue")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollbarThumbResizer), Member = "CalculateAndSetThumbSize")]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDragFinished()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[CalledBy(Type = typeof(ScrollbarThumbResizer), Member = "LateUpdate")]
	private void CalculateAndSetThumbSize()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private float CalculateThumbValue()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(ScrollbarThumbResizer), Member = "LateUpdate")]
	[Calls(Type = typeof(UIProgressBar), Member = "SetThumbPosition")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
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

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
	[CallsUnknownMethods(Count = 13)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(ScrollbarThumbResizer), Member = "SetThumbPositionFromValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollbarThumbResizer), Member = "CalculateAndSetThumbSize")]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDragFinished()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(ScrollbarThumbResizer), Member = "LateUpdate")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	private void CalculateAndSetThumbSize()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	private float CalculateThumbValue()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 55)]
	[CalledBy(Type = typeof(ScrollbarThumbResizer), Member = "LateUpdate")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(UIProgressBar), Member = "SetThumbPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	private void SetThumbPositionFromValue(float val)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ScrollbarThumbResizer()
	{
	}
}

using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Demos.GamepadTemplateUI;

public class ControllerUIEffect : MonoBehaviour
{
	private Color _highlightColor;

	private Image _image;

	private Color _color;

	private Color _origColor;

	private bool _isActive;

	private float _highlightAmount;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(ControllerUIElement), Member = "Activate")]
	[CalledBy(Type = typeof(ControllerUIElement), Member = "Activate")]
	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	public void Activate(float amount)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Deactivate()
	{
	}

	[CalledBy(Type = typeof(ControllerUIElement), Member = "Deactivate")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ControllerUIElement), Member = "Deactivate")]
	[CallsUnknownMethods(Count = 2)]
	private void RedrawImage()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ControllerUIEffect()
	{
	}
}

using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Demos.GamepadTemplateUI;

public class ControllerUIElement : MonoBehaviour
{
	private Color _highlightColor;

	private ControllerUIEffect _positiveUIEffect;

	private ControllerUIEffect _negativeUIEffect;

	private Text _label;

	private Text _positiveLabel;

	private Text _negativeLabel;

	private ControllerUIElement[] _childElements;

	private Image _image;

	private Color _color;

	private Color _origColor;

	private bool _isActive;

	private float _highlightAmount;

	private bool hasEffects
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	[Calls(Type = typeof(ControllerUIElement), Member = "ClearLabels")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ControllerUIEffect), Member = "Activate")]
	[Calls(Type = typeof(ControllerUIEffect), Member = "Activate")]
	[Calls(Type = typeof(ControllerUIElement), Member = "Activate")]
	[CalledBy(Type = typeof(ControllerUIElement), Member = "Activate")]
	[CalledBy(Type = typeof(GamepadTemplateUI), Member = "ActivateElements")]
	[CallsUnknownMethods(Count = 2)]
	public void Activate(float amount)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GamepadTemplateUI), Member = "DrawActiveElements")]
	[CalledBy(Type = typeof(ControllerUIElement), Member = "Deactivate")]
	[Calls(Type = typeof(ControllerUIElement), Member = "Deactivate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ControllerUIEffect), Member = "RedrawImage")]
	[Calls(Type = typeof(ControllerUIEffect), Member = "RedrawImage")]
	[CallerCount(Count = 2)]
	public void Deactivate()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ControllerUIElement), Member = "SetLabel")]
	[CalledBy(Type = typeof(ControllerUIElement), Member = "SetLabel")]
	[CalledBy(Type = typeof(GamepadTemplateUI), Member = "DrawLabel")]
	[CalledBy(Type = typeof(GamepadTemplateUI), Member = "DrawLabel")]
	[CalledBy(Type = typeof(GamepadTemplateUI), Member = "DrawLabel")]
	[CallsUnknownMethods(Count = 2)]
	public void SetLabel(string text, AxisRange labelType)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GamepadTemplateUI), Member = "DrawLabels")]
	[CalledBy(Type = typeof(ControllerUIElement), Member = "ClearLabels")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ControllerUIElement), Member = "ClearLabels")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(ControllerUIElement), Member = "Awake")]
	public void ClearLabels()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void RedrawImage()
	{
	}

	[CallerCount(Count = 0)]
	public ControllerUIElement()
	{
	}
}

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
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		get
		{
			return false;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(ControllerUIElement), Member = "ClearLabels")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(ControllerUIElement), Member = "Activate")]
	[CalledBy(Type = typeof(GamepadTemplateUI), Member = "ActivateElements")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ControllerUIEffect), Member = "Activate")]
	[Calls(Type = typeof(ControllerUIElement), Member = "Activate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Activate(float amount)
	{
	}

	[CalledBy(Type = typeof(ControllerUIElement), Member = "Deactivate")]
	[CalledBy(Type = typeof(GamepadTemplateUI), Member = "DrawActiveElements")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ControllerUIEffect), Member = "RedrawImage")]
	[Calls(Type = typeof(ControllerUIElement), Member = "Deactivate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Deactivate()
	{
	}

	[CalledBy(Type = typeof(ControllerUIElement), Member = "SetLabel")]
	[CalledBy(Type = typeof(GamepadTemplateUI), Member = "DrawLabel")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ControllerUIElement), Member = "SetLabel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetLabel(string text, AxisRange labelType)
	{
	}

	[CalledBy(Type = typeof(ControllerUIElement), Member = "Awake")]
	[CalledBy(Type = typeof(ControllerUIElement), Member = "ClearLabels")]
	[CalledBy(Type = typeof(GamepadTemplateUI), Member = "DrawLabels")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ControllerUIElement), Member = "ClearLabels")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void ClearLabels()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void RedrawImage()
	{
	}

	[CallerCount(Count = 0)]
	public ControllerUIElement()
	{
	}
}

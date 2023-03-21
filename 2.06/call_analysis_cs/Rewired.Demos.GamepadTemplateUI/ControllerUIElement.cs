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
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		get
		{
			return default(bool);
		}
	}

	[Calls(Type = typeof(ControllerUIElement), Member = "ClearLabels")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(ControllerUIElement), Member = "Activate")]
	[CalledBy(Type = typeof(ControllerUIElement), Member = "Activate")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GamepadTemplateUI), Member = "ActivateElements")]
	[Calls(Type = typeof(ControllerUIEffect), Member = "Activate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ControllerUIEffect), Member = "Activate")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	public void Activate(float amount)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GamepadTemplateUI), Member = "DrawActiveElements")]
	[CalledBy(Type = typeof(ControllerUIElement), Member = "Deactivate")]
	[Calls(Type = typeof(ControllerUIElement), Member = "Deactivate")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ControllerUIEffect), Member = "RedrawImage")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ControllerUIEffect), Member = "RedrawImage")]
	public void Deactivate()
	{
	}

	[CalledBy(Type = typeof(GamepadTemplateUI), Member = "DrawLabel")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GamepadTemplateUI), Member = "DrawLabel")]
	[CalledBy(Type = typeof(GamepadTemplateUI), Member = "DrawLabel")]
	[CalledBy(Type = typeof(ControllerUIElement), Member = "SetLabel")]
	[Calls(Type = typeof(ControllerUIElement), Member = "SetLabel")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	public void SetLabel(string text, AxisRange labelType)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GamepadTemplateUI), Member = "DrawLabels")]
	[CalledBy(Type = typeof(ControllerUIElement), Member = "ClearLabels")]
	[CalledBy(Type = typeof(ControllerUIElement), Member = "Awake")]
	[Calls(Type = typeof(ControllerUIElement), Member = "ClearLabels")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
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

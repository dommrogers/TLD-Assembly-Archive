using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIImageButton : MonoBehaviour
{
	public UISprite target;

	public string normalSprite;

	public string hoverSprite;

	public string pressedSprite;

	public string disabledSprite;

	public bool pixelSnap;

	public bool isEnabled
	{
		[CalledBy(Type = typeof(UIImageButton), Member = "OnHover")]
		[CallsUnknownMethods(Count = 4)]
		[CalledBy(Type = typeof(UIImageButton), Member = "UpdateImage")]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 2)]
		get
		{
			return default(bool);
		}
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(Collider), Member = "set_enabled")]
		[Calls(Type = typeof(UIImageButton), Member = "UpdateImage")]
		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIImageButton), Member = "UpdateImage")]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnValidate()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIImageButton), Member = "get_isEnabled")]
	[CalledBy(Type = typeof(UIImageButton), Member = "set_isEnabled")]
	[CalledBy(Type = typeof(UIImageButton), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIImageButton), Member = "SetSprite")]
	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	private void UpdateImage()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIImageButton), Member = "SetSprite")]
	[Calls(Type = typeof(UIImageButton), Member = "get_isEnabled")]
	private void OnHover(bool isOver)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void OnPress(bool pressed)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(UIImageButton), Member = "OnHover")]
	[CalledBy(Type = typeof(UIImageButton), Member = "UpdateImage")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private void SetSprite(string sprite)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public UIImageButton()
	{
	}
}

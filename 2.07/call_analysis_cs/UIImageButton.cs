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
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(UIImageButton), Member = "UpdateImage")]
		[CalledBy(Type = typeof(UIImageButton), Member = "OnHover")]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return default(bool);
		}
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(UIImageButton), Member = "UpdateImage")]
		[Calls(Type = typeof(Collider), Member = "set_enabled")]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIImageButton), Member = "UpdateImage")]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnValidate()
	{
	}

	[Calls(Type = typeof(UIImageButton), Member = "SetSprite")]
	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	[Calls(Type = typeof(UIImageButton), Member = "get_isEnabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UIImageButton), Member = "set_isEnabled")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIImageButton), Member = "OnEnable")]
	private void UpdateImage()
	{
	}

	[Calls(Type = typeof(UIImageButton), Member = "SetSprite")]
	[Calls(Type = typeof(UIImageButton), Member = "get_isEnabled")]
	[CallerCount(Count = 0)]
	private void OnHover(bool isOver)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void OnPress(bool pressed)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIImageButton), Member = "UpdateImage")]
	[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
	[CalledBy(Type = typeof(UIImageButton), Member = "OnHover")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	private void SetSprite(string sprite)
	{
	}

	[CallerCount(Count = 0)]
	public UIImageButton()
	{
	}
}

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
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[CalledBy(Type = typeof(UIImageButton), Member = "UpdateImage")]
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

	[Calls(Type = typeof(UIImageButton), Member = "UpdateImage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	private void OnValidate()
	{
	}

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIImageButton), Member = "get_isEnabled")]
	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	[Calls(Type = typeof(UIImageButton), Member = "SetSprite")]
	[CalledBy(Type = typeof(UIImageButton), Member = "set_isEnabled")]
	[CalledBy(Type = typeof(UIImageButton), Member = "OnEnable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private void UpdateImage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIImageButton), Member = "SetSprite")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIImageButton), Member = "get_isEnabled")]
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
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIImageButton), Member = "OnHover")]
	[CalledBy(Type = typeof(UIImageButton), Member = "UpdateImage")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
	private void SetSprite(string sprite)
	{
	}

	[CallerCount(Count = 0)]
	public UIImageButton()
	{
	}
}

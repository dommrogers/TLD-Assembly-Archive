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
		[CalledBy(Type = typeof(UIImageButton), Member = "UpdateImage")]
		[CalledBy(Type = typeof(UIImageButton), Member = "OnHover")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(GameObject), Member = "GetComponent")]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return false;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GameObject), Member = "GetComponent")]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[Calls(Type = typeof(Collider), Member = "set_enabled")]
		[Calls(Type = typeof(UIImageButton), Member = "UpdateImage")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UIImageButton), Member = "UpdateImage")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	private void OnValidate()
	{
	}

	[CalledBy(Type = typeof(UIImageButton), Member = "set_isEnabled")]
	[CalledBy(Type = typeof(UIImageButton), Member = "OnEnable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIImageButton), Member = "get_isEnabled")]
	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	[Calls(Type = typeof(UIImageButton), Member = "SetSprite")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateImage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIImageButton), Member = "get_isEnabled")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIImageButton), Member = "SetSprite")]
	private void OnHover(bool isOver)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnPress(bool pressed)
	{
	}

	[CalledBy(Type = typeof(UIImageButton), Member = "UpdateImage")]
	[CalledBy(Type = typeof(UIImageButton), Member = "OnHover")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetSprite(string sprite)
	{
	}

	[CallerCount(Count = 0)]
	public UIImageButton()
	{
	}
}

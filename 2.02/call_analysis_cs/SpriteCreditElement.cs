using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SpriteCreditElement : CreditElement
{
	private UISprite m_Sprite;

	private const int ALTAS_ID_INDEX = 0;

	private const int SPRITE_NAME_INDEX = 1;

	private const int SPRITE_SCALE_INDEX = 2;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(SpriteCreditElement), Member = "GetAtlasFromContent")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 1)]
	public override bool IsContentValid(string[] content, Panel_Credits panel)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(UIWidget), Member = "SetDimensions")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(SpriteCreditElement), Member = "GetAtlasFromContent")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	public override void Populate(string[] content, Panel_Credits panel)
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CallsUnknownMethods(Count = 1)]
	public override Vector2 GetSize()
	{
		return default(Vector2);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override void SetPosition(float yOffset)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(SpriteCreditElement), Member = "IsContentValid")]
	[CalledBy(Type = typeof(SpriteCreditElement), Member = "Populate")]
	[CallsUnknownMethods(Count = 5)]
	private UIAtlas GetAtlasFromContent(string[] content, Panel_Credits panel)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SpriteCreditElement()
	{
	}
}

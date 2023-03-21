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
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(SpriteCreditElement), Member = "GetAtlasFromContent")]
	[CallsUnknownMethods(Count = 1)]
	public override bool IsContentValid(string[] content, Panel_Credits panel)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpriteCreditElement), Member = "GetAtlasFromContent")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(float), Member = "TryParse")]
	[Calls(Type = typeof(UIWidget), Member = "SetDimensions")]
	[CallsUnknownMethods(Count = 4)]
	public override void Populate(string[] content, Panel_Credits panel)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override Vector2 GetSize()
	{
		return default(Vector2);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public override void SetPosition(float yOffset)
	{
	}

	[CalledBy(Type = typeof(SpriteCreditElement), Member = "IsContentValid")]
	[CalledBy(Type = typeof(SpriteCreditElement), Member = "Populate")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	private UIAtlas GetAtlasFromContent(string[] content, Panel_Credits panel)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public SpriteCreditElement()
	{
	}
}

using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TextureCreditElement : CreditElement
{
	private UITexture m_Texture;

	private const int TEXTURE_ID_INDEX = 0;

	private const int TEXTURE_SCALE_INDEX = 2;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TextureCreditElement), Member = "GetTextureFromContent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	public override bool IsContentValid(string[] content, Panel_Credits panel)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(TextureCreditElement), Member = "GetTextureFromContent")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UIWidget), Member = "SetDimensions")]
	[CallsUnknownMethods(Count = 7)]
	public override void Populate(string[] content, Panel_Credits panel)
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override Vector2 GetSize()
	{
		return default(Vector2);
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override void SetPosition(float yOffset)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(TextureCreditElement), Member = "IsContentValid")]
	[CalledBy(Type = typeof(TextureCreditElement), Member = "Populate")]
	[CallsUnknownMethods(Count = 5)]
	private Texture2D GetTextureFromContent(string[] content, Panel_Credits panel)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public TextureCreditElement()
	{
	}
}

using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TextureCreditElement : CreditElement
{
	private UITexture m_Texture;

	private const int TEXTURE_ID_INDEX = 0;

	private const int TEXTURE_SCALE_INDEX = 2;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureCreditElement), Member = "GetTextureFromContent")]
	[CallsUnknownMethods(Count = 1)]
	public override bool IsContentValid(string[] content, Panel_Credits panel)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureCreditElement), Member = "GetTextureFromContent")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(float), Member = "TryParse")]
	[Calls(Type = typeof(UIWidget), Member = "SetDimensions")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public override void Populate(string[] content, Panel_Credits panel)
	{
	}

	[CallerCount(Count = 0)]
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

	[CalledBy(Type = typeof(TextureCreditElement), Member = "IsContentValid")]
	[CalledBy(Type = typeof(TextureCreditElement), Member = "Populate")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	private Texture2D GetTextureFromContent(string[] content, Panel_Credits panel)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TextureCreditElement()
	{
	}
}

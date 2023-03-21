using System;
using System.Diagnostics;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using Rewired;
using UnityEngine;

public static class NGUIText
{
	public enum Alignment
	{
		Automatic,
		Left,
		Center,
		Right,
		Justified
	}

	public enum SymbolStyle
	{
		None,
		Normal,
		Colored
	}

	public class GlyphInfo
	{
		public Vector2 v0;

		public Vector2 v1;

		public Vector2 u0;

		public Vector2 u1;

		public Vector2 u2;

		public Vector2 u3;

		public float advance;

		public int channel;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public GlyphInfo()
		{
		}
	}

	public static UIFont bitmapFont;

	public static Font dynamicFont;

	public static GlyphInfo glyph;

	public static int fontSize;

	public static float fontScale;

	public static float pixelDensity;

	public static FontStyle fontStyle;

	public static Alignment alignment;

	public static Color tint;

	public static int rectWidth;

	public static int rectHeight;

	public static int regionWidth;

	public static int regionHeight;

	public static int maxLines;

	public static bool gradient;

	public static Color gradientBottom;

	public static Color gradientTop;

	public static bool encoding;

	public static float spacingX;

	public static float spacingY;

	public static bool premultiply;

	public static SymbolStyle symbolStyle;

	public static int finalSize;

	public static float finalSpacingX;

	public static float finalLineHeight;

	public static float baseline;

	public static bool useSymbols;

	public static BetterList<string> m_DynamicSymbolNames;

	private static string m_DynamicSymbolKeyphrase;

	private static string m_DynamicSymbolKeyphraseUpper;

	private static string m_DynamicSymbolNameUpper;

	private static BetterList<BMSymbol> s_DynamicSymbols;

	private static Color mInvisible;

	private static BetterList<Color> mColors;

	private static float mAlpha;

	private static CharacterInfo mTempChar;

	private static BetterList<float> mSizes;

	private static Color32 s_c0;

	private static Color32 s_c1;

	private static float[] mBoldOffset;

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void Update()
	{
	}

	[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(Font), Member = "GetCharacterInfo")]
	[Calls(Type = typeof(Font), Member = "RequestCharactersInTexture")]
	[Calls(Type = typeof(Font), Member = "GetCharacterInfo")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Font), Member = "RequestCharactersInTexture")]
	public static void Update(bool request)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[CalledBy(Type = typeof(NGUIText), Member = "CalculateOffsetToFit")]
	[CalledBy(Type = typeof(NGUIText), Member = "CalculatePrintedSize")]
	[Calls(Type = typeof(Font), Member = "RequestCharactersInTexture")]
	[Calls(Type = typeof(NGUIText), Member = "MaybeReplaceSymbolWithKeycode")]
	[Calls(Type = typeof(NGUIText), Member = "GetSymbol")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	public static string Prepare(string text)
	{
		return null;
	}

	[CalledBy(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	[Calls(Type = typeof(UIFont), Member = "MatchSymbol")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[CalledBy(Type = typeof(NGUIText), Member = "CalculateOffsetToFit")]
	[CalledBy(Type = typeof(NGUIText), Member = "CalculatePrintedSize")]
	[Calls(Type = typeof(NGUIText), Member = "GetDynamicSymbol")]
	[CalledBy(Type = typeof(NGUIText), Member = "Prepare")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NGUIText), Member = "MaybeReplaceSymbolsWithKeycodes")]
	[CallerCount(Count = 7)]
	public static BMSymbol GetSymbol(string text, int index, int textLength)
	{
		return null;
	}

	[CalledBy(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UIFont), Member = "get_bmFont")]
	[Calls(Type = typeof(BMFont), Member = "GetGlyph")]
	[Calls(Type = typeof(BMGlyph), Member = "GetKerning")]
	[Calls(Type = typeof(Font), Member = "GetCharacterInfo")]
	[Calls(Type = typeof(CharacterInfo), Member = "get_advance")]
	[CalledBy(Type = typeof(NGUIText), Member = "CalculatePrintedSize")]
	[CalledBy(Type = typeof(NGUIText), Member = "CalculateOffsetToFit")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	public static float GetGlyphWidth(int ch, int prev)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIFont), Member = "get_bmFont")]
	[Calls(Type = typeof(BMFont), Member = "GetGlyph")]
	[Calls(Type = typeof(Font), Member = "GetCharacterInfo")]
	[Calls(Type = typeof(CharacterInfo), Member = "get_advance")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(BMGlyph), Member = "GetKerning")]
	public static GlyphInfo GetGlyph(int ch, int prev)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	public static float ParseAlpha(string text, int index)
	{
		return default(float);
	}

	[Calls(Type = typeof(NGUIText), Member = "ParseColor24")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[CallerCount(Count = 0)]
	public static Color ParseColor(string text, int offset)
	{
		return default(Color);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NGUIText), Member = "ParseColor")]
	[DebuggerStepThrough]
	[DebuggerHidden]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[CalledBy(Type = typeof(NGUITools), Member = "ParseColor")]
	[CalledBy(Type = typeof(NGUIText), Member = "ParseSymbol")]
	public static Color ParseColor24(string text, int offset)
	{
		return default(Color);
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	public static Color ParseColor32(string text, int offset)
	{
		return default(Color);
	}

	[Calls(Type = typeof(NGUIText), Member = "EncodeColor24")]
	[CallerCount(Count = 0)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	public static string EncodeColor(Color c)
	{
		return null;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIText), Member = "EncodeColor24")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 21)]
	public static string EncodeColor(string text, Color c)
	{
		return null;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CalledBy(Type = typeof(TypewriterEffect), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	public static string EncodeAlpha(float a)
	{
		return null;
	}

	[CalledBy(Type = typeof(UIItemSlot), Member = "OnTooltip")]
	[CalledBy(Type = typeof(NGUITools), Member = "EncodeColor")]
	[CalledBy(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[CalledBy(Type = typeof(NGUIText), Member = "EncodeColor")]
	[CalledBy(Type = typeof(NGUIText), Member = "EncodeColor")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NGUIMath), Member = "ColorToInt")]
	[CallerCount(Count = 5)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	public static string EncodeColor24(Color c)
	{
		return null;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIMath), Member = "ColorToInt")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	public static string EncodeColor32(Color c)
	{
		return null;
	}

	[CalledBy(Type = typeof(TypewriterEffect), Member = "Update")]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[Calls(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	[CallerCount(Count = 4)]
	public static bool ParseSymbol(string text, ref int index)
	{
		return default(bool);
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[CallerCount(Count = 0)]
	public static bool IsHex(char ch)
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(NGUIMath), Member = "ColorToInt")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(NGUIText), Member = "EncodeColor24")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[CalledBy(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[CalledBy(Type = typeof(NGUIText), Member = "StripSymbols")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(NGUIText), Member = "ParseColor24")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public static bool ParseSymbol(string text, ref int index, BetterList<Color> colors, bool premultiply, ref int sub, ref bool bold, ref bool italic, ref bool underline, ref bool strike, ref bool ignoreColor)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(NGUITools), Member = "StripSymbols")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "Remove")]
	[Calls(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(UILabel), Member = "GetWordAtCharacterIndex")]
	[CalledBy(Type = typeof(NGUIText), Member = "CalculatePrintedSize")]
	[CalledBy(Type = typeof(ChatInput), Member = "OnSubmit")]
	[CallsUnknownMethods(Count = 1)]
	public static string StripSymbols(string text)
	{
		return null;
	}

	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	public static void Align(BetterList<Vector3> verts, int indexOffset, float printedWidth)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static int GetExactCharacterIndex(BetterList<Vector3> verts, BetterList<int> indices, Vector2 pos)
	{
		return default(int);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	public static int GetApproximateCharacterIndex(BetterList<Vector3> verts, BetterList<int> indices, Vector2 pos)
	{
		return default(int);
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[CallerCount(Count = 0)]
	private static bool IsSpace(int ch)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Chars")]
	[CallerCount(Count = 2)]
	[DebuggerStepThrough]
	[DebuggerHidden]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars")]
	public static void EndLine(ref StringBuilder s)
	{
	}

	[DebuggerHidden]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Chars")]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars")]
	[CallerCount(Count = 2)]
	[DebuggerStepThrough]
	private static void ReplaceSpaceWithNewline(ref StringBuilder s)
	{
	}

	[Calls(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
	[Calls(Type = typeof(NGUIText), Member = "Prepare")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
	[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
	[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(NGUIText), Member = "GetSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "StripSymbols")]
	public static Vector2 CalculatePrintedSize(string text)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(UILabel), Member = "CalculateOffsetToFit")]
	[CalledBy(Type = typeof(NGUIText), Member = "GetEndOfLineThatFits")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
	[Calls(Type = typeof(NGUIText), Member = "GetSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "Prepare")]
	public static int CalculateOffsetToFit(string text)
	{
		return default(int);
	}

	[Calls(Type = typeof(NGUIText), Member = "CalculateOffsetToFit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsUnknownMethods(Count = 1)]
	public static string GetEndOfLineThatFits(string text)
	{
		return null;
	}

	[CalledBy(Type = typeof(UILabel), Member = "Wrap")]
	[CalledBy(Type = typeof(UILabel), Member = "Wrap")]
	[Calls(Type = typeof(NGUIText), Member = "WrapText")]
	[CallerCount(Count = 2)]
	public static bool WrapText(string text, out string finalText)
	{
		finalText = null;
		return default(bool);
	}

	[Calls(Type = typeof(NGUIText), Member = "ReplaceSpaceWithNewline")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Insert")]
	[Calls(Type = typeof(NGUIText), Member = "EndLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(NGUIText), Member = "ReplaceSpaceWithNewline")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(NGUIText), Member = "EndLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(NGUIText), Member = "GetSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(NGUIText), Member = "Prepare")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
	[CalledBy(Type = typeof(UITextList), Member = "Rebuild")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
	public static bool WrapText(string text, out string finalText, bool keepCharCount, bool bulleted, int bulletSpacing)
	{
		finalText = null;
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	public static void Print(string text, BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, UILabel printedLabel)
	{
	}

	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[Calls(Type = typeof(NGUIText), Member = "GetSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "Prepare")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public static void PrintApproximateCharacterPositions(string text, BetterList<Vector3> verts, BetterList<int> indices)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(TextInputField), Member = "GetCursorLocation")]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(Type = typeof(NGUIText), Member = "GetSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NGUIText), Member = "Prepare")]
	public static void PrintExactCharacterPositions(string text, BetterList<Vector3> verts, BetterList<int> indices)
	{
	}

	[CalledBy(Type = typeof(UILabel), Member = "PrintOverlay")]
	[CalledBy(Type = typeof(UILabel), Member = "PrintOverlay")]
	[CallerCount(Count = 2)]
	[CallAnalysisFailed]
	public static void PrintCaretAndSelection(string text, int start, int end, BetterList<Vector3> caret, BetterList<Vector3> highlight)
	{
	}

	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "get_Actions")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(NGUIText), Member = "GetSymbol")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "get_Actions")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private static BMSymbol GetDynamicSymbol(string text, int offset, int textLength)
	{
		return null;
	}

	[CalledBy(Type = typeof(NGUIText), Member = "Prepare")]
	[Calls(Type = typeof(string), Member = "Insert")]
	[Calls(Type = typeof(string), Member = "Remove")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonNameForAction")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonNameForAction")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CalledBy(Type = typeof(NGUIText), Member = "MaybeReplaceSymbolsWithKeycodes")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsUnknownMethods(Count = 3)]
	private static string MaybeReplaceSymbolWithKeycode(string text, ref BMSymbol symbol)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(NGUIText), Member = "MaybeReplaceSymbolWithKeycode")]
	[Calls(Type = typeof(NGUIText), Member = "GetSymbol")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private static string MaybeReplaceSymbolsWithKeycodes(string text)
	{
		return null;
	}
}

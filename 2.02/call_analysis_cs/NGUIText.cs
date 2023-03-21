using System;
using System.Diagnostics;
using System.Globalization;
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
		[CallerCount(Count = 2)]
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

	public static bool allowSymbolFallback;

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

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void Update()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(Font), Member = "GetCharacterInfo")]
	[Calls(Type = typeof(Font), Member = "RequestCharactersInTexture")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Font), Member = "GetCharacterInfo")]
	[Calls(Type = typeof(Font), Member = "RequestCharactersInTexture")]
	public static void Update(bool request)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(NGUIText), Member = "CalculateOffsetToFit")]
	[Calls(Type = typeof(Font), Member = "RequestCharactersInTexture")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[Calls(Type = typeof(NGUIText), Member = "MaybeReplaceSymbolsWithKeycodes")]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[CalledBy(Type = typeof(NGUIText), Member = "CalculatePrintedSize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public static string Prepare(string text)
	{
		return null;
	}

	[CalledBy(Type = typeof(NGUIText), Member = "CalculatePrintedSize")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NGUIText), Member = "MaybeReplaceSymbolsWithKeycodes")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[CalledBy(Type = typeof(NGUIText), Member = "CalculateOffsetToFit")]
	[Calls(Type = typeof(NGUIText), Member = "GetDynamicSymbol")]
	[Calls(Type = typeof(UIFont), Member = "MatchSymbol")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public static BMSymbol GetSymbol(string text, int index, int textLength)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[CalledBy(Type = typeof(NGUIText), Member = "CalculateOffsetToFit")]
	[CalledBy(Type = typeof(NGUIText), Member = "CalculatePrintedSize")]
	[Calls(Type = typeof(BMGlyph), Member = "GetKerning")]
	[Calls(Type = typeof(BMFont), Member = "GetGlyph")]
	[Calls(Type = typeof(UIFont), Member = "get_bmFont")]
	[Calls(Type = typeof(CharacterInfo), Member = "get_advance")]
	[Calls(Type = typeof(Font), Member = "GetCharacterInfo")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public static float GetGlyphWidth(int ch, int prev)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 27)]
	[Calls(Type = typeof(BMGlyph), Member = "GetKerning")]
	[Calls(Type = typeof(BMFont), Member = "GetGlyph")]
	[Calls(Type = typeof(UIFont), Member = "get_bmFont")]
	[Calls(Type = typeof(Font), Member = "GetCharacterInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CharacterInfo), Member = "get_advance")]
	[CallerCount(Count = 0)]
	public static GlyphInfo GetGlyph(int ch, int prev)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[CallsDeduplicatedMethods(Count = 3)]
	public static float ParseAlpha(string text, int index)
	{
		return default(float);
	}

	[Calls(Type = typeof(NGUIText), Member = "ParseColor24")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DebuggerStepThrough]
	[DebuggerHidden]
	public static Color ParseColor(string text, int offset)
	{
		return default(Color);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CalledBy(Type = typeof(NGUIText), Member = "ParseColor")]
	[CalledBy(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[CalledBy(Type = typeof(NGUITools), Member = "ParseColor")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[DebuggerStepThrough]
	[DebuggerHidden]
	[CallerCount(Count = 3)]
	public static Color ParseColor24(string text, int offset)
	{
		return default(Color);
	}

	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[DebuggerStepThrough]
	[DebuggerHidden]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CalledBy(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	public static Color ParseColor32(string text, int offset)
	{
		return default(Color);
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUIText), Member = "EncodeColor24")]
	public static string EncodeColor(Color c)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUIText), Member = "EncodeColor24")]
	[CallsUnknownMethods(Count = 21)]
	public static string EncodeColor(string text, Color c)
	{
		return null;
	}

	[CalledBy(Type = typeof(TypewriterEffect), Member = "Update")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallerCount(Count = 1)]
	[DebuggerStepThrough]
	[DebuggerHidden]
	[CallsDeduplicatedMethods(Count = 2)]
	public static string EncodeAlpha(float a)
	{
		return null;
	}

	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CalledBy(Type = typeof(UIItemSlot), Member = "OnTooltip")]
	[CalledBy(Type = typeof(NGUIText), Member = "EncodeColor")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CalledBy(Type = typeof(NGUIText), Member = "EncodeColor")]
	[CalledBy(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[CalledBy(Type = typeof(NGUITools), Member = "EncodeColor")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUIMath), Member = "ColorToInt")]
	public static string EncodeColor24(Color c)
	{
		return null;
	}

	[DebuggerHidden]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUIMath), Member = "ColorToInt")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[DebuggerStepThrough]
	public static string EncodeColor32(Color c)
	{
		return null;
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(TypewriterEffect), Member = "Update")]
	[Calls(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	public static bool ParseSymbol(string text, ref int index)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DebuggerStepThrough]
	[DebuggerHidden]
	public static bool IsHex(char ch)
	{
		return default(bool);
	}

	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(NGUIText), Member = "ParseColor32")]
	[Calls(Type = typeof(NGUIText), Member = "ParseColor24")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[CalledBy(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(NGUIText), Member = "EncodeColor24")]
	[Calls(Type = typeof(NGUIMath), Member = "ColorToInt")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(NGUIText), Member = "StripSymbols")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public static bool ParseSymbol(string text, ref int index, BetterList<Color> colors, bool premultiply, ref int sub, ref bool bold, ref bool italic, ref bool underline, ref bool strike, ref bool ignoreColor)
	{
		return default(bool);
	}

	[Calls(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[Calls(Type = typeof(string), Member = "Remove")]
	[CalledBy(Type = typeof(ChatInput), Member = "OnSubmit")]
	[CalledBy(Type = typeof(NGUIText), Member = "CalculatePrintedSize")]
	[CalledBy(Type = typeof(NGUITools), Member = "StripSymbols")]
	[CalledBy(Type = typeof(UILabel), Member = "GetWordAtCharacterIndex")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallerCount(Count = 4)]
	public static string StripSymbols(string text)
	{
		return null;
	}

	[CalledBy(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	[CallsUnknownMethods(Count = 29)]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	public static void Align(BetterList<Vector3> verts, int indexOffset, float printedWidth)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public static int GetExactCharacterIndex(BetterList<Vector3> verts, BetterList<int> indices, Vector2 pos)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public static int GetApproximateCharacterIndex(BetterList<Vector3> verts, BetterList<int> indices, Vector2 pos)
	{
		return default(int);
	}

	[DebuggerStepThrough]
	[CallerCount(Count = 0)]
	[DebuggerHidden]
	private static bool IsSpace(int ch)
	{
		return default(bool);
	}

	[Calls(Type = typeof(StringBuilder), Member = "get_Chars")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[DebuggerStepThrough]
	[DebuggerHidden]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Chars")]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[CallsUnknownMethods(Count = 8)]
	public static void EndLine(ref StringBuilder s)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Chars")]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[DebuggerStepThrough]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[CallsUnknownMethods(Count = 3)]
	[DebuggerHidden]
	private static void ReplaceSpaceWithNewline(ref StringBuilder s)
	{
	}

	[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
	[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
	[Calls(Type = typeof(NGUIText), Member = "GetSymbol")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(NGUIText), Member = "Prepare")]
	[Calls(Type = typeof(NGUIText), Member = "StripSymbols")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	public static Vector2 CalculatePrintedSize(string text)
	{
		return default(Vector2);
	}

	[CalledBy(Type = typeof(UILabel), Member = "CalculateOffsetToFit")]
	[CalledBy(Type = typeof(NGUIText), Member = "GetEndOfLineThatFits")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(NGUIText), Member = "GetSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "Prepare")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	public static int CalculateOffsetToFit(string text)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(NGUIText), Member = "CalculateOffsetToFit")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string GetEndOfLineThatFits(string text)
	{
		return null;
	}

	[Calls(Type = typeof(NGUIText), Member = "WrapText")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(UILabel), Member = "Wrap")]
	[CalledBy(Type = typeof(UILabel), Member = "Wrap")]
	[CalledBy(Type = typeof(UITextList), Member = "Rebuild")]
	public static bool WrapText(string text, out string finalText)
	{
		finalText = null;
		return default(bool);
	}

	[Calls(Type = typeof(NGUIText), Member = "ReplaceSpaceWithNewline")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Insert")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(NGUIText), Member = "EndLine")]
	[Calls(Type = typeof(NGUIText), Member = "ReplaceSpaceWithNewline")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(NGUIText), Member = "EndLine")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
	[Calls(Type = typeof(NGUIText), Member = "GetSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(NGUIText), Member = "Prepare")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public static bool WrapText(string text, out string finalText, bool keepCharCount, bool bulleted, int bulletSpacing)
	{
		finalText = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	public static void Print(string text, BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, UILabel printedLabel)
	{
	}

	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(NGUIText), Member = "GetSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(NGUIText), Member = "Prepare")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
	public static void PrintApproximateCharacterPositions(string text, BetterList<Vector3> verts, BetterList<int> indices)
	{
	}

	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[CalledBy(Type = typeof(TextInputField), Member = "GetCursorLocation")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(NGUIText), Member = "GetSymbol")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NGUIText), Member = "Prepare")]
	public static void PrintExactCharacterPositions(string text, BetterList<Vector3> verts, BetterList<int> indices)
	{
	}

	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(UILabel), Member = "PrintOverlay")]
	[CalledBy(Type = typeof(UILabel), Member = "PrintOverlay")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
	[Calls(Type = typeof(NGUIText), Member = "GetSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(NGUIText), Member = "Prepare")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	public static void PrintCaretAndSelection(string text, int start, int end, BetterList<Vector3> caret, BetterList<Vector3> highlight)
	{
	}

	[Calls(Type = typeof(Application), Member = "get_isPlaying")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "get_Actions")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "get_Actions")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(NGUIText), Member = "GetSymbol")]
	[CallsUnknownMethods(Count = 49)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private static BMSymbol GetDynamicSymbol(string text, int offset, int textLength)
	{
		return null;
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonNameForAction")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonNameForAction")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(string), Member = "Insert")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Remove")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(NGUIText), Member = "MaybeReplaceSymbolsWithKeycodes")]
	private static string MaybeReplaceSymbolWithKeycode(string text, ref BMSymbol symbol)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NGUIText), Member = "GetSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "MaybeReplaceSymbolWithKeycode")]
	[CalledBy(Type = typeof(NGUIText), Member = "Prepare")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	private static string MaybeReplaceSymbolsWithKeycodes(string text)
	{
		return null;
	}
}

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

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Font), Member = "RequestCharactersInTexture")]
	[Calls(Type = typeof(Font), Member = "GetCharacterInfo")]
	[Calls(Type = typeof(Font), Member = "RequestCharactersInTexture")]
	[Calls(Type = typeof(Font), Member = "GetCharacterInfo")]
	[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
	public static void Update(bool request)
	{
	}

	[Calls(Type = typeof(NGUIText), Member = "GetSymbol")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[CalledBy(Type = typeof(NGUIText), Member = "CalculateOffsetToFit")]
	[CalledBy(Type = typeof(NGUIText), Member = "CalculatePrintedSize")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Font), Member = "RequestCharactersInTexture")]
	[Calls(Type = typeof(NGUIText), Member = "MaybeReplaceSymbolWithKeycode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public static string Prepare(string text)
	{
		return null;
	}

	[CalledBy(Type = typeof(NGUIText), Member = "CalculatePrintedSize")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NGUIText), Member = "MaybeReplaceSymbolsWithKeycodes")]
	[CalledBy(Type = typeof(NGUIText), Member = "Prepare")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[CalledBy(Type = typeof(NGUIText), Member = "CalculateOffsetToFit")]
	[Calls(Type = typeof(UIFont), Member = "MatchSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "GetDynamicSymbol")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public static BMSymbol GetSymbol(string text, int index, int textLength)
	{
		return null;
	}

	[Calls(Type = typeof(UIFont), Member = "get_bmFont")]
	[CalledBy(Type = typeof(NGUIText), Member = "CalculatePrintedSize")]
	[CalledBy(Type = typeof(NGUIText), Member = "CalculateOffsetToFit")]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	[Calls(Type = typeof(BMGlyph), Member = "GetKerning")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BMFont), Member = "GetGlyph")]
	[Calls(Type = typeof(CharacterInfo), Member = "get_advance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Font), Member = "GetCharacterInfo")]
	public static float GetGlyphWidth(int ch, int prev)
	{
		return default(float);
	}

	[Calls(Type = typeof(BMGlyph), Member = "GetKerning")]
	[Calls(Type = typeof(BMFont), Member = "GetGlyph")]
	[Calls(Type = typeof(UIFont), Member = "get_bmFont")]
	[Calls(Type = typeof(CharacterInfo), Member = "get_advance")]
	[Calls(Type = typeof(Font), Member = "GetCharacterInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public static GlyphInfo GetGlyph(int ch, int prev)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DebuggerStepThrough]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DebuggerHidden]
	public static float ParseAlpha(string text, int index)
	{
		return default(float);
	}

	[DebuggerStepThrough]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIText), Member = "ParseColor24")]
	[DebuggerHidden]
	public static Color ParseColor(string text, int offset)
	{
		return default(Color);
	}

	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NGUITools), Member = "ParseColor")]
	[CalledBy(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(NGUIText), Member = "ParseColor")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	public static Color ParseColor24(string text, int offset)
	{
		return default(Color);
	}

	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[DebuggerStepThrough]
	[DebuggerHidden]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[CallsUnknownMethods(Count = 1)]
	public static Color ParseColor32(string text, int offset)
	{
		return default(Color);
	}

	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(NGUIMath), Member = "ColorToInt")]
	[CallerCount(Count = 0)]
	[DebuggerStepThrough]
	[DebuggerHidden]
	public static string EncodeColor(Color c)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(NGUIMath), Member = "ColorToInt")]
	[Calls(Type = typeof(int), Member = "ToString")]
	public static string EncodeColor(string text, Color c)
	{
		return null;
	}

	[CalledBy(Type = typeof(TypewriterEffect), Member = "Update")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallerCount(Count = 1)]
	[DebuggerStepThrough]
	[DebuggerHidden]
	[CallsUnknownMethods(Count = 1)]
	public static string EncodeAlpha(float a)
	{
		return null;
	}

	[Calls(Type = typeof(int), Member = "ToString")]
	[CallerCount(Count = 0)]
	[DebuggerHidden]
	[Calls(Type = typeof(NGUIMath), Member = "ColorToInt")]
	[DebuggerStepThrough]
	public static string EncodeColor24(Color c)
	{
		return null;
	}

	[Calls(Type = typeof(NGUIMath), Member = "ColorToInt")]
	[CallerCount(Count = 0)]
	[DebuggerStepThrough]
	[Calls(Type = typeof(int), Member = "ToString")]
	[DebuggerHidden]
	public static string EncodeColor32(Color c)
	{
		return null;
	}

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[CalledBy(Type = typeof(TypewriterEffect), Member = "Update")]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	public static bool ParseSymbol(string text, ref int index)
	{
		return default(bool);
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[CallerCount(Count = 0)]
	public static bool IsHex(char ch)
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(NGUIMath), Member = "ColorToInt")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(NGUIMath), Member = "ColorToInt")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[CalledBy(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[CalledBy(Type = typeof(NGUIText), Member = "StripSymbols")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(NGUIText), Member = "ParseColor24")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 2)]
	public static bool ParseSymbol(string text, ref int index, BetterList<Color> colors, bool premultiply, ref int sub, ref bool bold, ref bool italic, ref bool underline, ref bool strike, ref bool ignoreColor)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UILabel), Member = "GetWordAtCharacterIndex")]
	[CalledBy(Type = typeof(NGUITools), Member = "StripSymbols")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(ChatInput), Member = "OnSubmit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "Remove")]
	[CalledBy(Type = typeof(NGUIText), Member = "CalculatePrintedSize")]
	[Calls(Type = typeof(NGUIText), Member = "ParseSymbol")]
	public static string StripSymbols(string text)
	{
		return null;
	}

	[CalledBy(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	public static void Align(BetterList<Vector3> verts, int indexOffset, float printedWidth)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static int GetExactCharacterIndex(BetterList<Vector3> verts, BetterList<int> indices, Vector2 pos)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
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

	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Chars")]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars")]
	[CallerCount(Count = 2)]
	[DebuggerStepThrough]
	[DebuggerHidden]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[CallsUnknownMethods(Count = 2)]
	public static void EndLine(ref StringBuilder s)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Chars")]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[CallerCount(Count = 2)]
	private static void ReplaceSpaceWithNewline(ref StringBuilder s)
	{
	}

	[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
	[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
	[Calls(Type = typeof(NGUIText), Member = "Prepare")]
	[Calls(Type = typeof(NGUIText), Member = "StripSymbols")]
	[Calls(Type = typeof(NGUIText), Member = "GetSymbol")]
	[CallerCount(Count = 3)]
	public static Vector2 CalculatePrintedSize(string text)
	{
		return default(Vector2);
	}

	[CalledBy(Type = typeof(UILabel), Member = "CalculateOffsetToFit")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
	[CalledBy(Type = typeof(NGUIText), Member = "GetEndOfLineThatFits")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(NGUIText), Member = "Prepare")]
	[Calls(Type = typeof(NGUIText), Member = "GetSymbol")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	public static int CalculateOffsetToFit(string text)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIText), Member = "CalculateOffsetToFit")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsUnknownMethods(Count = 1)]
	public static string GetEndOfLineThatFits(string text)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UILabel), Member = "Wrap")]
	[Calls(Type = typeof(NGUIText), Member = "WrapText")]
	[CalledBy(Type = typeof(UILabel), Member = "Wrap")]
	public static bool WrapText(string text, out string finalText)
	{
		finalText = null;
		return default(bool);
	}

	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(NGUIText), Member = "ReplaceSpaceWithNewline")]
	[Calls(Type = typeof(NGUIText), Member = "EndLine")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(NGUIText), Member = "ReplaceSpaceWithNewline")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
	[CalledBy(Type = typeof(UITextList), Member = "Rebuild")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(string), Member = "Insert")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NGUIText), Member = "GetSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "EndLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
	[Calls(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(NGUIText), Member = "Prepare")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	public static bool WrapText(string text, out string finalText, bool keepCharCount, bool bulleted, int bulletSpacing)
	{
		finalText = null;
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	public static void Print(string text, BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, UILabel printedLabel)
	{
	}

	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[Calls(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "GetSymbol")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NGUIText), Member = "Prepare")]
	public static void PrintApproximateCharacterPositions(string text, BetterList<Vector3> verts, BetterList<int> indices)
	{
	}

	[Calls(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "Prepare")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(TextInputField), Member = "GetCursorLocation")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(Type = typeof(NGUIText), Member = "GetSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[Calls(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
	public static void PrintExactCharacterPositions(string text, BetterList<Vector3> verts, BetterList<int> indices)
	{
	}

	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[CalledBy(Type = typeof(UILabel), Member = "PrintOverlay")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[CalledBy(Type = typeof(UILabel), Member = "PrintOverlay")]
	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
	[Calls(Type = typeof(NGUIText), Member = "GetSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(Type = typeof(NGUIText), Member = "Prepare")]
	[Calls(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[CallerCount(Count = 2)]
	public static void PrintCaretAndSelection(string text, int start, int end, BetterList<Vector3> caret, BetterList<Vector3> highlight)
	{
	}

	[Calls(Type = typeof(ReInput.MappingHelper), Member = "get_Actions")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(NGUIText), Member = "GetSymbol")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "get_Actions")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	private static BMSymbol GetDynamicSymbol(string text, int offset, int textLength)
	{
		return null;
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Remove")]
	[Calls(Type = typeof(string), Member = "Insert")]
	[CalledBy(Type = typeof(NGUIText), Member = "Prepare")]
	[CalledBy(Type = typeof(NGUIText), Member = "MaybeReplaceSymbolsWithKeycodes")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonNameForAction")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonNameForAction")]
	private static string MaybeReplaceSymbolWithKeycode(string text, ref BMSymbol symbol)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(NGUIText), Member = "MaybeReplaceSymbolWithKeycode")]
	[Calls(Type = typeof(NGUIText), Member = "GetSymbol")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	private static string MaybeReplaceSymbolsWithKeycodes(string text)
	{
		return null;
	}
}

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

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void Update()
	{
	}

	[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
	[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Font), Member = "RequestCharactersInTexture")]
	[Calls(Type = typeof(Font), Member = "GetCharacterInfo")]
	[CallsUnknownMethods(Count = 3)]
	public static void Update(bool request)
	{
	}

	[CalledBy(Type = typeof(NGUIText), Member = "CalculatePrintedSize")]
	[CalledBy(Type = typeof(NGUIText), Member = "CalculateOffsetToFit")]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[CalledBy(Type = typeof(NGUIText), Member = "Print")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(NGUIText), Member = "GetSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "MaybeReplaceSymbolWithKeycode")]
	[Calls(Type = typeof(Font), Member = "RequestCharactersInTexture")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static string Prepare(string text)
	{
		return null;
	}

	[CalledBy(Type = typeof(NGUIText), Member = "Prepare")]
	[CalledBy(Type = typeof(NGUIText), Member = "CalculatePrintedSize")]
	[CalledBy(Type = typeof(NGUIText), Member = "CalculateOffsetToFit")]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[CalledBy(Type = typeof(NGUIText), Member = "Print")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	[CalledBy(Type = typeof(NGUIText), Member = "MaybeReplaceSymbolsWithKeycodes")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(UIFont), Member = "MatchSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "GetDynamicSymbol")]
	[CallsUnknownMethods(Count = 1)]
	public static BMSymbol GetSymbol(string text, int index, int textLength)
	{
		return null;
	}

	[CalledBy(Type = typeof(NGUIText), Member = "CalculatePrintedSize")]
	[CalledBy(Type = typeof(NGUIText), Member = "CalculateOffsetToFit")]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UIFont), Member = "get_bmFont")]
	[Calls(Type = typeof(BMFont), Member = "GetGlyph")]
	[Calls(Type = typeof(BMGlyph), Member = "GetKerning")]
	[Calls(Type = typeof(Font), Member = "GetCharacterInfo")]
	[Calls(Type = typeof(CharacterInfo), Member = "get_advance")]
	[CallsUnknownMethods(Count = 1)]
	public static float GetGlyphWidth(int ch, int prev)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(NGUIText), Member = "Print")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIFont), Member = "get_bmFont")]
	[Calls(Type = typeof(BMFont), Member = "GetGlyph")]
	[Calls(Type = typeof(BMGlyph), Member = "GetKerning")]
	[Calls(Type = typeof(Font), Member = "GetCharacterInfo")]
	[Calls(Type = typeof(CharacterInfo), Member = "get_advance")]
	[CallsUnknownMethods(Count = 5)]
	public static GlyphInfo GetGlyph(int ch, int prev)
	{
		return null;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static float ParseAlpha(string text, int index)
	{
		return 0f;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIText), Member = "ParseColor24")]
	public static Color ParseColor(string text, int offset)
	{
		return default(Color);
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[CalledBy(Type = typeof(NGUIText), Member = "ParseColor")]
	[CalledBy(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[CalledBy(Type = typeof(NGUITools), Member = "ParseColor")]
	[CallerCount(Count = 3)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public static Color ParseColor24(string text, int offset)
	{
		return default(Color);
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	public static Color ParseColor32(string text, int offset)
	{
		return default(Color);
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIText), Member = "EncodeColor24")]
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
	[CalledBy(Type = typeof(TypewriterEffect), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[CallsUnknownMethods(Count = 1)]
	public static string EncodeAlpha(float a)
	{
		return null;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[CalledBy(Type = typeof(UIItemSlot), Member = "OnTooltip")]
	[CalledBy(Type = typeof(NGUIText), Member = "EncodeColor")]
	[CalledBy(Type = typeof(NGUIText), Member = "EncodeColor")]
	[CalledBy(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[CalledBy(Type = typeof(NGUITools), Member = "EncodeColor")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(NGUIMath), Member = "ColorToInt")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	public static string EncodeColor24(Color c)
	{
		return null;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIMath), Member = "ColorToInt")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	public static string EncodeColor32(Color c)
	{
		return null;
	}

	[CalledBy(Type = typeof(TypewriterEffect), Member = "Update")]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(NGUIText), Member = "ParseSymbol")]
	public static bool ParseSymbol(string text, ref int index)
	{
		return false;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[CallerCount(Count = 0)]
	public static bool IsHex(char ch)
	{
		return false;
	}

	[CalledBy(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[CalledBy(Type = typeof(NGUIText), Member = "StripSymbols")]
	[CalledBy(Type = typeof(NGUIText), Member = "Print")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(NGUIMath), Member = "ColorToInt")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(NGUIText), Member = "ParseColor24")]
	[Calls(Type = typeof(NGUIText), Member = "EncodeColor24")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 4)]
	public static bool ParseSymbol(string text, ref int index, BetterList<Color> colors, bool premultiply, ref int sub, ref bool bold, ref bool italic, ref bool underline, ref bool strike, ref bool ignoreColor)
	{
		return false;
	}

	[CalledBy(Type = typeof(ChatInput), Member = "OnSubmit")]
	[CalledBy(Type = typeof(NGUIText), Member = "CalculatePrintedSize")]
	[CalledBy(Type = typeof(NGUITools), Member = "StripSymbols")]
	[CalledBy(Type = typeof(UILabel), Member = "GetWordAtCharacterIndex")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[Calls(Type = typeof(string), Member = "Remove")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsUnknownMethods(Count = 1)]
	public static string StripSymbols(string text)
	{
		return null;
	}

	[CalledBy(Type = typeof(NGUIText), Member = "Print")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	[CalledBy(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	[CallerCount(Count = 17)]
	[CallsUnknownMethods(Count = 10)]
	public static void Align(BetterList<Vector3> verts, int indexOffset, float printedWidth)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static int GetExactCharacterIndex(BetterList<Vector3> verts, BetterList<int> indices, Vector2 pos)
	{
		return 0;
	}

	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static int GetApproximateCharacterIndex(BetterList<Vector3> verts, BetterList<int> indices, Vector2 pos)
	{
		return 0;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[CallerCount(Count = 0)]
	private static bool IsSpace(int ch)
	{
		return false;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Chars")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsUnknownMethods(Count = 2)]
	public static void EndLine(ref StringBuilder s)
	{
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Chars")]
	[CallsUnknownMethods(Count = 1)]
	private static void ReplaceSpaceWithNewline(ref StringBuilder s)
	{
	}

	[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NGUIText), Member = "StripSymbols")]
	[Calls(Type = typeof(NGUIText), Member = "Prepare")]
	[Calls(Type = typeof(NGUIText), Member = "GetSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsUnknownMethods(Count = 3)]
	public static Vector2 CalculatePrintedSize(string text)
	{
		return default(Vector2);
	}

	[CalledBy(Type = typeof(NGUIText), Member = "GetEndOfLineThatFits")]
	[CalledBy(Type = typeof(UILabel), Member = "CalculateOffsetToFit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NGUIText), Member = "Prepare")]
	[Calls(Type = typeof(NGUIText), Member = "GetSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsUnknownMethods(Count = 5)]
	public static int CalculateOffsetToFit(string text)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIText), Member = "CalculateOffsetToFit")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsUnknownMethods(Count = 1)]
	public static string GetEndOfLineThatFits(string text)
	{
		return null;
	}

	[CalledBy(Type = typeof(UILabel), Member = "Wrap")]
	[CalledBy(Type = typeof(UILabel), Member = "Wrap")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NGUIText), Member = "WrapText")]
	public static bool WrapText(string text, out string finalText)
	{
		finalText = null;
		return false;
	}

	[CalledBy(Type = typeof(NGUIText), Member = "WrapText")]
	[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
	[CalledBy(Type = typeof(UITextList), Member = "Rebuild")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NGUIText), Member = "Prepare")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "GetSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(NGUIText), Member = "EndLine")]
	[Calls(Type = typeof(NGUIText), Member = "ReplaceSpaceWithNewline")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Insert")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static bool WrapText(string text, out string finalText, bool keepCharCount, bool bulleted, int bulletSpacing)
	{
		finalText = null;
		return false;
	}

	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NGUIText), Member = "Prepare")]
	[Calls(Type = typeof(UIFont), Member = "get_uvRect")]
	[Calls(Type = typeof(UIFont), Member = "get_texWidth")]
	[Calls(Type = typeof(UIFont), Member = "get_texHeight")]
	[Calls(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "GetSymbol")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Color32), Member = "op_Implicit")]
	[Calls(Type = typeof(BetterList<>), Member = "Add")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(Type = typeof(BMSymbol), Member = "get_length")]
	[Calls(Type = typeof(NGUIText), Member = "GetGlyph")]
	[Calls(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	[Calls(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 60)]
	public static void Print(string text, BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, UILabel printedLabel)
	{
	}

	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NGUIText), Member = "Prepare")]
	[Calls(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "GetSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public static void PrintApproximateCharacterPositions(string text, BetterList<Vector3> verts, BetterList<int> indices)
	{
	}

	[CalledBy(Type = typeof(NGUIText), Member = "Print")]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[CalledBy(Type = typeof(TextInputField), Member = "GetCursorLocation")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NGUIText), Member = "Prepare")]
	[Calls(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "GetSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsUnknownMethods(Count = 9)]
	public static void PrintExactCharacterPositions(string text, BetterList<Vector3> verts, BetterList<int> indices)
	{
	}

	[CalledBy(Type = typeof(UILabel), Member = "PrintOverlay")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NGUIText), Member = "Prepare")]
	[Calls(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "GetSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
	[Calls(Type = typeof(NGUIText), Member = "Align")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsUnknownMethods(Count = 29)]
	public static void PrintCaretAndSelection(string text, int start, int end, BetterList<Vector3> caret, BetterList<Vector3> highlight)
	{
	}

	[CalledBy(Type = typeof(NGUIText), Member = "GetSymbol")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "get_Actions")]
	[Calls(Type = typeof(BetterList<>), Member = "Add")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private static BMSymbol GetDynamicSymbol(string text, int offset, int textLength)
	{
		return null;
	}

	[CalledBy(Type = typeof(NGUIText), Member = "Prepare")]
	[CalledBy(Type = typeof(NGUIText), Member = "MaybeReplaceSymbolsWithKeycodes")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonNameForAction")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Remove")]
	[Calls(Type = typeof(string), Member = "Insert")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static string MaybeReplaceSymbolWithKeycode(string text, ref BMSymbol symbol)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(NGUIText), Member = "GetSymbol")]
	[Calls(Type = typeof(NGUIText), Member = "MaybeReplaceSymbolWithKeycode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static string MaybeReplaceSymbolsWithKeycodes(string text)
	{
		return null;
	}
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UILabel : UIWidget
{
	public enum Effect
	{
		None,
		Shadow,
		Outline,
		Outline8
	}

	public enum Overflow
	{
		ShrinkContent,
		ClampContent,
		ResizeFreely,
		ResizeHeight
	}

	public enum Crispness
	{
		Never,
		OnDesktop,
		Always
	}

	public Crispness keepCrispWhenShrunk;

	private Font mTrueTypeFont;

	private UIFont mFont;

	private string mText;

	private int mFontSize;

	private int mFontSizeAsianOverride;

	private int mFontSizeCyrillicOverride;

	private int mFontSizeInuktitutOverride;

	private FontStyle mFontStyle;

	private NGUIText.Alignment mAlignment;

	private bool mEncoding;

	private int mMaxLineCount;

	private Effect mEffectStyle;

	private Color mEffectColor;

	private NGUIText.SymbolStyle mSymbols;

	private Vector2 mEffectDistance;

	private Overflow mOverflow;

	private Material mMaterial;

	private bool mApplyGradient;

	private Color mGradientTop;

	private Color mGradientBottom;

	private int mSpacingX;

	private int mSpacingY;

	private bool mUseFloatSpacing;

	private float mFloatSpacingX;

	private float mFloatSpacingY;

	private bool mCapsLock;

	private bool m_Bulleted;

	private int m_BulletSpacing;

	private bool m_AllowSymbolFallback;

	private bool mShrinkToFit;

	private int mMaxLineWidth;

	private int mMaxLineHeight;

	private float mLineWidth;

	private bool mMultiline;

	[NonSerialized]
	private Font mActiveTTF;

	private float mDensity;

	private bool mShouldBeProcessed;

	private string mProcessedText;

	private bool mPremultiply;

	private Vector2 mCalculatedSize;

	private float mScale;

	private int mPrintedSize;

	private int mLastWidth;

	private int mLastHeight;

	private BetterList<UISprite> mDynamicSymbolSprites;

	private static BetterList<UILabel> mList;

	private static Dictionary<Font, int> mFontUsage;

	private static bool mTexRebuildAdded;

	private static BetterList<Vector3> mTempVerts;

	private static BetterList<int> mTempIndices;

	private bool shouldBeProcessed
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CallerCount(Count = 3)]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		set
		{
		}
	}

	public bool capsLock
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public override bool isAnchoredHorizontally
	{
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public override bool isAnchoredVertically
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	public override Material material
	{
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIFont), Member = "get_material")]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(Font), Member = "get_material")]
		get
		{
			return null;
		}
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public UIFont font
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[Calls(Type = typeof(UILabel), Member = "set_bitmapFont")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public UIFont bitmapFont
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UILabel), Member = "set_font")]
		[CalledBy(Type = typeof(UILabel), Member = "set_ambigiousFont")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "RenderFontTest")]
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallerCount(Count = 8)]
		[CallsDeduplicatedMethods(Count = 2)]
		set
		{
		}
	}

	public Font trueTypeFont
	{
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CalledBy(Type = typeof(UILabel), Member = "OnFontChanged")]
		[CalledBy(Type = typeof(UILabel), Member = "OnFontChanged")]
		[CalledBy(Type = typeof(UILabel), Member = "OnInit")]
		[Calls(Type = typeof(UIFont), Member = "get_dynamicFont")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CalledBy(Type = typeof(UILabel), Member = "get_keepCrisp")]
		[CallerCount(Count = 6)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[Calls(Type = typeof(UILabel), Member = "SetActiveFont")]
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		[Calls(Type = typeof(UILabel), Member = "SetActiveFont")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UIWidget), Member = "MarkAsChanged")]
		[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
		[CalledBy(Type = typeof(UILabel), Member = "set_ambigiousFont")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		set
		{
		}
	}

	public UnityEngine.Object ambigiousFont
	{
		[CalledBy(Type = typeof(UILabel), Member = "MakePixelPerfect")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 5)]
		[CalledBy(Type = typeof(UILabel), Member = "ProcessAndRequest")]
		[CalledBy(Type = typeof(UILabel), Member = "AssumeNaturalSize")]
		[CalledBy(Type = typeof(UITextList), Member = "get_isValid")]
		[CalledBy(Type = typeof(UILabel), Member = "MakePixelPerfect")]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UILabel), Member = "set_trueTypeFont")]
		[Calls(Type = typeof(UILabel), Member = "set_bitmapFont")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		set
		{
		}
	}

	public string text
	{
		[CallerCount(Count = 22)]
		[Calls(Type = typeof(string), Member = "ToUpper")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIWidget), Member = "ResizeCollider")]
		[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[CallerCount(Count = 985)]
		[CallsDeduplicatedMethods(Count = 2)]
		set
		{
		}
	}

	public int defaultFontSize
	{
		[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CallAnalysisFailed]
		[CallerCount(Count = 2)]
		get
		{
			return default(int);
		}
	}

	public int fontSize
	{
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[CalledBy(Type = typeof(UITextList), Member = "get_lineHeight")]
		[CalledBy(Type = typeof(TextInputField), Member = "GetCursorLocation")]
		[CalledBy(Type = typeof(DialogueSequenceFP), Member = "Awake")]
		[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
		[CalledBy(Type = typeof(DialogueSequenceFP), Member = "SetupNormalUILabelText")]
		[CalledBy(Type = typeof(Panel_HUD), Member = "Initialize")]
		[Calls(Type = typeof(UIFont), Member = "GetFontSizeModifierValue")]
		[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
		[Calls(Type = typeof(UIFont), Member = "GetFontSizeModifierValue")]
		[CallerCount(Count = 8)]
		[CallsUnknownMethods(Count = 6)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(int);
		}
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CalledBy(Type = typeof(UILabel), Member = "UpgradeFrom265")]
		[CalledBy(Type = typeof(DialogueSequenceFP), Member = "SetupNormalUILabelText")]
		[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
		[CalledBy(Type = typeof(Panel_HUD), Member = "MaintainOriginalObjectSize")]
		[CalledBy(Type = typeof(Panel_Notifications), Member = "SetTitle")]
		[CalledBy(Type = typeof(Panel_Notifications), Member = "SetTitle")]
		[CalledBy(Type = typeof(Panel_Notifications), Member = "SetTitle")]
		[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
		[CalledBy(Type = typeof(Panel_Subtitles), Member = "EnableLargeSubtitles")]
		[CallerCount(Count = 15)]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAccessibilityOptions")]
		[CalledBy(Type = typeof(Panel_Subtitles), Member = "EnableLargeSubtitles")]
		[CalledBy(Type = typeof(Panel_Subtitles), Member = "EnableLargeSubtitles")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAccessibilityOptions")]
		[CalledBy(Type = typeof(Panel_Subtitles), Member = "EnableLargeSubtitles")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAccessibilityOptions")]
		set
		{
		}
	}

	public int fontSizeAsianOverride
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public int fontSizeCyrillicOverride
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int fontSizeInuktitutOverride
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
		set
		{
		}
	}

	public FontStyle fontStyle
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(FontStyle);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
		set
		{
		}
	}

	public NGUIText.Alignment alignment
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(NGUIText.Alignment);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
		set
		{
		}
	}

	public bool applyGradient
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public Color gradientTop
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(Color);
		}
		[Calls(Type = typeof(Color), Member = "op_Equality")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public Color gradientBottom
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(Color);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Color), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public int spacingX
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public int spacingY
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool useFloatSpacing
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float floatSpacingX
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(float);
		}
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(Utils), Member = "Approximately")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float floatSpacingY
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(Utils), Member = "Approximately")]
		set
		{
		}
	}

	public float effectiveSpacingY
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
	}

	public float effectiveSpacingX
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
	}

	private bool keepCrisp
	{
		[Calls(Type = typeof(UILabel), Member = "get_trueTypeFont")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 3)]
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		get
		{
			return default(bool);
		}
	}

	public bool supportEncoding
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public NGUIText.SymbolStyle symbolStyle
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(NGUIText.SymbolStyle);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Overflow overflowMethod
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Overflow);
		}
		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		set
		{
		}
	}

	public int lineWidth
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[Calls(Type = typeof(UIWidget), Member = "set_width")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int lineHeight
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[Calls(Type = typeof(UIWidget), Member = "set_height")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool multiLine
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public override Vector3[] localCorners
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UILabel), Member = "ProcessText")]
		[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
		[CallsUnknownMethods(Count = 9)]
		get
		{
			return null;
		}
	}

	public override Vector3[] worldCorners
	{
		[Calls(Type = typeof(UILabel), Member = "ProcessText")]
		[Calls(Type = typeof(UIWidget), Member = "get_worldCorners")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public override Vector4 drawingDimensions
	{
		[Calls(Type = typeof(UIWidget), Member = "get_drawingDimensions")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UILabel), Member = "ProcessText")]
		get
		{
			return default(Vector4);
		}
	}

	public int maxLineCount
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Effect effectStyle
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(Effect);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Color effectColor
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(Color);
		}
		[Calls(Type = typeof(Color), Member = "op_Equality")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Vector2 effectDistance
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector2);
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Vector2), Member = "op_Inequality")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool shrinkToFit
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string processedText
	{
		[CalledBy(Type = typeof(UIInput), Member = "ProcessEvent")]
		[CalledBy(Type = typeof(TypewriterEffect), Member = "Update")]
		[Calls(Type = typeof(UILabel), Member = "ProcessText")]
		[CallerCount(Count = 7)]
		[CalledBy(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
		[CalledBy(Type = typeof(UILabel), Member = "PrintOverlay")]
		[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
		[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
		[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
		get
		{
			return null;
		}
	}

	public Vector2 printedSize
	{
		[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
		[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
		[Calls(Type = typeof(UILabel), Member = "ProcessText")]
		[CallerCount(Count = 2)]
		get
		{
			return default(Vector2);
		}
	}

	public override Vector2 localSize
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UILabel), Member = "ProcessText")]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return default(Vector2);
		}
	}

	private bool isValid
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
		[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
		[CalledBy(Type = typeof(UILabel), Member = "PrintOverlay")]
		[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		get
		{
			return default(bool);
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "SetActiveFont")]
	[Calls(Type = typeof(UILabel), Member = "get_trueTypeFont")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIWidget), Member = "OnInit")]
	protected override void OnInit()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIRect), Member = "OnDisable")]
	[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
	[Calls(Type = typeof(UILabel), Member = "SetActiveFont")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void OnDisable()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "ClearDynamicSymbolSprites")]
	[CallerCount(Count = 0)]
	protected void PreDisable()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void ControlTypeChanged()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(UILabel), Member = "OnDisable")]
	[CalledBy(Type = typeof(UILabel), Member = "OnInit")]
	[CalledBy(Type = typeof(UILabel), Member = "set_trueTypeFont")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(UILabel), Member = "set_trueTypeFont")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 5)]
	protected void SetActiveFont(Font fnt)
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Font), Member = "RequestCharactersInTexture")]
	[Calls(Type = typeof(UILabel), Member = "get_trueTypeFont")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
	[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
	[Calls(Type = typeof(UILabel), Member = "get_trueTypeFont")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void OnFontChanged(Font font)
	{
	}

	[Calls(Type = typeof(UIWidget), Member = "GetSides")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[CallerCount(Count = 0)]
	public override Vector3[] GetSides(Transform relativeTo)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_fontSize")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(NGUITools), Member = "UpdateWidgetCollider")]
	[CallsUnknownMethods(Count = 2)]
	protected override void UpgradeFrom265()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIWidget), Member = "OnAnchor")]
	[Calls(Type = typeof(UIRect), Member = "get_isFullyAnchored")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	protected override void OnAnchor()
	{
	}

	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CalledBy(Type = typeof(UIInput), Member = "Init")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CalledBy(Type = typeof(UILabel), Member = "set_fontSize")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UILabel), Member = "get_ambigiousFont")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(UILabel), Member = "set_fontSizeAsianOverride")]
	[CalledBy(Type = typeof(UILabel), Member = "set_fontSizeCyrillicOverride")]
	[CalledBy(Type = typeof(UILabel), Member = "set_fontSizeInuktitutOverride")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowCollectibleNote")]
	[CalledBy(Type = typeof(UILabel), Member = "set_fontStyle")]
	[CalledBy(Type = typeof(UILabel), Member = "set_alignment")]
	[CalledBy(Type = typeof(UILabel), Member = "OnStart")]
	[CalledBy(Type = typeof(UILabel), Member = "set_trueTypeFont")]
	[CalledBy(Type = typeof(UILabel), Member = "set_text")]
	private void ProcessAndRequest()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Font), Member = "add_textureRebuilt")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	protected override void OnStart()
	{
	}

	[Calls(Type = typeof(UIWidget), Member = "MarkAsChanged")]
	[CallerCount(Count = 0)]
	public override void MarkAsChanged()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void ProcessText()
	{
	}

	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(NGUIText), Member = "WrapText")]
	[Calls(Type = typeof(NGUIText), Member = "CalculatePrintedSize")]
	[Calls(Type = typeof(UILabel), Member = "get_keepCrisp")]
	[Calls(Type = typeof(UILabel), Member = "get_fontSize")]
	[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
	[Calls(Type = typeof(NGUIText), Member = "Update")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(NGUIText), Member = "CalculatePrintedSize")]
	[Calls(Type = typeof(NGUIText), Member = "CalculatePrintedSize")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallerCount(Count = 34)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UILabel), Member = "get_isValid")]
	[Calls(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UILabel), Member = "get_defaultFontSize")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UILabel), Member = "get_trueTypeFont")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UILabel), Member = "get_keepCrisp")]
	[Calls(Type = typeof(UIRect), Member = "get_root")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Mathf), Member = "Abs")]
	private void ProcessText(bool legacyMode, bool full)
	{
	}

	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(UIWidget), Member = "MakePixelPerfect")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UILabel), Member = "get_ambigiousFont")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UILabel), Member = "get_ambigiousFont")]
	public override void MakePixelPerfect()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "get_ambigiousFont")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	public void AssumeNaturalSize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[Obsolete]
	public int GetCharacterIndex(Vector3 worldPos)
	{
		return default(int);
	}

	[Obsolete]
	[Calls(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[CallerCount(Count = 0)]
	public int GetCharacterIndex(Vector2 localPos)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[CalledBy(Type = typeof(UIInput), Member = "GetCharUnderMouse")]
	[CalledBy(Type = typeof(OpenURLOnClick), Member = "OnClick")]
	[CallerCount(Count = 3)]
	[CallAnalysisFailed]
	public int GetCharacterIndexAtPosition(Vector3 worldPos, bool precise)
	{
		return default(int);
	}

	[Calls(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[Calls(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[Calls(Type = typeof(UILabel), Member = "ApplyOffset")]
	[Calls(Type = typeof(NGUIText), Member = "GetExactCharacterIndex")]
	[Calls(Type = typeof(NGUIText), Member = "GetApproximateCharacterIndex")]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UILabel), Member = "get_processedText")]
	[Calls(Type = typeof(UILabel), Member = "get_isValid")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public int GetCharacterIndexAtPosition(Vector2 localPos, bool precise)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public string GetWordAtPosition(Vector3 worldPos)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public string GetWordAtPosition(Vector2 localPos)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "LastIndexOfAny")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(string), Member = "IndexOfAny")]
	[Calls(Type = typeof(NGUIText), Member = "StripSymbols")]
	[Calls(Type = typeof(string), Member = "Substring")]
	public string GetWordAtCharacterIndex(int characterIndex)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public string GetUrlAtPosition(Vector3 worldPos)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public string GetUrlAtPosition(Vector2 localPos)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(OpenURLOnClick), Member = "OnClick")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetUrlAtCharacterIndex(int characterIndex)
	{
		return null;
	}

	[Calls(Type = typeof(UILabel), Member = "get_defaultFontSize")]
	[Calls(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[Calls(Type = typeof(UILabel), Member = "ApplyOffset")]
	[Calls(Type = typeof(NGUIText), Member = "GetApproximateCharacterIndex")]
	[CalledBy(Type = typeof(UIInput), Member = "ProcessEvent")]
	[CalledBy(Type = typeof(UIInput), Member = "ProcessEvent")]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[CalledBy(Type = typeof(UIInput), Member = "ProcessEvent")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(UILabel), Member = "get_processedText")]
	[Calls(Type = typeof(UILabel), Member = "get_isValid")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	public int GetCharacterIndex(int currentIndex, KeyCode key)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(Color32), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "ApplyOffset")]
	[Calls(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	[Calls(Type = typeof(Color32), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "ApplyOffset")]
	[Calls(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	[Calls(Type = typeof(UILabel), Member = "get_processedText")]
	[Calls(Type = typeof(UILabel), Member = "get_isValid")]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[Calls(Type = typeof(UIGeometry), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIGeometry), Member = "Clear")]
	public void PrintOverlay(int start, int end, UIGeometry caret, UIGeometry highlight, Color caretColor, Color highlightColor)
	{
	}

	[Calls(Type = typeof(UILabel), Member = "ClearDynamicSymbolSprites")]
	[Calls(Type = typeof(NGUIText), Member = "Print")]
	[Calls(Type = typeof(UILabel), Member = "ApplyOffset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIFont), Member = "get_packedFontShader")]
	[Calls(Type = typeof(UILabel), Member = "ApplyShadow")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UILabel), Member = "ApplyShadow")]
	[Calls(Type = typeof(UILabel), Member = "ApplyShadow")]
	[Calls(Type = typeof(UILabel), Member = "ApplyShadow")]
	[Calls(Type = typeof(UILabel), Member = "ApplyShadow")]
	[Calls(Type = typeof(UILabel), Member = "ApplyShadow")]
	[Calls(Type = typeof(UILabel), Member = "ApplyShadow")]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[Calls(Type = typeof(OnPostFillCallback), Member = "Invoke")]
	[Calls(Type = typeof(UILabel), Member = "get_processedText")]
	[Calls(Type = typeof(UILabel), Member = "ApplyShadow")]
	[Calls(Type = typeof(Mathf), Member = "GammaToLinearSpace")]
	[Calls(Type = typeof(Mathf), Member = "GammaToLinearSpace")]
	[Calls(Type = typeof(UIFont), Member = "get_premultipliedAlphaShader")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UILabel), Member = "get_isValid")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "GammaToLinearSpace")]
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CalledBy(Type = typeof(UILabel), Member = "PrintOverlay")]
	[CalledBy(Type = typeof(UILabel), Member = "PrintOverlay")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	public Vector2 ApplyOffset(BetterList<Vector3> verts, int start)
	{
		return default(Vector2);
	}

	[Calls(Type = typeof(Color32), Member = "op_Implicit")]
	[Calls(Type = typeof(UIFont), Member = "get_premultipliedAlphaShader")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CallsUnknownMethods(Count = 32)]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIFont), Member = "get_premultipliedAlphaShader")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Color32), Member = "op_Implicit")]
	public void ApplyShadow(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, int start, int end, float x, float y)
	{
	}

	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(NGUIText), Member = "CalculateOffsetToFit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	public int CalculateOffsetToFit(string text)
	{
		return default(int);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	public void SetCurrentProgress()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	public void SetCurrentPercent()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void SetCurrentSelection()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[Calls(Type = typeof(NGUIText), Member = "WrapText")]
	[CallerCount(Count = 0)]
	public bool Wrap(string text, out string final)
	{
		final = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUIText), Member = "WrapText")]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	public bool Wrap(string text, out string final, int height)
	{
		final = null;
		return default(bool);
	}

	[Calls(Type = typeof(UIFont), Member = "get_dynamicFont")]
	[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(NGUIText), Member = "Update")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIRect), Member = "get_root")]
	[Calls(Type = typeof(UILabel), Member = "get_keepCrisp")]
	[CalledBy(Type = typeof(UILabel), Member = "PrintOverlay")]
	[Calls(Type = typeof(UIFont), Member = "get_isDynamic")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
	[Calls(Type = typeof(UILabel), Member = "get_fontSize")]
	[Calls(Type = typeof(UIFont), Member = "get_packedFontShader")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(TextInputField), Member = "GetCursorLocation")]
	[CalledBy(Type = typeof(UITextList), Member = "Rebuild")]
	[CalledBy(Type = typeof(UILabel), Member = "Wrap")]
	[CalledBy(Type = typeof(UILabel), Member = "Wrap")]
	[CalledBy(Type = typeof(UILabel), Member = "CalculateOffsetToFit")]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "get_trueTypeFont")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	public void UpdateNGUIText()
	{
	}

	[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void AddDynamicSymbolSprite(UISprite uiSprite)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIRect), Member = "get_root")]
	[CalledBy(Type = typeof(UILabel), Member = "PreDisable")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UIRoot), Member = "ReturnDynamicSymbolSpriteToPool")]
	private void ClearDynamicSymbolSprites()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	public int DetermineProcessedLineCount()
	{
		return default(int);
	}

	[Calls(Type = typeof(UIWidget), Member = ".ctor")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Vector2), Member = "get_one")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public UILabel()
	{
	}
}

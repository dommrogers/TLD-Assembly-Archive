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
			return false;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool capsLock
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public override bool isAnchoredHorizontally
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public override bool isAnchoredVertically
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public override Material material
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIFont), Member = "get_material")]
		[Calls(Type = typeof(Font), Member = "get_material")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public UIFont font
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UILabel), Member = "set_bitmapFont")]
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
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UILabel), Member = "set_font")]
		[CalledBy(Type = typeof(UILabel), Member = "set_ambigiousFont")]
		[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "RenderFontTest")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public Font trueTypeFont
	{
		[CalledBy(Type = typeof(UILabel), Member = "get_keepCrisp")]
		[CalledBy(Type = typeof(UILabel), Member = "OnInit")]
		[CalledBy(Type = typeof(UILabel), Member = "OnFontChanged")]
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(UIFont), Member = "get_dynamicFont")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CalledBy(Type = typeof(UILabel), Member = "set_ambigiousFont")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UILabel), Member = "SetActiveFont")]
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
		[Calls(Type = typeof(UIWidget), Member = "MarkAsChanged")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public UnityEngine.Object ambigiousFont
	{
		[CalledBy(Type = typeof(UILabel), Member = "ProcessAndRequest")]
		[CalledBy(Type = typeof(UILabel), Member = "AssumeNaturalSize")]
		[CalledBy(Type = typeof(UITextList), Member = "get_isValid")]
		[CallerCount(Count = 3)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UILabel), Member = "set_bitmapFont")]
		[Calls(Type = typeof(UILabel), Member = "set_trueTypeFont")]
		set
		{
		}
	}

	public string text
	{
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(string), Member = "ToUpper")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 1029)]
		[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
		[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
		[Calls(Type = typeof(UIWidget), Member = "ResizeCollider")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public int defaultFontSize
	{
		[CallAnalysisFailed]
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
		[CallerCount(Count = 2)]
		get
		{
			return 0;
		}
	}

	public int fontSize
	{
		[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[CalledBy(Type = typeof(UITextList), Member = "get_lineHeight")]
		[CalledBy(Type = typeof(TextInputField), Member = "GetCursorLocation")]
		[CalledBy(Type = typeof(DialogueSequenceFP), Member = "Awake")]
		[CalledBy(Type = typeof(DialogueSequenceFP), Member = "SetupNormalUILabelText")]
		[CalledBy(Type = typeof(Panel_HUD), Member = "Initialize")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
		[Calls(Type = typeof(UIFont), Member = "GetFontSizeModifierValue")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
		set
		{
		}
	}

	public int fontSizeAsianOverride
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
		set
		{
		}
	}

	public int fontSizeCyrillicOverride
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
		set
		{
		}
	}

	public int fontSizeInuktitutOverride
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
		set
		{
		}
	}

	public FontStyle fontStyle
	{
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
		[CallerCount(Count = 0)]
		get
		{
			return false;
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
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public Color gradientBottom
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Color);
		}
		[CallerCount(Count = 0)]
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
			return 0;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public int spacingY
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public bool useFloatSpacing
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float floatSpacingX
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Utils), Member = "Approximately")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public float floatSpacingY
	{
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Utils), Member = "Approximately")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public float effectiveSpacingY
	{
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
	}

	public float effectiveSpacingX
	{
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
	}

	private bool keepCrisp
	{
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UILabel), Member = "get_trueTypeFont")]
		get
		{
			return false;
		}
	}

	public bool supportEncoding
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
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
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int lineWidth
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return 0;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIWidget), Member = "set_width")]
		set
		{
		}
	}

	public int lineHeight
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIWidget), Member = "set_height")]
		set
		{
		}
	}

	public bool multiLine
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
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
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	public override Vector3[] worldCorners
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UILabel), Member = "ProcessText")]
		[Calls(Type = typeof(UIWidget), Member = "get_worldCorners")]
		get
		{
			return null;
		}
	}

	public override Vector4 drawingDimensions
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UILabel), Member = "ProcessText")]
		[Calls(Type = typeof(UIWidget), Member = "get_drawingDimensions")]
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
			return 0;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public Effect effectStyle
	{
		[DeduplicatedMethod]
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
			return false;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string processedText
	{
		[CalledBy(Type = typeof(TypewriterEffect), Member = "Update")]
		[CalledBy(Type = typeof(UIInput), Member = "ProcessEvent")]
		[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
		[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
		[CalledBy(Type = typeof(UILabel), Member = "PrintOverlay")]
		[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
		[CalledBy(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(UILabel), Member = "ProcessText")]
		get
		{
			return null;
		}
	}

	public Vector2 printedSize
	{
		[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
		[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UILabel), Member = "ProcessText")]
		get
		{
			return default(Vector2);
		}
	}

	public override Vector2 localSize
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UILabel), Member = "ProcessText")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(Vector2);
		}
	}

	private bool isValid
	{
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
		[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
		[CalledBy(Type = typeof(UILabel), Member = "PrintOverlay")]
		[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
		[CallerCount(Count = 5)]
		get
		{
			return false;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "OnInit")]
	[Calls(Type = typeof(BetterList<>), Member = "Add")]
	[Calls(Type = typeof(UILabel), Member = "get_trueTypeFont")]
	[Calls(Type = typeof(UILabel), Member = "SetActiveFont")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnInit()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "SetActiveFont")]
	[Calls(Type = typeof(BetterList<>), Member = "Remove")]
	[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
	[Calls(Type = typeof(UIRect), Member = "OnDisable")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "ClearDynamicSymbolSprites")]
	protected void PreDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ControlTypeChanged()
	{
	}

	[CalledBy(Type = typeof(UILabel), Member = "set_trueTypeFont")]
	[CalledBy(Type = typeof(UILabel), Member = "OnInit")]
	[CalledBy(Type = typeof(UILabel), Member = "OnDisable")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	protected void SetActiveFont(Font fnt)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "get_trueTypeFont")]
	[Calls(Type = typeof(Font), Member = "RequestCharactersInTexture")]
	[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
	[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
	[CallsUnknownMethods(Count = 2)]
	private static void OnFontChanged(Font font)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(UIWidget), Member = "GetSides")]
	public override Vector3[] GetSides(Transform relativeTo)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
	[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
	[Calls(Type = typeof(NGUITools), Member = "UpdateWidgetCollider")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected override void UpgradeFrom265()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIWidget), Member = "OnAnchor")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnAnchor()
	{
	}

	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CalledBy(Type = typeof(UIInput), Member = "Init")]
	[CalledBy(Type = typeof(UILabel), Member = "set_trueTypeFont")]
	[CalledBy(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(UILabel), Member = "set_fontSize")]
	[CalledBy(Type = typeof(UILabel), Member = "set_fontSizeAsianOverride")]
	[CalledBy(Type = typeof(UILabel), Member = "set_fontSizeCyrillicOverride")]
	[CalledBy(Type = typeof(UILabel), Member = "set_fontSizeInuktitutOverride")]
	[CalledBy(Type = typeof(UILabel), Member = "set_fontStyle")]
	[CalledBy(Type = typeof(UILabel), Member = "set_alignment")]
	[CalledBy(Type = typeof(UILabel), Member = "UpgradeFrom265")]
	[CalledBy(Type = typeof(UILabel), Member = "OnStart")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "SetupNormalUILabelText")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowCollectibleNote")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "MaintainOriginalObjectSize")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAccessibilityOptions")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "EnableLargeSubtitles")]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(UILabel), Member = "get_ambigiousFont")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	private void ProcessAndRequest()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Font), Member = "add_textureRebuilt")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	protected override void OnStart()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "MarkAsChanged")]
	public override void MarkAsChanged()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ProcessText()
	{
	}

	[CallerCount(Count = 32)]
	[Calls(Type = typeof(UILabel), Member = "get_isValid")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UILabel), Member = "get_defaultFontSize")]
	[Calls(Type = typeof(UILabel), Member = "get_trueTypeFont")]
	[Calls(Type = typeof(UILabel), Member = "get_keepCrisp")]
	[Calls(Type = typeof(UIRect), Member = "get_root")]
	[Calls(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[Calls(Type = typeof(Transform), Member = "set_localScale")]
	[Calls(Type = typeof(UILabel), Member = "get_fontSize")]
	[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
	[Calls(Type = typeof(NGUIText), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "get_text")]
	[Calls(Type = typeof(NGUIText), Member = "WrapText")]
	[Calls(Type = typeof(NGUIText), Member = "CalculatePrintedSize")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 18)]
	private void ProcessText(bool legacyMode, bool full)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override void MakePixelPerfect()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "get_ambigiousFont")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void AssumeNaturalSize()
	{
	}

	[Obsolete("Use UILabel.GetCharacterAtPosition instead")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	public int GetCharacterIndex(Vector3 worldPos)
	{
		return 0;
	}

	[Obsolete("Use UILabel.GetCharacterAtPosition instead")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	public int GetCharacterIndex(Vector2 localPos)
	{
		return 0;
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(OpenURLOnClick), Member = "OnClick")]
	[CalledBy(Type = typeof(UIInput), Member = "GetCharUnderMouse")]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[CallerCount(Count = 3)]
	public int GetCharacterIndexAtPosition(Vector3 worldPos, bool precise)
	{
		return 0;
	}

	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "get_isValid")]
	[Calls(Type = typeof(UILabel), Member = "get_processedText")]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[Calls(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[Calls(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	[Calls(Type = typeof(UILabel), Member = "ApplyOffset")]
	[Calls(Type = typeof(NGUIText), Member = "GetApproximateCharacterIndex")]
	[CallsUnknownMethods(Count = 6)]
	public int GetCharacterIndexAtPosition(Vector2 localPos, bool precise)
	{
		return 0;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public string GetWordAtPosition(Vector3 worldPos)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public string GetWordAtPosition(Vector2 localPos)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "LastIndexOfAny")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[Calls(Type = typeof(string), Member = "IndexOfAny")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(NGUIText), Member = "StripSymbols")]
	[CallsUnknownMethods(Count = 2)]
	public string GetWordAtCharacterIndex(int characterIndex)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
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

	[CalledBy(Type = typeof(OpenURLOnClick), Member = "OnClick")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsUnknownMethods(Count = 1)]
	public string GetUrlAtCharacterIndex(int characterIndex)
	{
		return null;
	}

	[CalledBy(Type = typeof(UIInput), Member = "ProcessEvent")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UILabel), Member = "get_isValid")]
	[Calls(Type = typeof(UILabel), Member = "get_processedText")]
	[Calls(Type = typeof(UILabel), Member = "get_defaultFontSize")]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[Calls(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[Calls(Type = typeof(UILabel), Member = "ApplyOffset")]
	[Calls(Type = typeof(NGUIText), Member = "GetApproximateCharacterIndex")]
	[CallsUnknownMethods(Count = 2)]
	public int GetCharacterIndex(int currentIndex, KeyCode key)
	{
		return 0;
	}

	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIGeometry), Member = "Clear")]
	[Calls(Type = typeof(UILabel), Member = "get_isValid")]
	[Calls(Type = typeof(UILabel), Member = "get_processedText")]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[Calls(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	[Calls(Type = typeof(UILabel), Member = "ApplyOffset")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public void PrintOverlay(int start, int end, UIGeometry caret, UIGeometry highlight, Color caretColor, Color highlightColor)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "get_isValid")]
	[Calls(Type = typeof(UIFont), Member = "get_premultipliedAlphaShader")]
	[Calls(Type = typeof(Mathf), Member = "GammaToLinearSpace")]
	[Calls(Type = typeof(UILabel), Member = "get_processedText")]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[Calls(Type = typeof(UILabel), Member = "ClearDynamicSymbolSprites")]
	[Calls(Type = typeof(NGUIText), Member = "Print")]
	[Calls(Type = typeof(UILabel), Member = "ApplyOffset")]
	[Calls(Type = typeof(UIFont), Member = "get_packedFontShader")]
	[Calls(Type = typeof(UILabel), Member = "ApplyShadow")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[CalledBy(Type = typeof(UILabel), Member = "PrintOverlay")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[CallsUnknownMethods(Count = 4)]
	public Vector2 ApplyOffset(BetterList<Vector3> verts, int start)
	{
		return default(Vector2);
	}

	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UIFont), Member = "get_premultipliedAlphaShader")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void ApplyShadow(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, int start, int end, float x, float y)
	{
	}

	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[Calls(Type = typeof(NGUIText), Member = "CalculateOffsetToFit")]
	public int CalculateOffsetToFit(string text)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 2)]
	public void SetCurrentProgress()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 4)]
	public void SetCurrentPercent()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	public void SetCurrentSelection()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[Calls(Type = typeof(NGUIText), Member = "WrapText")]
	public bool Wrap(string text, out string final)
	{
		final = null;
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[Calls(Type = typeof(NGUIText), Member = "WrapText")]
	public bool Wrap(string text, out string final, int height)
	{
		final = null;
		return false;
	}

	[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[CalledBy(Type = typeof(UILabel), Member = "PrintOverlay")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CalledBy(Type = typeof(UILabel), Member = "CalculateOffsetToFit")]
	[CalledBy(Type = typeof(UILabel), Member = "Wrap")]
	[CalledBy(Type = typeof(UILabel), Member = "Wrap")]
	[CalledBy(Type = typeof(UITextList), Member = "Rebuild")]
	[CalledBy(Type = typeof(TextInputField), Member = "GetCursorLocation")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(UILabel), Member = "get_trueTypeFont")]
	[Calls(Type = typeof(UIFont), Member = "get_packedFontShader")]
	[Calls(Type = typeof(UILabel), Member = "get_fontSize")]
	[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
	[Calls(Type = typeof(UIFont), Member = "get_isDynamic")]
	[Calls(Type = typeof(UIFont), Member = "get_dynamicFont")]
	[Calls(Type = typeof(UILabel), Member = "get_keepCrisp")]
	[Calls(Type = typeof(UIRect), Member = "get_root")]
	[Calls(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(NGUIText), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	public void UpdateNGUIText()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BetterList<>), Member = "Add")]
	[CallsUnknownMethods(Count = 1)]
	public void AddDynamicSymbolSprite(UISprite uiSprite)
	{
	}

	[CalledBy(Type = typeof(UILabel), Member = "PreDisable")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIRect), Member = "get_root")]
	[Calls(Type = typeof(UIRoot), Member = "ReturnDynamicSymbolSpriteToPool")]
	[CallsUnknownMethods(Count = 2)]
	private void ClearDynamicSymbolSprites()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	public int DetermineProcessedLineCount()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = ".ctor")]
	public UILabel()
	{
	}
}

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
			return default(bool);
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
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public override bool isAnchoredVertically
	{
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
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
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[CallerCount(Count = 8)]
		[CalledBy(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(UILabel), Member = "set_ambigiousFont")]
		[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "RenderFontTest")]
		[CalledBy(Type = typeof(UILabel), Member = "set_font")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public Font trueTypeFont
	{
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CalledBy(Type = typeof(UILabel), Member = "OnFontChanged")]
		[CalledBy(Type = typeof(UILabel), Member = "OnInit")]
		[CalledBy(Type = typeof(UILabel), Member = "get_keepCrisp")]
		[Calls(Type = typeof(UIFont), Member = "get_dynamicFont")]
		[CallerCount(Count = 6)]
		[CalledBy(Type = typeof(UILabel), Member = "OnFontChanged")]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		[Calls(Type = typeof(UILabel), Member = "SetActiveFont")]
		[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
		[Calls(Type = typeof(UIWidget), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CalledBy(Type = typeof(UILabel), Member = "set_ambigiousFont")]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UILabel), Member = "SetActiveFont")]
		set
		{
		}
	}

	public UnityEngine.Object ambigiousFont
	{
		[CallerCount(Count = 3)]
		[CalledBy(Type = typeof(UILabel), Member = "ProcessAndRequest")]
		[CalledBy(Type = typeof(UILabel), Member = "AssumeNaturalSize")]
		[CalledBy(Type = typeof(UITextList), Member = "get_isValid")]
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
		[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
		[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
		[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
		[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
		[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
		[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "ToUpper")]
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
		[CallerCount(Count = 9)]
		[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
		get
		{
			return null;
		}
		[CallerCount(Count = 964)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
		[Calls(Type = typeof(UIWidget), Member = "ResizeCollider")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public int defaultFontSize
	{
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
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
		[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
		[Calls(Type = typeof(UIFont), Member = "GetFontSizeModifierValue")]
		[Calls(Type = typeof(UIFont), Member = "GetFontSizeModifierValue")]
		[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
		[CallerCount(Count = 8)]
		[CalledBy(Type = typeof(DialogueSequenceFP), Member = "SetupNormalUILabelText")]
		[CalledBy(Type = typeof(TextInputField), Member = "GetCursorLocation")]
		[CalledBy(Type = typeof(DialogueSequenceFP), Member = "Awake")]
		[CalledBy(Type = typeof(Panel_HUD), Member = "Initialize")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[CalledBy(Type = typeof(UITextList), Member = "get_lineHeight")]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
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
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int fontSizeInuktitutOverride
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public FontStyle fontStyle
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(FontStyle);
		}
		[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
		[CallerCount(Count = 0)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
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
			return default(bool);
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
			return default(float);
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
			return default(float);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[Calls(Type = typeof(UILabel), Member = "get_trueTypeFont")]
		[CallerCount(Count = 3)]
		get
		{
			return default(bool);
		}
	}

	public bool supportEncoding
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 2)]
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
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
			return default(bool);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public override Vector3[] localCorners
	{
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UILabel), Member = "ProcessText")]
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
			return default(int);
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Effect effectStyle
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
			return default(bool);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string processedText
	{
		[CalledBy(Type = typeof(TypewriterEffect), Member = "Update")]
		[Calls(Type = typeof(UILabel), Member = "ProcessText")]
		[CallerCount(Count = 7)]
		[CalledBy(Type = typeof(UIInput), Member = "ProcessEvent")]
		[CalledBy(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
		[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
		[CalledBy(Type = typeof(UILabel), Member = "PrintOverlay")]
		[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
		[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
		get
		{
			return null;
		}
	}

	public Vector2 printedSize
	{
		[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
		[Calls(Type = typeof(UILabel), Member = "ProcessText")]
		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
		get
		{
			return default(Vector2);
		}
	}

	public override Vector2 localSize
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(UILabel), Member = "ProcessText")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(Vector2);
		}
	}

	private bool isValid
	{
		[CallerCount(Count = 5)]
		[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
		[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
		[CalledBy(Type = typeof(UILabel), Member = "PrintOverlay")]
		[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		get
		{
			return default(bool);
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "SetActiveFont")]
	[Calls(Type = typeof(UILabel), Member = "get_trueTypeFont")]
	[Calls(Type = typeof(UIWidget), Member = "OnInit")]
	[CallerCount(Count = 0)]
	protected override void OnInit()
	{
	}

	[Calls(Type = typeof(UIRect), Member = "OnDisable")]
	[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
	[Calls(Type = typeof(UILabel), Member = "SetActiveFont")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "ClearDynamicSymbolSprites")]
	protected void PreDisable()
	{
	}

	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Contains")]
	public void ControlTypeChanged()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(UILabel), Member = "set_trueTypeFont")]
	[CalledBy(Type = typeof(UILabel), Member = "set_trueTypeFont")]
	[CalledBy(Type = typeof(UILabel), Member = "OnInit")]
	[CalledBy(Type = typeof(UILabel), Member = "OnDisable")]
	[CallsUnknownMethods(Count = 2)]
	protected void SetActiveFont(Font fnt)
	{
	}

	[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
	[Calls(Type = typeof(Font), Member = "RequestCharactersInTexture")]
	[Calls(Type = typeof(UILabel), Member = "get_trueTypeFont")]
	[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "get_trueTypeFont")]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(NGUITools), Member = "UpdateWidgetCollider")]
	protected override void UpgradeFrom265()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIWidget), Member = "OnAnchor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	protected override void OnAnchor()
	{
	}

	[CallerCount(Count = 24)]
	[Calls(Type = typeof(UILabel), Member = "get_ambigiousFont")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	private void ProcessAndRequest()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Font), Member = "add_textureRebuilt")]
	protected override void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
	[CallsUnknownMethods(Count = 4)]
	protected override void OnStart()
	{
	}

	[Calls(Type = typeof(UIWidget), Member = "MarkAsChanged")]
	[CallerCount(Count = 0)]
	public override void MarkAsChanged()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ProcessText()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "get_keepCrisp")]
	[Calls(Type = typeof(UILabel), Member = "get_fontSize")]
	[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
	[Calls(Type = typeof(UILabel), Member = "get_text")]
	[Calls(Type = typeof(NGUIText), Member = "WrapText")]
	[Calls(Type = typeof(NGUIText), Member = "CalculatePrintedSize")]
	[Calls(Type = typeof(NGUIText), Member = "Update")]
	[Calls(Type = typeof(NGUIText), Member = "CalculatePrintedSize")]
	[Calls(Type = typeof(NGUIText), Member = "CalculatePrintedSize")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Transform), Member = "set_localScale")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Transform), Member = "set_localScale")]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "get_root")]
	[Calls(Type = typeof(UILabel), Member = "get_keepCrisp")]
	[Calls(Type = typeof(UILabel), Member = "get_trueTypeFont")]
	[Calls(Type = typeof(UILabel), Member = "get_defaultFontSize")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
	[Calls(Type = typeof(UILabel), Member = "get_isValid")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 32)]
	private void ProcessText(bool legacyMode, bool full)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override void MakePixelPerfect()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(UILabel), Member = "get_ambigiousFont")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void AssumeNaturalSize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[Obsolete("Use UILabel.GetCharacterAtPosition instead")]
	public int GetCharacterIndex(Vector3 worldPos)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[Obsolete("Use UILabel.GetCharacterAtPosition instead")]
	public int GetCharacterIndex(Vector2 localPos)
	{
		return default(int);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(OpenURLOnClick), Member = "OnClick")]
	[CalledBy(Type = typeof(UIInput), Member = "GetCharUnderMouse")]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	public int GetCharacterIndexAtPosition(Vector3 worldPos, bool precise)
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[Calls(Type = typeof(UILabel), Member = "get_isValid")]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[Calls(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[Calls(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	[Calls(Type = typeof(UILabel), Member = "ApplyOffset")]
	[Calls(Type = typeof(NGUIText), Member = "GetApproximateCharacterIndex")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UILabel), Member = "get_processedText")]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(NGUIText), Member = "StripSymbols")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "IndexOfAny")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[Calls(Type = typeof(string), Member = "LastIndexOfAny")]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public string GetUrlAtPosition(Vector2 localPos)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CalledBy(Type = typeof(OpenURLOnClick), Member = "OnClick")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	public string GetUrlAtCharacterIndex(int characterIndex)
	{
		return null;
	}

	[Calls(Type = typeof(UILabel), Member = "get_processedText")]
	[CalledBy(Type = typeof(UIInput), Member = "ProcessEvent")]
	[CalledBy(Type = typeof(UIInput), Member = "ProcessEvent")]
	[CalledBy(Type = typeof(UIInput), Member = "ProcessEvent")]
	[Calls(Type = typeof(NGUIText), Member = "GetApproximateCharacterIndex")]
	[Calls(Type = typeof(UILabel), Member = "ApplyOffset")]
	[Calls(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[Calls(Type = typeof(UILabel), Member = "get_defaultFontSize")]
	[CalledBy(Type = typeof(UIInput), Member = "ProcessEvent")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UILabel), Member = "get_isValid")]
	public int GetCharacterIndex(int currentIndex, KeyCode key)
	{
		return default(int);
	}

	[Calls(Type = typeof(UILabel), Member = "ApplyOffset")]
	[Calls(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[Calls(Type = typeof(UILabel), Member = "get_processedText")]
	[Calls(Type = typeof(UILabel), Member = "get_isValid")]
	[Calls(Type = typeof(UIGeometry), Member = "Clear")]
	[Calls(Type = typeof(UIGeometry), Member = "Clear")]
	[Calls(Type = typeof(UILabel), Member = "ApplyOffset")]
	[Calls(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 2)]
	public void PrintOverlay(int start, int end, UIGeometry caret, UIGeometry highlight, Color caretColor, Color highlightColor)
	{
	}

	[Calls(Type = typeof(NGUIText), Member = "Print")]
	[Calls(Type = typeof(UILabel), Member = "ApplyShadow")]
	[Calls(Type = typeof(UILabel), Member = "ApplyShadow")]
	[Calls(Type = typeof(UIFont), Member = "get_packedFontShader")]
	[Calls(Type = typeof(UILabel), Member = "ApplyOffset")]
	[Calls(Type = typeof(UILabel), Member = "get_processedText")]
	[Calls(Type = typeof(UILabel), Member = "ApplyShadow")]
	[Calls(Type = typeof(UILabel), Member = "ApplyShadow")]
	[Calls(Type = typeof(UILabel), Member = "ApplyShadow")]
	[Calls(Type = typeof(UILabel), Member = "ApplyShadow")]
	[Calls(Type = typeof(UILabel), Member = "ApplyShadow")]
	[Calls(Type = typeof(UILabel), Member = "ApplyShadow")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "ClearDynamicSymbolSprites")]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[Calls(Type = typeof(UILabel), Member = "get_isValid")]
	[Calls(Type = typeof(Mathf), Member = "GammaToLinearSpace")]
	[Calls(Type = typeof(Mathf), Member = "GammaToLinearSpace")]
	[Calls(Type = typeof(Mathf), Member = "GammaToLinearSpace")]
	[Calls(Type = typeof(UIFont), Member = "get_premultipliedAlphaShader")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CalledBy(Type = typeof(UILabel), Member = "PrintOverlay")]
	[CalledBy(Type = typeof(UILabel), Member = "PrintOverlay")]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	public Vector2 ApplyOffset(BetterList<Vector3> verts, int start)
	{
		return default(Vector2);
	}

	[Calls(Type = typeof(UIFont), Member = "get_premultipliedAlphaShader")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[Calls(Type = typeof(UIFont), Member = "get_premultipliedAlphaShader")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	public void ApplyShadow(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, int start, int end, float x, float y)
	{
	}

	[Calls(Type = typeof(NGUIText), Member = "CalculateOffsetToFit")]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[CallerCount(Count = 2)]
	public int CalculateOffsetToFit(string text)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 0)]
	public void SetCurrentProgress()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 4)]
	public void SetCurrentPercent()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 0)]
	public void SetCurrentSelection()
	{
	}

	[Calls(Type = typeof(NGUIText), Member = "WrapText")]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[CallerCount(Count = 0)]
	public bool Wrap(string text, out string final)
	{
		final = null;
		return default(bool);
	}

	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIText), Member = "WrapText")]
	public bool Wrap(string text, out string final, int height)
	{
		final = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[CalledBy(Type = typeof(UILabel), Member = "PrintOverlay")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CalledBy(Type = typeof(UILabel), Member = "CalculateOffsetToFit")]
	[CalledBy(Type = typeof(UILabel), Member = "Wrap")]
	[CalledBy(Type = typeof(UILabel), Member = "Wrap")]
	[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(NGUIText), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
	[Calls(Type = typeof(UIRect), Member = "get_root")]
	[Calls(Type = typeof(UILabel), Member = "get_keepCrisp")]
	[Calls(Type = typeof(UIFont), Member = "get_dynamicFont")]
	[CalledBy(Type = typeof(TextInputField), Member = "GetCursorLocation")]
	[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
	[Calls(Type = typeof(UILabel), Member = "get_fontSize")]
	[Calls(Type = typeof(UIFont), Member = "get_packedFontShader")]
	[Calls(Type = typeof(UILabel), Member = "get_trueTypeFont")]
	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(UITextList), Member = "Rebuild")]
	[Calls(Type = typeof(UIFont), Member = "get_isDynamic")]
	public void UpdateNGUIText()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void AddDynamicSymbolSprite(UISprite uiSprite)
	{
	}

	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CalledBy(Type = typeof(UILabel), Member = "PreDisable")]
	[Calls(Type = typeof(UIRoot), Member = "ReturnDynamicSymbolSpriteToPool")]
	[Calls(Type = typeof(UIRect), Member = "get_root")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void ClearDynamicSymbolSprites()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	public int DetermineProcessedLineCount()
	{
		return default(int);
	}

	[Calls(Type = typeof(UIWidget), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public UILabel()
	{
	}
}

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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
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
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		get
		{
			return default(bool);
		}
	}

	public override bool isAnchoredVertically
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

	public override Material material
	{
		[Calls(Type = typeof(UIFont), Member = "get_material")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Font), Member = "get_material")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(UILabel), Member = "set_ambigiousFont")]
		[CalledBy(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(UILabel), Member = "set_font")]
		[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "RenderFontTest")]
		[CallerCount(Count = 8)]
		set
		{
		}
	}

	public Font trueTypeFont
	{
		[CalledBy(Type = typeof(UILabel), Member = "get_keepCrisp")]
		[CalledBy(Type = typeof(UILabel), Member = "OnInit")]
		[CalledBy(Type = typeof(UILabel), Member = "OnFontChanged")]
		[CalledBy(Type = typeof(UILabel), Member = "OnFontChanged")]
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[Calls(Type = typeof(UIFont), Member = "get_dynamicFont")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 6)]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(UILabel), Member = "set_ambigiousFont")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[Calls(Type = typeof(UIWidget), Member = "MarkAsChanged")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
		[Calls(Type = typeof(UILabel), Member = "SetActiveFont")]
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		[Calls(Type = typeof(UILabel), Member = "SetActiveFont")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		set
		{
		}
	}

	public UnityEngine.Object ambigiousFont
	{
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CalledBy(Type = typeof(UITextList), Member = "get_isValid")]
		[CalledBy(Type = typeof(UILabel), Member = "AssumeNaturalSize")]
		[CalledBy(Type = typeof(UILabel), Member = "MakePixelPerfect")]
		[CalledBy(Type = typeof(UILabel), Member = "MakePixelPerfect")]
		[CalledBy(Type = typeof(UILabel), Member = "ProcessAndRequest")]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UILabel), Member = "set_bitmapFont")]
		[Calls(Type = typeof(UILabel), Member = "set_trueTypeFont")]
		set
		{
		}
	}

	public string text
	{
		[CallerCount(Count = 9)]
		[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
		[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
		[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
		[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
		[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
		[Calls(Type = typeof(string), Member = "ToUpper")]
		[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
		[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
		[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
		get
		{
			return null;
		}
		[Calls(Type = typeof(UIWidget), Member = "ResizeCollider")]
		[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 958)]
		set
		{
		}
	}

	public int defaultFontSize
	{
		[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CallAnalysisFailed]
		get
		{
			return default(int);
		}
	}

	public int fontSize
	{
		[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
		[Calls(Type = typeof(UIFont), Member = "GetFontSizeModifierValue")]
		[Calls(Type = typeof(UIFont), Member = "GetFontSizeModifierValue")]
		[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
		[CallerCount(Count = 8)]
		[CalledBy(Type = typeof(TextInputField), Member = "GetCursorLocation")]
		[CalledBy(Type = typeof(UITextList), Member = "get_lineHeight")]
		[CalledBy(Type = typeof(DialogueSequenceFP), Member = "Awake")]
		[CalledBy(Type = typeof(DialogueSequenceFP), Member = "SetupNormalUILabelText")]
		[CalledBy(Type = typeof(Panel_HUD), Member = "Initialize")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		get
		{
			return default(int);
		}
		[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CallerCount(Count = 1)]
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
		[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
		[CallerCount(Count = 0)]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(FontStyle);
		}
		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
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
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
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
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
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
		[Calls(Type = typeof(Utils), Member = "Approximately")]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[Calls(Type = typeof(Utils), Member = "Approximately")]
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UILabel), Member = "get_trueTypeFont")]
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(Overflow);
		}
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CallerCount(Count = 1)]
		set
		{
		}
	}

	public int lineWidth
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIWidget), Member = "set_width")]
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
		[Calls(Type = typeof(UILabel), Member = "ProcessText")]
		[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
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
		[CalledBy(Type = typeof(UIInput), Member = "ProcessEvent")]
		[CalledBy(Type = typeof(TypewriterEffect), Member = "Update")]
		[Calls(Type = typeof(UILabel), Member = "ProcessText")]
		[CallerCount(Count = 7)]
		[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
		[CalledBy(Type = typeof(Panel_Log), Member = "RefreshSelectedSkillDescriptionView")]
		[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
		[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
		[CalledBy(Type = typeof(UILabel), Member = "PrintOverlay")]
		get
		{
			return null;
		}
	}

	public Vector2 printedSize
	{
		[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
		[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
		[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
		[Calls(Type = typeof(UILabel), Member = "ProcessText")]
		[CallerCount(Count = 3)]
		get
		{
			return default(Vector2);
		}
	}

	public override Vector2 localSize
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(UILabel), Member = "ProcessText")]
		get
		{
			return default(Vector2);
		}
	}

	private bool isValid
	{
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
		[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
		[CalledBy(Type = typeof(UILabel), Member = "PrintOverlay")]
		[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		get
		{
			return default(bool);
		}
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "SetActiveFont")]
	[Calls(Type = typeof(UILabel), Member = "get_trueTypeFont")]
	[Calls(Type = typeof(UIWidget), Member = "OnInit")]
	protected override void OnInit()
	{
	}

	[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
	[Calls(Type = typeof(UILabel), Member = "SetActiveFont")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIRect), Member = "OnDisable")]
	protected override void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "ClearDynamicSymbolSprites")]
	protected void PreDisable()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallerCount(Count = 0)]
	public void ControlTypeChanged()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UILabel), Member = "OnDisable")]
	[CalledBy(Type = typeof(UILabel), Member = "OnInit")]
	[CalledBy(Type = typeof(UILabel), Member = "set_trueTypeFont")]
	[CalledBy(Type = typeof(UILabel), Member = "set_trueTypeFont")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	protected void SetActiveFont(Font fnt)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "get_trueTypeFont")]
	[Calls(Type = typeof(Font), Member = "RequestCharactersInTexture")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
	[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "get_trueTypeFont")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
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

	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(NGUITools), Member = "UpdateWidgetCollider")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
	[CallerCount(Count = 0)]
	protected override void UpgradeFrom265()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "OnAnchor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	protected override void OnAnchor()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "get_ambigiousFont")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[CallerCount(Count = 21)]
	private void ProcessAndRequest()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Font), Member = "add_textureRebuilt")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void OnEnable()
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
	[CallerCount(Count = 0)]
	protected override void OnStart()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "MarkAsChanged")]
	public override void MarkAsChanged()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void ProcessText()
	{
	}

	[Calls(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UILabel), Member = "get_keepCrisp")]
	[Calls(Type = typeof(UILabel), Member = "get_fontSize")]
	[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(NGUIText), Member = "Update")]
	[Calls(Type = typeof(NGUIText), Member = "CalculatePrintedSize")]
	[Calls(Type = typeof(NGUIText), Member = "CalculatePrintedSize")]
	[Calls(Type = typeof(NGUIText), Member = "CalculatePrintedSize")]
	[Calls(Type = typeof(NGUIText), Member = "WrapText")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(UILabel), Member = "get_keepCrisp")]
	[Calls(Type = typeof(UIRect), Member = "get_root")]
	[CallerCount(Count = 33)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UILabel), Member = "get_isValid")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UILabel), Member = "get_defaultFontSize")]
	[Calls(Type = typeof(UILabel), Member = "get_trueTypeFont")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	private void ProcessText(bool legacyMode, bool full)
	{
	}

	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIWidget), Member = "MakePixelPerfect")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "get_ambigiousFont")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(UILabel), Member = "get_ambigiousFont")]
	public override void MakePixelPerfect()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "get_ambigiousFont")]
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

	[Calls(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[CallerCount(Count = 0)]
	[Obsolete("Use UILabel.GetCharacterAtPosition instead")]
	public int GetCharacterIndex(Vector2 localPos)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(OpenURLOnClick), Member = "OnClick")]
	[CallerCount(Count = 3)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[CalledBy(Type = typeof(UIInput), Member = "GetCharUnderMouse")]
	public int GetCharacterIndexAtPosition(Vector3 worldPos, bool precise)
	{
		return default(int);
	}

	[Calls(Type = typeof(UILabel), Member = "get_isValid")]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[Calls(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[Calls(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	[Calls(Type = typeof(UILabel), Member = "ApplyOffset")]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(NGUIText), Member = "GetApproximateCharacterIndex")]
	[Calls(Type = typeof(UILabel), Member = "get_processedText")]
	[CallerCount(Count = 1)]
	public int GetCharacterIndexAtPosition(Vector2 localPos, bool precise)
	{
		return default(int);
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

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	[CalledBy(Type = typeof(OpenURLOnClick), Member = "OnClick")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string GetUrlAtCharacterIndex(int characterIndex)
	{
		return null;
	}

	[Calls(Type = typeof(UILabel), Member = "ApplyOffset")]
	[Calls(Type = typeof(NGUIText), Member = "GetApproximateCharacterIndex")]
	[CalledBy(Type = typeof(UIInput), Member = "ProcessEvent")]
	[CalledBy(Type = typeof(UIInput), Member = "ProcessEvent")]
	[CalledBy(Type = typeof(UIInput), Member = "ProcessEvent")]
	[CalledBy(Type = typeof(UIInput), Member = "ProcessEvent")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(NGUIText), Member = "PrintApproximateCharacterPositions")]
	[Calls(Type = typeof(UILabel), Member = "get_defaultFontSize")]
	[Calls(Type = typeof(UILabel), Member = "get_processedText")]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UILabel), Member = "get_isValid")]
	public int GetCharacterIndex(int currentIndex, KeyCode key)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(UILabel), Member = "ApplyOffset")]
	[Calls(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	[Calls(Type = typeof(UILabel), Member = "ApplyOffset")]
	[Calls(Type = typeof(NGUIText), Member = "PrintCaretAndSelection")]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[Calls(Type = typeof(UILabel), Member = "get_isValid")]
	[Calls(Type = typeof(UIGeometry), Member = "Clear")]
	[Calls(Type = typeof(UILabel), Member = "get_processedText")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIGeometry), Member = "Clear")]
	public void PrintOverlay(int start, int end, UIGeometry caret, UIGeometry highlight, Color caretColor, Color highlightColor)
	{
	}

	[Calls(Type = typeof(UILabel), Member = "ClearDynamicSymbolSprites")]
	[Calls(Type = typeof(NGUIText), Member = "Print")]
	[Calls(Type = typeof(UILabel), Member = "ApplyOffset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UILabel), Member = "ApplyShadow")]
	[Calls(Type = typeof(UILabel), Member = "ApplyShadow")]
	[Calls(Type = typeof(UILabel), Member = "ApplyShadow")]
	[Calls(Type = typeof(UILabel), Member = "ApplyShadow")]
	[Calls(Type = typeof(UILabel), Member = "ApplyShadow")]
	[Calls(Type = typeof(UILabel), Member = "ApplyShadow")]
	[Calls(Type = typeof(UILabel), Member = "ApplyShadow")]
	[Calls(Type = typeof(UIFont), Member = "get_packedFontShader")]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[Calls(Type = typeof(UILabel), Member = "ApplyShadow")]
	[Calls(Type = typeof(UILabel), Member = "get_processedText")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "GammaToLinearSpace")]
	[Calls(Type = typeof(Mathf), Member = "GammaToLinearSpace")]
	[Calls(Type = typeof(UIFont), Member = "get_premultipliedAlphaShader")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UILabel), Member = "get_isValid")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "GammaToLinearSpace")]
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CalledBy(Type = typeof(UILabel), Member = "PrintOverlay")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UILabel), Member = "PrintOverlay")]
	[CallerCount(Count = 5)]
	public Vector2 ApplyOffset(BetterList<Vector3> verts, int start)
	{
		return default(Vector2);
	}

	[Calls(Type = typeof(UIFont), Member = "get_premultipliedAlphaShader")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIFont), Member = "get_premultipliedAlphaShader")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void ApplyShadow(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, int start, int end, float x, float y)
	{
	}

	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(NGUIText), Member = "CalculateOffsetToFit")]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[CallerCount(Count = 2)]
	public int CalculateOffsetToFit(string text)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	public void SetCurrentProgress()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	public void SetCurrentPercent()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	public void SetCurrentSelection()
	{
	}

	[Calls(Type = typeof(NGUIText), Member = "WrapText")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
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

	[Calls(Type = typeof(NGUIText), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndexAtPosition")]
	[Calls(Type = typeof(UIRect), Member = "get_root")]
	[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
	[CalledBy(Type = typeof(UILabel), Member = "PrintOverlay")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(TextInputField), Member = "GetCursorLocation")]
	[CalledBy(Type = typeof(UITextList), Member = "Rebuild")]
	[Calls(Type = typeof(UILabel), Member = "get_keepCrisp")]
	[CalledBy(Type = typeof(UILabel), Member = "Wrap")]
	[CalledBy(Type = typeof(UILabel), Member = "CalculateOffsetToFit")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CalledBy(Type = typeof(UILabel), Member = "GetCharacterIndex")]
	[Calls(Type = typeof(UIFont), Member = "get_dynamicFont")]
	[CalledBy(Type = typeof(UILabel), Member = "Wrap")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
	[Calls(Type = typeof(UILabel), Member = "get_fontSize")]
	[Calls(Type = typeof(UIFont), Member = "get_packedFontShader")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UILabel), Member = "get_trueTypeFont")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(UIFont), Member = "get_isDynamic")]
	public void UpdateNGUIText()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
	public void AddDynamicSymbolSprite(UISprite uiSprite)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
	[CalledBy(Type = typeof(UILabel), Member = "PreDisable")]
	[Calls(Type = typeof(UIRoot), Member = "ReturnDynamicSymbolSpriteToPool")]
	[Calls(Type = typeof(UIRect), Member = "get_root")]
	[CallerCount(Count = 2)]
	private void ClearDynamicSymbolSprites()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
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

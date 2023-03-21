using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GridItem : MonoBehaviour
{
	public UIButton m_Button;

	public GameObject m_ItemElements;

	public UILabel m_NameLabel;

	public UITexture m_GearSprite;

	public TweenScale m_TweenScale;

	public UISprite m_SelectedSprite;

	public UISprite m_EquippedSprite;

	public UISprite m_RuinedSprite;

	public UILabel m_LiquidLabel;

	public UILabel m_StackLabel;

	public UILabel m_ConditionLabel;

	public UILabel m_WeightLabel;

	public UISprite m_WeightSprite;

	public UISprite m_ConditionSprite;

	public UISprite m_FavoritedSprite;

	public Color m_BlueGreenColor;

	public Color m_WhiteColor;

	public Color m_GoodConditionSpriteColor;

	public GameObject m_HoverEffect;

	public UILabel m_UnitLabel;

	public UISprite m_UnitSprite;

	private bool m_IsSelected;

	private GridUI m_GridUi;

	private int m_SelectionIndex;

	[CalledBy(Type = typeof(GridUI), Member = "InitializeNewItem")]
	[CalledBy(Type = typeof(GridUI), Member = "Initialize")]
	[CallerCount(Count = 2)]
	[CallAnalysisFailed]
	public void Initialize(GridUI gridUi)
	{
	}

	[CallerCount(Count = 0)]
	public void SetSelectionIndex(int value)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetSelectionIndex()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	public void OnClick()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Update")]
	[CalledBy(Type = typeof(GridUI), Member = "RefreshTable")]
	[CalledBy(Type = typeof(GridUI), Member = "RefreshTable")]
	[CalledBy(Type = typeof(GridUI), Member = "Update")]
	[CalledBy(Type = typeof(GridUI), Member = "Update")]
	[Calls(Type = typeof(GridUI), Member = "MoveSelectedSpriteAndTween")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Update")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallerCount(Count = 6)]
	public void ToggleSelection(bool toggleVal)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsSelected()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public GridItem()
	{
	}
}

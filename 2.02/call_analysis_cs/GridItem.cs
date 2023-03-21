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
	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	public void Initialize(GridUI gridUi)
	{
	}

	[DeduplicatedMethod]
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

	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(GridUI), Member = "RefreshTable")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(GridUI), Member = "MoveSelectedSpriteAndTween")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CalledBy(Type = typeof(GridUI), Member = "RefreshTable")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	public void ToggleSelection(bool toggleVal)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsSelected()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public GridItem()
	{
	}
}

using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIGrid : UIWidgetContainer
{
	public delegate void OnReposition();

	public enum Arrangement
	{
		Horizontal,
		Vertical,
		CellSnap
	}

	public enum Sorting
	{
		None,
		Alphabetic,
		Horizontal,
		Vertical,
		Custom
	}

	public Arrangement arrangement;

	public Sorting sorting;

	public UIWidget.Pivot pivot;

	public int maxPerLine;

	public float cellWidth;

	public float cellHeight;

	public bool animateSmoothly;

	public bool hideInactive;

	public bool keepWithinPanel;

	public OnReposition onReposition;

	public Comparison<Transform> onCustomSort;

	private bool sorted;

	protected bool mReposition;

	protected UIPanel mPanel;

	protected bool mInitDone;

	public bool repositionNow
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(UICenterOnChild), Member = "Recenter")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(UIGrid), Member = "AddChild")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Log), Member = "ClearGrid")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateDailyStatsPage")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "MaybeFadeOutIndividualDamageEvents")]
	[CalledBy(Type = typeof(UIGrid), Member = "Reposition")]
	[CalledBy(Type = typeof(UIGrid), Member = "GetChild")]
	[CalledBy(Type = typeof(UIGrid), Member = "RemoveChild")]
	[CalledBy(Type = typeof(UIGrid), Member = "AddChild")]
	[CalledBy(Type = typeof(UIGrid), Member = "GetIndex")]
	public List<Transform> GetChildList()
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "CleanupDamageEventTable")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "FadeOutAllEvents")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIGrid), Member = "GetChildList")]
	[CallerCount(Count = 2)]
	public Transform GetChild(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIGrid), Member = "GetChildList")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public int GetIndex(Transform trans)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIGrid), Member = "GetChildList")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void AddChild(Transform trans)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIGrid), Member = "GetChildList")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void AddChild(Transform trans, bool sort)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIGrid), Member = "GetChildList")]
	[CallsDeduplicatedMethods(Count = 2)]
	public bool RemoveChild(Transform t)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	protected virtual void Init()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnValidate()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static int SortByName(Transform a, Transform b)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static int SortHorizontal(Transform a, Transform b)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static int SortVertical(Transform a, Transform b)
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void Sort(List<Transform> list)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIGrid), Member = "ConstrainWithinPanel")]
	[Calls(Type = typeof(UIGrid), Member = "GetChildList")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[ContextMenu("Execute")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public virtual void Reposition()
	{
	}

	[CalledBy(Type = typeof(UIGrid), Member = "Reposition")]
	[Calls(Type = typeof(UIPanel), Member = "ConstrainTargetToBounds")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void ConstrainWithinPanel()
	{
	}

	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[Calls(Type = typeof(SpringPosition), Member = "Begin")]
	[CallerCount(Count = 0)]
	protected virtual void ResetPosition(List<Transform> list)
	{
	}

	[CallerCount(Count = 0)]
	public UIGrid()
	{
	}
}

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
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[CalledBy(Type = typeof(UIGrid), Member = "Reposition")]
	[CalledBy(Type = typeof(UIGrid), Member = "GetIndex")]
	[CalledBy(Type = typeof(UIGrid), Member = "AddChild")]
	[CalledBy(Type = typeof(UIGrid), Member = "AddChild")]
	[CalledBy(Type = typeof(UIGrid), Member = "RemoveChild")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateDailyStatsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ClearGrid")]
	[CallsUnknownMethods(Count = 41)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[CalledBy(Type = typeof(UIGrid), Member = "GetChild")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	public List<Transform> GetChildList()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "MaybeFadeOutIndividualDamageEvents")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "FadeOutAllEvents")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "CleanupDamageEventTable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIGrid), Member = "GetChildList")]
	public Transform GetChild(int index)
	{
		return null;
	}

	[Calls(Type = typeof(UIGrid), Member = "GetChildList")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int GetIndex(Transform trans)
	{
		return default(int);
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIGrid), Member = "GetChildList")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void AddChild(Transform trans)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UIGrid), Member = "GetChildList")]
	public void AddChild(Transform trans, bool sort)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UIGrid), Member = "GetChildList")]
	[CallsUnknownMethods(Count = 1)]
	public bool RemoveChild(Transform t)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	private void OnValidate()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Compare")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static int SortByName(Transform a, Transform b)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static int SortHorizontal(Transform a, Transform b)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static int SortVertical(Transform a, Transform b)
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected virtual void Sort(List<Transform> list)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIGrid), Member = "ConstrainWithinPanel")]
	[ContextMenu(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UIGrid), Member = "GetChildList")]
	public virtual void Reposition()
	{
	}

	[CalledBy(Type = typeof(UIGrid), Member = "Reposition")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIPanel), Member = "ConstrainTargetToBounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	public void ConstrainWithinPanel()
	{
	}

	[Calls(Type = typeof(Application), Member = "get_isPlaying")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[Calls(Type = typeof(SpringPosition), Member = "Begin")]
	[CallsUnknownMethods(Count = 13)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 8)]
	protected virtual void ResetPosition(List<Transform> list)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public UIGrid()
	{
	}
}

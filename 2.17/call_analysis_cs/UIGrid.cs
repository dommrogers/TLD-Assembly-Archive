using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Pool;

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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
	public void GetChildList(List<Transform> list)
	{
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "CleanupDamageEventTable")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "FadeOutAllEvents")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "MaybeFadeOutIndividualDamageEvents")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CollectionPool<, >), Member = "Get")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(List<>), Member = "Sort")]
	[Calls(Type = typeof(PooledObject<>), Member = "System.IDisposable.Dispose")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 16)]
	public Transform GetChild(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CollectionPool<, >), Member = "Get")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(PooledObject<>), Member = "System.IDisposable.Dispose")]
	[Calls(Type = typeof(List<>), Member = "Sort")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 14)]
	public int GetIndex(Transform trans)
	{
		return 0;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void AddChild(Transform trans)
	{
	}

	[CalledBy(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateDailyStatsPage")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(CollectionPool<, >), Member = "Get")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(PooledObject<>), Member = "System.IDisposable.Dispose")]
	[Calls(Type = typeof(List<>), Member = "Sort")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 14)]
	public void AddChild(Transform trans, bool sort)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CollectionPool<, >), Member = "Get")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(PooledObject<>), Member = "System.IDisposable.Dispose")]
	[Calls(Type = typeof(List<>), Member = "Sort")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 14)]
	public bool RemoveChild(Transform t)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "FindInParents")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Init()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
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
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static int SortByName(Transform a, Transform b)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static int SortHorizontal(Transform a, Transform b)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static int SortVertical(Transform a, Transform b)
	{
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void Sort(List<Transform> list)
	{
	}

	[ContextMenu("Execute")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(CollectionPool<, >), Member = "Get")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIGrid), Member = "ConstrainWithinPanel")]
	[Calls(Type = typeof(PooledObject<>), Member = "System.IDisposable.Dispose")]
	[Calls(Type = typeof(List<>), Member = "Sort")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 15)]
	public virtual void Reposition()
	{
	}

	[CalledBy(Type = typeof(UIGrid), Member = "Reposition")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIPanel), Member = "ConstrainTargetToBounds")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public void ConstrainWithinPanel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpringPosition), Member = "Begin")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 12)]
	protected virtual void ResetPosition(List<Transform> list)
	{
	}

	[CallerCount(Count = 0)]
	public UIGrid()
	{
	}
}

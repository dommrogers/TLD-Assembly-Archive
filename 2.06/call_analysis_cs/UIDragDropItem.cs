using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIDragDropItem : MonoBehaviour
{
	public enum Restriction
	{
		None,
		Horizontal,
		Vertical,
		PressAndHold
	}

	private sealed class _003CEnableDragScrollView_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIDragDropItem _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
		}

		[DeduplicatedMethod]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		public _003CEnableDragScrollView_003Ed__32(int _003C_003E1__state)
		{
		}

		[CallerCount(Count = 6)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 6)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 5)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public Restriction restriction;

	public bool cloneOnDrag;

	public float pressAndHoldDelay;

	public bool interactable;

	public Action m_OnPositionChanged;

	public Action m_OnPressed;

	[NonSerialized]
	protected Transform mTrans;

	[NonSerialized]
	protected Transform mParent;

	[NonSerialized]
	protected Collider mCollider;

	[NonSerialized]
	protected Collider2D mCollider2D;

	[NonSerialized]
	protected UIButton mButton;

	[NonSerialized]
	protected UIRoot mRoot;

	[NonSerialized]
	protected UIGrid mGrid;

	[NonSerialized]
	protected UITable mTable;

	[NonSerialized]
	protected float mDragStartTime;

	[NonSerialized]
	protected UIDragScrollView mDragScrollView;

	[NonSerialized]
	protected bool mPressed;

	[NonSerialized]
	protected bool mDragging;

	[NonSerialized]
	protected UICamera.MouseOrTouch mTouch;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 7)]
	protected virtual void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnPress(bool isPressed)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected virtual void OnDragStart()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(NGUITools), Member = "AddChild")]
	[CallsDeduplicatedMethods(Count = 27)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	protected virtual void StartDragging()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected virtual void OnDrag(Vector2 delta)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void OnDragEnd()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void StopDragging(GameObject go)
	{
	}

	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NGUITools), Member = "MarkParentAsChanged")]
	[CallsUnknownMethods(Count = 10)]
	protected virtual void OnDragDropStart()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	protected virtual void OnDragDropMove(Vector2 delta)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUITools), Member = "MarkParentAsChanged")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(ExampleDragDropItem), Member = "OnDragDropRelease")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NGUITools), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	protected virtual void OnDragDropRelease(GameObject surface)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	protected virtual void OnDragDropEnd()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[IteratorStateMachine(typeof(_003CEnableDragScrollView_003Ed__32))]
	protected IEnumerator EnableDragScrollView()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UIDragDropItem()
	{
	}
}

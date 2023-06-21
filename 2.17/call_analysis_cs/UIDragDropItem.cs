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
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CEnableDragScrollView_003Ed__32(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
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
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
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
	protected virtual void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void OnDragStart()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "AddChild")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallsUnknownMethods(Count = 16)]
	protected virtual void StartDragging()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(NGUITools), Member = "FindInParents")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(NGUITools), Member = "MarkParentAsChanged")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 10)]
	protected virtual void OnDragDropStart()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void OnDragDropMove(Vector2 delta)
	{
	}

	[CalledBy(Type = typeof(ExampleDragDropItem), Member = "OnDragDropRelease")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "Destroy")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "FindInParents")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(NGUITools), Member = "FindInParents")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(NGUITools), Member = "MarkParentAsChanged")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 8)]
	protected virtual void OnDragDropRelease(GameObject surface)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void OnDragDropEnd()
	{
	}

	[IteratorStateMachine(typeof(_003CEnableDragScrollView_003Ed__32))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
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

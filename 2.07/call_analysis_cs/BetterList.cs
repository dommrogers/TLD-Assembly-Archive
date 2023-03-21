using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

public class BetterList<T>
{
	public delegate int CompareFunc(T left, T right);

	private sealed class _003CGetEnumerator_003Ed__2 : IEnumerator<T>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		public BetterList<T> _003C_003E4__this;

		private int _003Ci_003E5__2;

		private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return default(T);
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CGetEnumerator_003Ed__2(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[DebuggerHidden]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public T[] buffer;

	public int size;

	public T Item
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(T);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	[IteratorStateMachine(typeof(BetterList<>._003CGetEnumerator_003Ed__2))]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[CallsUnknownMethods(Count = 2)]
	private void AllocateMore()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private void Trim()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Clear()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Release()
	{
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "Awake")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIToggle), Member = "OnEnable")]
	[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
	[CalledBy(Type = typeof(ByteReader), Member = "ReadCSV")]
	[CalledBy(Type = typeof(NGUIText), Member = "Print")]
	[CalledBy(Type = typeof(NGUIText), Member = "GetDynamicSymbol")]
	[CalledBy(Type = typeof(UIDrawCall), Member = "Create")]
	[CalledBy(Type = typeof(UIDrawCall), Member = "Destroy")]
	[CalledBy(Type = typeof(UIRect), Member = "OnInit")]
	[CalledBy(Type = typeof(UIRect), Member = "ParentHasChanged")]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetListOfSprites")]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetListOfSprites")]
	[CalledBy(Type = typeof(UICamera), Member = "OnEnable")]
	[CalledBy(Type = typeof(UILabel), Member = "OnInit")]
	[CalledBy(Type = typeof(UILabel), Member = "AddDynamicSymbolSprite")]
	[CalledBy(Type = typeof(UIRoot), Member = "CreateDynamicSymbolSprite")]
	[CalledBy(Type = typeof(UITextList), Member = "Add")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Add(T item)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void Insert(int index, T item)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public bool Contains(T item)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public int IndexOf(T item)
	{
		return 0;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnDisable")]
	[CalledBy(Type = typeof(UIScrollView), Member = "OnDisable")]
	[CalledBy(Type = typeof(UIToggle), Member = "OnDisable")]
	[CalledBy(Type = typeof(UIDrawCall), Member = "Destroy")]
	[CalledBy(Type = typeof(UIRect), Member = "OnDisable")]
	[CalledBy(Type = typeof(UIRect), Member = "ParentHasChanged")]
	[CalledBy(Type = typeof(UICamera), Member = "OnDisable")]
	[CalledBy(Type = typeof(UILabel), Member = "OnDisable")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public bool Remove(T item)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(TypewriterEffect), Member = "Update")]
	[CalledBy(Type = typeof(UITextList), Member = "Add")]
	[CalledBy(Type = typeof(StringTable), Member = "ImportCsv")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void RemoveAt(int index)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public T Pop()
	{
		return default(T);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public T[] ToArray()
	{
		return null;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Sort(CompareFunc comparer)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public BetterList()
	{
	}
}

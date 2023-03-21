using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer.Internal;

public class fsCyclicReferenceManager
{
	private class ObjectReferenceEqualityComparator : IEqualityComparer<object>
	{
		public static readonly IEqualityComparer<object> Instance;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private bool System_002ECollections_002EGeneric_002EIEqualityComparer_003CSystem_002EObject_003E_002EEquals(object x, object y)
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private int System_002ECollections_002EGeneric_002EIEqualityComparer_003CSystem_002EObject_003E_002EGetHashCode(object obj)
		{
			return default(int);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public ObjectReferenceEqualityComparator()
		{
		}
	}

	private Dictionary<object, int> _objectIds;

	private int _nextId;

	private Dictionary<int, object> _marked;

	private int _depth;

	[CalledBy(Type = typeof(fsSerializer), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public fsCyclicReferenceManager()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Enter()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[CallsUnknownMethods(Count = 6)]
	public bool Exit()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public object GetReferenceObject(int id)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void AddReferenceWithId(int id, object reference)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(fsCyclicReferenceManager), Member = "MarkSerialized")]
	[CalledBy(Type = typeof(fsCyclicReferenceManager), Member = "IsReference")]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	public int GetReferenceId(object item)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(fsCyclicReferenceManager), Member = "GetReferenceId")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsReference(object item)
	{
		return default(bool);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(fsCyclicReferenceManager), Member = "GetReferenceId")]
	[CallsUnknownMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void MarkSerialized(object item)
	{
	}
}

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

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public ObjectReferenceEqualityComparator()
		{
		}
	}

	private Dictionary<object, int> _objectIds;

	private int _nextId;

	private Dictionary<int, object> _marked;

	private int _depth;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(fsSerializer), Member = ".ctor")]
	[CallsUnknownMethods(Count = 16)]
	public fsCyclicReferenceManager()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Enter()
	{
	}

	[CalledBy(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[CallsUnknownMethods(Count = 5)]
	public bool Exit()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public object GetReferenceObject(int id)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void AddReferenceWithId(int id, object reference)
	{
	}

	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(fsCyclicReferenceManager), Member = "IsReference")]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
	[CalledBy(Type = typeof(fsCyclicReferenceManager), Member = "MarkSerialized")]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
	public int GetReferenceId(object item)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(fsCyclicReferenceManager), Member = "GetReferenceId")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public bool IsReference(object item)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(fsCyclicReferenceManager), Member = "GetReferenceId")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 4)]
	public void MarkSerialized(object item)
	{
	}
}

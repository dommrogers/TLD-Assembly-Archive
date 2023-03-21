using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace ParadoxNotion;

public class HierarchyTree
{
	public class Element
	{
		public object reference;

		public Element parent;

		public List<Element> children;

		[DeduplicatedMethod]
		[CallerCount(Count = 269)]
		public Element(object reference)
		{
		}

		[CalledBy(Type = typeof(Graph), Member = "GetFlatGraphHierarchy")]
		[CalledBy(Type = typeof(Graph), Member = "GetFullGraphHierarchy")]
		[CalledBy(Type = typeof(Graph), Member = "GetNestedGraphHierarchy")]
		[CalledBy(Type = typeof(Graph), Member = "GetTreeNodeElement")]
		[CalledBy(Type = typeof(Graph), Member = "GetTaskAndParametersStructureInTarget")]
		[CallerCount(Count = 8)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		public void AddChild(Element child)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List<>), Member = "Remove")]
		public void RemoveChild(Element child)
		{
		}

		[CallerCount(Count = 0)]
		public Element GetRoot()
		{
			return null;
		}

		[CalledBy(Type = typeof(Element), Member = "FindReferenceElement")]
		[CalledBy(Type = typeof(Graph), Member = "GetTaskParentElement")]
		[CalledBy(Type = typeof(Graph), Member = "GetParameterParentElement")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Element), Member = "FindReferenceElement")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsUnknownMethods(Count = 2)]
		public Element FindReferenceElement(object target)
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		public T GetFirstParentReferenceOfType<T>()
		{
			return default(T);
		}

		[DeduplicatedMethod]
		[CalledBy(Type = typeof(Graph), Member = "GetTasksInElement")]
		[CalledBy(Type = typeof(Graph), Member = "GetParametersInElement")]
		[CalledBy(Type = typeof(Graph), Member = "GetDefinedParameters")]
		[CallerCount(Count = 3)]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 12)]
		public List<T> GetAllChildrenReferencesOfType<T>()
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public HierarchyTree()
	{
	}
}

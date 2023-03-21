using System;
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

		[CallerCount(Count = 279)]
		[DeduplicatedMethod]
		public Element(object reference)
		{
		}

		[CalledBy(Type = typeof(Graph), Member = "GetTreeNodeElement")]
		[CalledBy(Type = typeof(Graph), Member = "GetTreeNodeElement")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(Graph), Member = "GetTaskAndParametersStructureInTarget")]
		[CalledBy(Type = typeof(Graph), Member = "GetNestedGraphHierarchy")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(Graph), Member = "GetFullGraphHierarchy")]
		[CalledBy(Type = typeof(Graph), Member = "GetFlatGraphHierarchy")]
		[CalledBy(Type = typeof(Graph), Member = "GetFlatGraphHierarchy")]
		[CalledBy(Type = typeof(Graph), Member = "GetFullGraphHierarchy")]
		[CallerCount(Count = 8)]
		public void AddChild(Element child)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public void RemoveChild(Element child)
		{
		}

		[CallerCount(Count = 0)]
		public Element GetRoot()
		{
			return null;
		}

		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(Graph), Member = "GetParameterParentElement")]
		[CalledBy(Type = typeof(Graph), Member = "GetTaskParentElement")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[Calls(Type = typeof(Element), Member = "FindReferenceElement")]
		[CallerCount(Count = 3)]
		[CalledBy(Type = typeof(Element), Member = "FindReferenceElement")]
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
			return (T)null;
		}

		[CallsUnknownMethods(Count = 9)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[CallsDeduplicatedMethods(Count = 4)]
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

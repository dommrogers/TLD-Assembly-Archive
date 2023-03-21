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
		[CalledBy(Type = typeof(Graph), Member = "GetNestedGraphHierarchy")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(Graph), Member = "GetTaskAndParametersStructureInTarget")]
		[CalledBy(Type = typeof(Graph), Member = "GetFullGraphHierarchy")]
		[CalledBy(Type = typeof(Graph), Member = "GetTreeNodeElement")]
		[CalledBy(Type = typeof(Graph), Member = "GetFlatGraphHierarchy")]
		[CallerCount(Count = 8)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(Graph), Member = "GetFullGraphHierarchy")]
		[CalledBy(Type = typeof(Graph), Member = "GetFlatGraphHierarchy")]
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
		[CalledBy(Type = typeof(Element), Member = "FindReferenceElement")]
		[CalledBy(Type = typeof(Graph), Member = "GetTaskParentElement")]
		[Calls(Type = typeof(Element), Member = "FindReferenceElement")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
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

		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 9)]
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		public List<T> GetAllChildrenReferencesOfType<T>()
		{
			return null;
		}
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public HierarchyTree()
	{
	}
}

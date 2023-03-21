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

		[CallerCount(Count = 101)]
		[DeduplicatedMethod]
		public Element(object reference)
		{
		}

		[CalledBy(Type = typeof(Graph), Member = "GetTreeNodeElement")]
		[CalledBy(Type = typeof(Graph), Member = "GetTaskAndParametersStructureInTarget")]
		[CalledBy(Type = typeof(Graph), Member = "GetTreeNodeElement")]
		[CallsUnknownMethods(Count = 9)]
		[CalledBy(Type = typeof(Graph), Member = "GetNestedGraphHierarchy")]
		[CallerCount(Count = 7)]
		[CalledBy(Type = typeof(Graph), Member = "GetFullGraphHierarchy")]
		[CalledBy(Type = typeof(Graph), Member = "GetFlatGraphHierarchy")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CalledBy(Type = typeof(Graph), Member = "GetFullGraphHierarchy")]
		public void AddChild(Element child)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		public void RemoveChild(Element child)
		{
		}

		[CallerCount(Count = 0)]
		public Element GetRoot()
		{
			return null;
		}

		[CalledBy(Type = typeof(Element), Member = "FindReferenceElement")]
		[CalledBy(Type = typeof(Graph), Member = "GetParameterParentElement")]
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(Graph), Member = "GetTaskParentElement")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Element), Member = "FindReferenceElement")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
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

		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 17)]
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		public List<T> GetAllChildrenReferencesOfType<T>()
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public HierarchyTree()
	{
	}
}

using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace NodeCanvas.Framework.Internal;

[Serializable]
public class GraphSerializationData
{
	public const float FRAMEWORK_VERSION = 2.91f;

	public float version;

	public Type type;

	public string name;

	public string category;

	public string comments;

	public Vector2 translation;

	public float zoomFactor;

	public List<Node> nodes;

	public List<Connection> connections;

	public List<CanvasGroup> canvasGroups;

	public BlackboardSource localBlackboard;

	public object derivedData;

	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public GraphSerializationData()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Graph), Member = "Serialize")]
	[CallsUnknownMethods(Count = 18)]
	public GraphSerializationData(Graph graph)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Graph), Member = "LoadGraphData")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void Reconstruct(Graph graph)
	{
	}
}

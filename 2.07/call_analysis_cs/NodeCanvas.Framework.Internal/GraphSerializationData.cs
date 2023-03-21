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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public GraphSerializationData()
	{
	}

	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Graph), Member = "CopySerialized")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Graph), Member = "Serialize")]
	public GraphSerializationData(Graph graph)
	{
	}

	[CalledBy(Type = typeof(Graph), Member = "LoadGraphData")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	public void Reconstruct(Graph graph)
	{
	}
}

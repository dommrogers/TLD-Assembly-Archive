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

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Graph), Member = "CopySerialized")]
	[CalledBy(Type = typeof(Graph), Member = "Serialize")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	public GraphSerializationData(Graph graph)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Graph), Member = "LoadGraphData")]
	[CallsUnknownMethods(Count = 4)]
	public void Reconstruct(Graph graph)
	{
	}
}

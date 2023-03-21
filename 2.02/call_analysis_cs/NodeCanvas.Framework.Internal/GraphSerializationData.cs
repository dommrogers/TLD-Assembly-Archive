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
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	public GraphSerializationData()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Graph), Member = "Serialize")]
	[CallsUnknownMethods(Count = 29)]
	public GraphSerializationData(Graph graph)
	{
	}

	[CalledBy(Type = typeof(Graph), Member = "LoadGraphData")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void Reconstruct(Graph graph)
	{
	}
}

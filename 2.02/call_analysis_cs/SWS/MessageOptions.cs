using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace SWS;

[Serializable]
public class MessageOptions
{
	public enum ValueType
	{
		None,
		Object,
		Text,
		Numeric,
		Vector2,
		Vector3
	}

	public List<string> message;

	public List<UnityEngine.Object> obj;

	public List<string> text;

	public List<float> num;

	public List<Vector2> vect2;

	public List<Vector3> vect3;

	public List<ValueType> type;

	public float pos;

	[CalledBy(Type = typeof(Messages), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 64)]
	public MessageOptions()
	{
	}
}

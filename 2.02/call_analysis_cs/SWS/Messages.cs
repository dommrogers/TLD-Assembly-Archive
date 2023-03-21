using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace SWS;

[Serializable]
public class Messages
{
	public List<MessageOptions> list;

	[CalledBy(Type = typeof(Messages), Member = "GetMessageOption")]
	[CalledBy(Type = typeof(navMove), Member = "StartMove")]
	[CalledBy(Type = typeof(splineMove), Member = "StartMove")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MessageOptions), Member = ".ctor")]
	[Calls(Type = typeof(Messages), Member = "AddEmptyToOption")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	public void Initialize(int size)
	{
	}

	[CalledBy(Type = typeof(Messages), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 17)]
	public MessageOptions AddEmptyToOption(MessageOptions opt)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 23)]
	public void FillOptionWithValues(MessageOptions opt)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Messages), Member = "Initialize")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public MessageOptions GetMessageOption(int waypoint)
	{
		return null;
	}

	[CalledBy(Type = typeof(bezierMove), Member = "CheckPoint")]
	[CalledBy(TypeFullName = "SWS.navMove.<NextWaypoint>d__19", Member = "MoveNext")]
	[CalledBy(TypeFullName = "SWS.navMove.<ReachedEnd>d__22", Member = "MoveNext")]
	[CalledBy(TypeFullName = "SWS.splineMove.<NextWaypoint>d__40", Member = "MoveNext")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Component), Member = "SendMessage")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 28)]
	public void Execute(MonoBehaviour mono, int index)
	{
	}

	[CalledBy(Type = typeof(bezierMove), Member = ".ctor")]
	[CalledBy(Type = typeof(navMove), Member = ".ctor")]
	[CalledBy(Type = typeof(splineMove), Member = ".ctor")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public Messages()
	{
	}
}

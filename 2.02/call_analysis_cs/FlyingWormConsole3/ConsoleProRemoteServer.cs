using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace FlyingWormConsole3;

public class ConsoleProRemoteServer : MonoBehaviour
{
	public bool useNATPunch;

	public int port;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ConsoleProRemoteServer()
	{
	}
}

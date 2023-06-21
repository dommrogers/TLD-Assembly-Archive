using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace FlyingWormConsole3;

public class ConsoleProRemoteServer : MonoBehaviour
{
	public bool useNATPunch;

	public int port;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	public ConsoleProRemoteServer()
	{
	}
}

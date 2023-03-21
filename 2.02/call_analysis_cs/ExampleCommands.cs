using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ExampleCommands : MonoBehaviour
{
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[CallsUnknownMethods(Count = 49)]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	private void Start()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "UnRegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "UnRegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "UnRegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "UnRegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "UnRegisterCommand")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "UnRegisterCommand")]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(uConsole), Member = "Log")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void EchoNothing()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(uConsole), Member = "Log")]
	public void EchoInteger()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "Log")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	public void EchoFloat()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "Log")]
	[Calls(Type = typeof(uConsole), Member = "Log")]
	public void EchoBool()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public void EchoString()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(uConsole), Member = "Log")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public void EchoStrings()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(SceneManager), Member = "LoadScene")]
	[Calls(Type = typeof(uConsole), Member = "TurnOff")]
	public static void LoadScene()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ExampleCommands()
	{
	}
}

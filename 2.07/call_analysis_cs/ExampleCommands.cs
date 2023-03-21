using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ExampleCommands : MonoBehaviour
{
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	private void Start()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "UnRegisterCommand")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "UnRegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "UnRegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "UnRegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "UnRegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "UnRegisterCommand")]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void EchoNothing()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[CallsUnknownMethods(Count = 1)]
	public void EchoInteger()
	{
	}

	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	public void EchoFloat()
	{
	}

	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public void EchoBool()
	{
	}

	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public void EchoString()
	{
	}

	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public void EchoStrings()
	{
	}

	[Calls(Type = typeof(SceneManager), Member = "LoadScene")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	public static void LoadScene()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ExampleCommands()
	{
	}
}

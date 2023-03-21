using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ExampleCommands : MonoBehaviour
{
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[CallsUnknownMethods(Count = 36)]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "UnRegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "UnRegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "UnRegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "UnRegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "UnRegisterCommand")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "UnRegisterCommand")]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[CallsUnknownMethods(Count = 1)]
	public void EchoNothing()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[CallsUnknownMethods(Count = 1)]
	public void EchoInteger()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[CallerCount(Count = 0)]
	public void EchoFloat()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	public void EchoBool()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	public void EchoString()
	{
	}

	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	public void EchoStrings()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(SceneManager), Member = "LoadScene")]
	public static void LoadScene()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public ExampleCommands()
	{
	}
}

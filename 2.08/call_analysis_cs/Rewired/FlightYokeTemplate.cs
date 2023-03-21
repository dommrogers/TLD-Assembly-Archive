using System;
using Cpp2ILInjected.CallAnalysis;

namespace Rewired;

public sealed class FlightYokeTemplate : ControllerTemplate, IFlightYokeTemplate, IControllerTemplate
{
	public static readonly Guid typeGuid;

	public const int elementId_rotateYoke = 0;

	public const int elementId_yokeZ = 1;

	public const int elementId_leftPaddle = 59;

	public const int elementId_rightPaddle = 60;

	public const int elementId_lever1Axis = 2;

	public const int elementId_lever1MinDetent = 64;

	public const int elementId_lever2Axis = 3;

	public const int elementId_lever2MinDetent = 65;

	public const int elementId_lever3Axis = 4;

	public const int elementId_lever3MinDetent = 66;

	public const int elementId_lever4Axis = 5;

	public const int elementId_lever4MinDetent = 67;

	public const int elementId_lever5Axis = 6;

	public const int elementId_lever5MinDetent = 68;

	public const int elementId_leftGripButton1 = 7;

	public const int elementId_leftGripButton2 = 8;

	public const int elementId_leftGripButton3 = 9;

	public const int elementId_leftGripButton4 = 10;

	public const int elementId_leftGripButton5 = 11;

	public const int elementId_leftGripButton6 = 12;

	public const int elementId_rightGripButton1 = 13;

	public const int elementId_rightGripButton2 = 14;

	public const int elementId_rightGripButton3 = 15;

	public const int elementId_rightGripButton4 = 16;

	public const int elementId_rightGripButton5 = 17;

	public const int elementId_rightGripButton6 = 18;

	public const int elementId_centerButton1 = 19;

	public const int elementId_centerButton2 = 20;

	public const int elementId_centerButton3 = 21;

	public const int elementId_centerButton4 = 22;

	public const int elementId_centerButton5 = 23;

	public const int elementId_centerButton6 = 24;

	public const int elementId_centerButton7 = 25;

	public const int elementId_centerButton8 = 26;

	public const int elementId_wheel1Up = 53;

	public const int elementId_wheel1Down = 54;

	public const int elementId_wheel1Press = 55;

	public const int elementId_wheel2Up = 56;

	public const int elementId_wheel2Down = 57;

	public const int elementId_wheel2Press = 58;

	public const int elementId_leftGripHatUp = 27;

	public const int elementId_leftGripHatUpRight = 28;

	public const int elementId_leftGripHatRight = 29;

	public const int elementId_leftGripHatDownRight = 30;

	public const int elementId_leftGripHatDown = 31;

	public const int elementId_leftGripHatDownLeft = 32;

	public const int elementId_leftGripHatLeft = 33;

	public const int elementId_leftGripHatUpLeft = 34;

	public const int elementId_rightGripHatUp = 35;

	public const int elementId_rightGripHatUpRight = 36;

	public const int elementId_rightGripHatRight = 37;

	public const int elementId_rightGripHatDownRight = 38;

	public const int elementId_rightGripHatDown = 39;

	public const int elementId_rightGripHatDownLeft = 40;

	public const int elementId_rightGripHatLeft = 41;

	public const int elementId_rightGripHatUpLeft = 42;

	public const int elementId_consoleButton1 = 43;

	public const int elementId_consoleButton2 = 44;

	public const int elementId_consoleButton3 = 45;

	public const int elementId_consoleButton4 = 46;

	public const int elementId_consoleButton5 = 47;

	public const int elementId_consoleButton6 = 48;

	public const int elementId_consoleButton7 = 49;

	public const int elementId_consoleButton8 = 50;

	public const int elementId_consoleButton9 = 51;

	public const int elementId_consoleButton10 = 52;

	public const int elementId_mode1 = 61;

	public const int elementId_mode2 = 62;

	public const int elementId_mode3 = 63;

	public const int elementId_yoke = 69;

	public const int elementId_lever1 = 70;

	public const int elementId_lever2 = 71;

	public const int elementId_lever3 = 72;

	public const int elementId_lever4 = 73;

	public const int elementId_lever5 = 74;

	public const int elementId_leftGripHat = 75;

	public const int elementId_rightGripHat = 76;

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EleftPaddle
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002ErightPaddle
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EleftGripButton1
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EleftGripButton2
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EleftGripButton3
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EleftGripButton4
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EleftGripButton5
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EleftGripButton6
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002ErightGripButton1
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002ErightGripButton2
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002ErightGripButton3
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002ErightGripButton4
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002ErightGripButton5
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002ErightGripButton6
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton1
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton2
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton3
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton4
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton5
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton6
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton7
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton8
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Ewheel1Up
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Ewheel1Down
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Ewheel1Press
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Ewheel2Up
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Ewheel2Down
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Ewheel2Press
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton1
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton2
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton3
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton4
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton5
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton6
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton7
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton8
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton9
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton10
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Emode1
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Emode2
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Emode3
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateYoke Rewired_002EIFlightYokeTemplate_002Eyoke
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateThrottle Rewired_002EIFlightYokeTemplate_002Elever1
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateThrottle Rewired_002EIFlightYokeTemplate_002Elever2
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateThrottle Rewired_002EIFlightYokeTemplate_002Elever3
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateThrottle Rewired_002EIFlightYokeTemplate_002Elever4
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateThrottle Rewired_002EIFlightYokeTemplate_002Elever5
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateHat Rewired_002EIFlightYokeTemplate_002EleftGripHat
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateHat Rewired_002EIFlightYokeTemplate_002ErightGripHat
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ControllerTemplate), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public FlightYokeTemplate(object payload)
		: base(null)
	{
	}
}

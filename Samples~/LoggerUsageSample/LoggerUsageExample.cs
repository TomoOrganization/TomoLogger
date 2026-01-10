using UnityEngine;
//Type alias implementation
using Logger = Tomo.LoggingSystem.Logger;

//Namespace only needed if custom colour changing is required
using Tomo.LoggingSystem;

public class LoggerUsageExample : MonoBehaviour
{
	void Awake()
	{
		//Usual usage
		Logger.Log("This is a debug log");
		Logger.LogWarning("This is a Warning log");
		Logger.LogError("This is a Error log");

		//If you want to have custom tag for the log
		Logger.Log("This is a special log!", "CustomTag");

		//Applies custom colour for default script tag
		//Uses unity colours
		Logger.SetOverrideColour(
			new LoggerColourSettings(
				Color.blue,
				Color.yellow,
				Color.black
			)
		);

		//Another way to change colour; Changes colour for a custom tag specified
		//Uses hexadecimals
		Logger.SetOverrideColour(
			new LoggerColourSettings(
				"00FFFF",
				"FF7F7F",
				"654321"
			),
			"CustomTag"
		);

		Logger.Log("This log is now blue!");
		Logger.Log("This log is now cyan!", "CustomTag");

	}
}

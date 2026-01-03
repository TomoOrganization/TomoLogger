#Tomo's Logging system
## What is it?
This plugin adds additional QOL and functionality on top of unity's default console log.

Functionality includes
- Colored logs according to severity
- Auto log file saving
- Log tagging for understanding at glance

## Implementation example
To use it, simply include the namespace like this

```
using Logger = Tomo.LoggingSystem.Logger;

Logger.Log("Hello, world");
```

Or

```
using static Tomo.LoggingSystem.Logger;

Log("Hello, world");
```

It is recommended to use it like the first example shown, as it is closer to default unity's implementation. Additionally if you want it to be totally seemless, you can do this instead
```
using Debug = Tomo.LoggingSystem.Logger;
```
though it is not recommended as it may blend too well and have no differenciation with unity's default debug.

##Installation
To use this in your unity project, simply go to your project's package manager and input this repo's URL with ".git" at the end
https://github.com/TomoOrganization/TomoLogger.git

#license
This project is licensed under the MIT License.
See the MIT LICENSE tab for details.

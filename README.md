# Setup #
1. If you haven't already, go to https://amplitude.com and register for an account. You will receive an API Key.
2. [Download the source code](https://github.com/apead/Xamarin-Amplitude-iOS/archive/master.zip) and extract the zip file. Alternatively, you can pull directly from GitHub.
3. Copy the Xamarin.Amplitude.Ios folder into the source of your solution in Xamarin Studio (or Visual Studio).   Add the project to your solution.

4. In every file that uses analytics, import AmplitudeSdk at the top:
    ``` cs
    Using AmplitudeSdk
    ```

5. In the FinishedLaunching method of your AppDelegate.cs file, initialize the SDK:
    ``` cs
        Amplitude.Instance.InitializeApiKey("YOUR_API_KEY_HERE");
    ```

6. To track an event anywhere in the app, call:
    ``` cs
        Amplitude.Instance.LogEvent("EVENT_IDENTIFIER_HERE");
    ```

7. Events are saved locally. Uploads are batched to occur every 30 events and every 30 seconds, as well as on app close. After calling logEvent in your app, you will immediately see data appear on the Amplitude Website.


# Setting Custom User IDs #

If your app has its own login system that you want to track users with, you can call `SetUserId` at any time:

``` cs
       Amplitude.Instance.SetUserId("USER_ID_HERE");
```

A user's data will be merged on the backend so that any events up to that point on the same device will be tracked under the same user.

You can also add the user ID as an argument to the `InitializeApiKey` call:

``` cs
       Amplitude.Instance.InitializeApiKey("YOUR_API_KEY_HERE", "USER_ID_HERE");
```

# Allowing Users to Opt Out

To stop all event and session logging for a user, set property OptOut:

``` cs
       Amplitude.Instance.OptOut = true;
```

Logging can be restarted by setting OptOut again with enabled set to false.
No events will be logged during any period opt out is enabled, even after opt
out is disabled.

# Tracking Revenue #

To track revenue from a user, call

``` cs
         Amplitude.Instance.LogRevenue("productIdentifier","quantity","price"]
```

# Advanced #

This SDK automatically grabs useful data from the phone, including app version, phone model, operating system version, and carrier information. If the user has granted your app location permissions, the SDK will also grab the location of the user. 

User IDs are automatically generated and will default to device specific identifiers if not specified.

Device IDs use identifierForVendor if available, or a random ID otherwise. You can retrieve the Device ID that Amplitude uses with `Amplitude.Instance.GetDeviceId()`.

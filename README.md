# LiveSplit.StreamingPredictionsComponent
This Component automates creating a Prediction for your current Run when you do it - it frees up your mods (so they can participate!). Using Predictions, you can have your community be engaged with every run you do, even if you reset 20 times a day or are struggling to get that new PB - the believers will be rewarded!

It currently comes with the following additional Options:
* Automatically resolve the Prediction depending on if you PB or not (enabled by default)
* Refunding invested points if you reset (by cancelling the prediction)
* Creating the Prediction at a later point in the Run
* Locking the Prediction when you reach a Split
* Changing the Title and Option Names of the Prediction

In the near future, I plan to add the following features:
* "Am I ahead?"-Mode
  * Creating a new Prediction for every split and resolving it based on wether you are ahead at the end of it
* Checking if you are ahead on a certain split to resolve before the end of the run
* Resolving the prediction depending on if a specific Split lost or saved time

I'm very open to feature requests or people opening Pull Requests to directly contribute to it - it's Open Source!

To use it, simply download the DLL from the releases Tab, put it into the LiveSplit "Components" Folder, (restart LiveSplit,) Edit Layout, Add a Component -> Other -> Streaming Predictions Integration, Edit Layout -> Layout Settings -> Streaming Predictions Integration, click "Get New Token" to authorize the Component with Twitch so it can manage your predictions, then configure it to your liking!

(Do note that you need to have access to Channel Points on Twitch / be Twitch Affiliate to use Predictions.)

At the time of writing, it does not support (read: I didn't Test it) multiple instances of the Component, so use at your own risk.

Feel free to report Issues or in DMs to me (Marenthyu) on Social Media.

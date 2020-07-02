# FFXIV PraeCastrum Timer
An Advanced Combat Tracker (ACT) Plugin to show how much time is left in FFXIV Castrum/Praetorium cutscenes.

## Why?

Since Castrum and Praetorium are full of long, unskippable cutscenes, I'll often tab out to do other things when they start playing. However, to make sure I catch when the cutscene ends, I'll often tab back in to check the cutscene progress. I found this really annoying, so this plugin aims to remove the need for that. It parses ACT messages to detect when a cutscene begins, and shows a timer counting down to when the cutscene ends.

<p align="center">
    <img src="images/example.png" width="600"/>
</p>

## Installation

See the [releases page](https://github.com/Ricimon/FFXIV_PraeCastrum_Timer/releases) for download archives.

*Only english game clients are supported at this time.*

- Place the downloaded dll file into ACT plugins folder by opening Windows Explorer to `%APPDATA%/Advanced Combat Tracker/Plugins` and moving the dll into there.

- In ACT, click on **Browse** and open the dll file in the Plugins folder.

- Click on **Add/Enable Plugin** and make sure the **Enabled** checkbox for the plugin is checked.

## Usage

In ACT, navigate to the **Plugins** tab and click on the **FFXIV PraeCastrum Timer** tab. Timers will appear here when the plugin detects a run has been started.

If an incorrect run was detected, click on **Abort Run**.

To force start a specific run, in case the start trigger wasn't detected, click on the corresponding button.

If a checkpoint was missed for some reason, click on **Skip Checkpoint** to advance the run state.

## Coming Soon™

- *Play a sound when a cutscene is almost over*
- *In-game timer overlay*
- *Accurate timers for non-english VO*

## License

MIT License. See [License](LICENSE) for details.
